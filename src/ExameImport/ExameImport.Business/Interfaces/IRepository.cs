using ExameImport.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExameImport.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task Create(TEntity entity);        
        Task<List<TEntity>> GetAll();        
        Task<int> SaveChanges();
    }
}
