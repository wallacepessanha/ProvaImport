using ExameImport.Business.Interfaces;
using ExameImport.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExameImport.Business.Services
{
    public class StatementService : IStatementService
    {
        private readonly IStatementRepository _statementRepository;

        public StatementService(IStatementRepository statementRepository)                              
        {
            _statementRepository = statementRepository;
        }

        public async Task Create(List<Statement> statements)
        {
            await _statementRepository.Remove();

            foreach (var statement in statements)
            {
                var result = _statementRepository.GetStatementBankFilter(statement.Data, statement.Description, statement.Amount, statement.Action);
                if (result.Result == null)
                    await _statementRepository.Create(statement);
            }           
        }
        public async Task<IEnumerable<Statement>> GetAllStatementsBank()
        {            
            return await _statementRepository.GetAll();
        }
        public void Dispose()
        {
            _statementRepository?.Dispose();
        }
    }
}
