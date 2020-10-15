using Demo.Framework.EF.UOW;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Demo.Framework.EF.BaseContext
{
    public class ContextBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContextBase(DbContext databaseContext)
        {
            _unitOfWork = new UnitOfWork(databaseContext);
        }

        public int Save()
        {
            return _unitOfWork.Save();
        }

        public Task<int> SaveASync()
        {
            return _unitOfWork.SaveAsync();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public int Count<T, TKey>() where T : class
        {
            return _unitOfWork.GetRepository<T>().Count();
        }

        public int Count<T, TKey>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _unitOfWork.GetRepository<T>().Count(predicate);
        }

        public IQueryable<T> GetAll<T, TKey>() where T : class
        {
            return _unitOfWork.GetRepository<T>().GetAll(null, null, null, null, null);
        }

        public IQueryable<T> GetAll<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _unitOfWork.GetRepository<T>().GetAll(predicate, null, null, null, null);
        }

        public IQueryable<T> GetAll<T>(Expression<Func<T, bool>> predicate = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
         Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
         int? skip = null, int? take = null) where T : class
        {
            return _unitOfWork.GetRepository<T>().GetAll(predicate, include, orderBy, skip, take);
        }

        public IQueryable<T> GetAll<T>(Expression<Func<T, bool>> predicate = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        string orderBy = null, string orderDirection = "asc",
         int? skip = null, int? take = null) where T : class
        {
            return _unitOfWork.GetRepository<T>().GetAll(predicate, include, orderBy, orderDirection, skip, take);
        }

        public Task<IQueryable<T>> GetAllAsync<T>(Expression<Func<T, bool>> predicate = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
         Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
         int? skip = null, int? take = null) where T : class
        {
            return _unitOfWork.GetRepository<T>().GetAllAsync(predicate, include, orderBy, skip, take);
        }

        public Task<IQueryable<T>> GetAllAsync<T>(Expression<Func<T, bool>> predicate = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        string orderBy = null, string orderDirection = "asc",
         int? skip = null, int? take = null) where T : class
        {
            return _unitOfWork.GetRepository<T>().GetAllAsync(predicate, include, orderBy, orderDirection, skip, take);
        }

        public Task<IQueryable<T>> GetAllAsync<T>() where T : class
        {
            return _unitOfWork.GetRepository<T>().GetAllAsync(null, null, null, null, null);
        }

        public Task<IQueryable<T>> GetAllAsync<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _unitOfWork.GetRepository<T>().GetAllAsync(predicate, null, null, null, null);
        }

        public IQueryable<T> GetAll<T>(Func<IQueryable<T>, IIncludableQueryable<T, object>> include) where T : class
        {
            return _unitOfWork.GetRepository<T>().GetAll(null, include, null, null, null);
        }

        public Task<IQueryable<T>> GetAllAsync<T>(Func<IQueryable<T>, IIncludableQueryable<T, object>> include) where T : class
        {
            return _unitOfWork.GetRepository<T>().GetAllAsync(null, include, null, null, null);
        }

        public T GetSingle<T>(
         Expression<Func<T, bool>> predicate = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null) where T : class
        {
            return _unitOfWork.GetRepository<T>().GetSingle(predicate, include);
        }

        public Task<T> GetSingleAsync<T>(
          Expression<Func<T, bool>> predicate = null,
          Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null) where T : class
        {
            return _unitOfWork.GetRepository<T>().GetSingleAsync(predicate, include);
        }

        public virtual void Add<T>(T entity) where T : class
        {
            _unitOfWork.GetRepository<T>().Add(entity);
        }

        public virtual void AddAsync<T>(T entity) where T : class
        {
            _unitOfWork.GetRepository<T>().AddAsync(entity);
        }

        public T Update<T>(T entity) where T : class
        {
            return _unitOfWork.GetRepository<T>().Update(entity);
        }

        public void Delete<T>(T toDelete) where T : class
        {
            _unitOfWork.GetRepository<T>().Delete(toDelete);
        }

        public void Delete<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            _unitOfWork.GetRepository<T>().Delete(predicate);
        }
    }
}