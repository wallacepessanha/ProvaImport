using AutoMapper;
using ExameImport.Business.Models;
using ExameImport.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExameImport.Web.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Statement, StatementViewModel>().ReverseMap();            
        }
    }
}
