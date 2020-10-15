using System;
using System.Threading.Tasks;

namespace Demo.Framework.EF.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryBase<T> GetRepository<T>() where T : class;

        int Save();

        Task<int> SaveAsync();
    }
}