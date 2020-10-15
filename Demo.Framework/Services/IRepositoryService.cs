using Microsoft.EntityFrameworkCore;
using System;

namespace Demo.Framework.EF.Services
{
    public interface IRepositoryService
    {
        DbContext DbContext { get; set; }

        IRepositoryBase<T> GetGenericRepository<T>() where T : class;

        T GetCustomRepository<T>(Func<DbContext, object> factory = null) where T : class;
    }
}