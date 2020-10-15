using Demo.Framework.EF.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Demo.Framework.EF.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        private readonly IRepositoryService _repositoryService;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;

            if (_repositoryService == null)
            {
                _repositoryService = new RepositoryServiceImpl();
            }

            _repositoryService.DbContext = _dbContext;
        }

       public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IRepositoryBase<T> GetRepository<T>() where T : class
        {
            return _repositoryService.GetGenericRepository<T>();
        }
    }
}