using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExameImport.Web.Models;
using ExameImport.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using System.IO;
using ExameImport.Business.Tools;
using System.Globalization;
using ExameImport.Business.Interfaces;
using ExameImport.Business.Models;
using AutoMapper;

namespace ExameImport.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStatementService _statementService;
        private readonly IMapper _mapper;
        public HomeController(IStatementService statementService, IMapper mapper)
        {
            _statementService = statementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ImportViewModel importViewModel)
        {            

            if (!ModelState.IsValid) return View("Index",importViewModel);

            var impPrefixo = Guid.NewGuid() + "_";

            if (!await UploadArquivo(importViewModel.ArquivoUpload, impPrefixo))
            {
                return View("Index", importViewModel);
            }

            var Statements = MapStatement(importViewModel.ArquivoUpload, impPrefixo);
            //If the mapping failed return message to the view
            if (Statements.Count == 0)
            {
                ModelState.AddModelError(string.Empty, "Could not get file information. Please try again or select another file.");
                return View("Index", importViewModel);
            }
            
            await _statementService.Create(_mapper.Map<List<Statement>>(Statements));            

            return RedirectToAction("StatementBank");
        }

        public IActionResult StatementBank()
        {
            //Getting all the last records saved in bank and map entity with Auto Mapper
            var Statements = _mapper.Map<List<StatementViewModel>>(_statementService.GetAllStatementsBank().Result);
            if (Statements != null && Statements.Count > 0)
                return View(Statements);

            return View();
        }
        //Method to write the file to folder
        private async Task<bool> UploadArquivo(List<IFormFile> Files, string impPrefixo)
        {            
            foreach (var file in Files)
            {
                if (file.Length <= 0) return false;

                //Getting path of File
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/arquivos", impPrefixo + file.FileName);

                if (System.IO.File.Exists(path))
                {
                    ModelState.AddModelError(string.Empty, "Já existe um arquivo com este nome!");
                    return false;
                }
                //Saving File
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                
            }            

            return true;
        }
        //Mapping xml to entity
        private List<StatementViewModel> MapStatement(List<IFormFile> Files, string impPrefixo)
        {
            List<StatementViewModel> statements = new List<StatementViewModel>();
            foreach (var file in Files)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/arquivos", impPrefixo + file.FileName);

                var Result = ImportFileOfx.toXElement(path);

                var imps = (from c in Result.Descendants("STMTTRN")
                            where c.Element("TRNTYPE").Value == "DEBIT" || c.Element("TRNTYPE").Value == "CREDIT"
                            select new StatementViewModel
                            {
                                Amount = decimal.Parse(c.Element("TRNAMT").Value.Replace("-", ""),
                                                       NumberFormatInfo.InvariantInfo),
                                Data = DateTime.ParseExact(c.Element("DTPOSTED").Value,
                                                           "yyyyMMdd", CultureInfo.CurrentCulture),
                                Description = c.Element("MEMO").Value,
                                Action = c.Element("TRNTYPE").Value
                            });
                statements.AddRange(imps);
            }            

            return statements;
        }        
    }
}
