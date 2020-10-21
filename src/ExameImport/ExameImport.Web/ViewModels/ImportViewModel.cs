using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExameImport.Web.ViewModels
{
    public class ImportViewModel
    {
        [Required(ErrorMessage = "Field {0} is required.")]
        [DisplayName("File")]        
        public List<IFormFile> ArquivoUpload { get; set; }

        public string Arquivo { get; set; }
    }
}
