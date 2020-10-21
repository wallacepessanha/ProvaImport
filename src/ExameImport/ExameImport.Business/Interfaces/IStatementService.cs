using ExameImport.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExameImport.Business.Interfaces
{
    public interface IStatementService
    {
        Task Create(List<Statement> statements);
        Task<IEnumerable<Statement>> GetAllStatementsBank();
    }
}
