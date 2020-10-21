using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ExameImport.Web.ViewModels
{
    public class StatementViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("Amount")]
        public decimal Amount { get; set; }
        [DisplayName("Date")]
        public DateTime Data { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Operation")]
        public string Action { get; set; }        
    }
}
