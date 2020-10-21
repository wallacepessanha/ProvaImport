using System;
using System.Collections.Generic;
using System.Text;

namespace ExameImport.Business.Models
{
    public class Statement : Entity
    {
        public decimal Amount { get; set; }
        public DateTime Data { get; set; }
        public string Description { get; set; }
        public string Action { get; set; }
    }
}
