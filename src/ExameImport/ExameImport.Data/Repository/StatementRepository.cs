using ExameImport.Business.Interfaces;
using ExameImport.Business.Models;
using ExameImport.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExameImport.Data.Repository
{
    public class StatementRepository : Repository<Statement>, IStatementRepository
    {
        public StatementRepository(ExameImportDbContext context) : base(context) { }

        public async Task<Statement> GetStatementBankFilter(DateTime Date, string Description, decimal Amount, string Action)
        {
            return await Db.Statements.AsNoTracking()
                .FirstOrDefaultAsync(p => p.Action == Action && p.Amount == Amount 
                && p.Data == Date && p.Description == Description);
        }
        public virtual async Task Remove()
        {
            Db.Statements.RemoveRange(GetAll().Result);
            await SaveChanges();
        }
    }
}
