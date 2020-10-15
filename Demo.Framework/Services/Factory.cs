using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Demo.Framework.EF.Services
{
    internal class Factory
    {
        private readonly IDictionary<Type, Func<DbContext, object>> _factoryCache;

        public Factory()
        {
            _factoryCache = new Dictionary<Type, Func<DbContext, object>>();
        }

        public Func<DbContext, object> GetRepositoryFactoryForEntityType<T>()
            where T : class
        {
            Func<DbContext, object> factory = GetRepositoryFactoryFromCache<T>();
            if (factory != null)
            {
                return factory;
            }

            return DefaultEntityRepositoryFactory<T>();
        }

        public Func<DbContext, object> GetRepositoryFactoryFromCache<T>()
        {
            Func<DbContext, object> factory;
            _factoryCache.TryGetValue(typeof(T), out factory);
            return factory;
        }

        private Func<DbContext, object> DefaultEntityRepositoryFactory<T>() where T : class
        {
            return dbContext => new RepositoryBase<T>(dbContext);
        }
    }
}