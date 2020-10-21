using ExameImport.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExameImport.Data.Context
{
    public class ExameImportDbContext : DbContext
    {
        public ExameImportDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Statement> Statements { get; set; }

        
    }
}
