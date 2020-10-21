using ExameImport.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExameImport.Business.Interfaces
{
    public interface IStatementRepository : IRepository<Statement>
    {
        Task<Statement> GetStatementBankFilter(DateTime Date, string Description, decimal Amount, string Action);
        Task Remove();
    }
}
