using Demo.Framework.EF.Entity;
using System;
using System.Linq;

namespace Demo.Framework.EF.CrudServices.Async
{
    public abstract class CrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput>
    where TEntity : class, IEntity<TPrimaryKey>
    where TEntityDto : IEntityDto<TPrimaryKey>
    where TUpdateInput : IEntityDto<TPrimaryKey>
    {
        protected readonly IRepositoryBase<TEntity> Repository;

        protected CrudAppServiceBase(IRepositoryBase<TEntity> repository)
        {
        }

        protected virtual string CreatePermissionName { get; set; }

        protected virtual string GetAllPermissionName { get; set; }

        protected virtual string GetPermissionName { get; set; }

        protected virtual string UpdatePermissionName { get; set; }

        protected virtual string DeletePermissionName { get; set; }

        protected virtual IQueryable<TEntity> ApplyPaging(IQueryable<TEntity> query, TGetAllInput input)
        {
            throw new NotImplementedException();
        }

        protected virtual IQueryable<TEntity> ApplySorting(IQueryable<TEntity> query, TGetAllInput input)
        {
            throw new NotImplementedException();
        }

        protected virtual void CheckCreatePermission()
        {
            throw new NotImplementedException();
        }

        protected virtual void CheckDeletePermission()
        {
            throw new NotImplementedException();
        }

        protected virtual void CheckGetAllPermission()
        {
            throw new NotImplementedException();
        }

        protected virtual void CheckGetPermission()
        {
            throw new NotImplementedException();
        }

        protected virtual void CheckPermission(string permissionName)
        {
            throw new NotImplementedException();
        }

        protected virtual void CheckUpdatePermission()
        {
            throw new NotImplementedException();
        }

        protected virtual IQueryable<TEntity> CreateFilteredQuery(TGetAllInput input)
        {
            throw new NotImplementedException();
        }

        protected virtual void MapToEntity(TUpdateInput updateInput, TEntity entity)
        {
            throw new NotImplementedException();
        }

        protected virtual TEntity MapToEntity(TCreateInput createInput)
        {
            throw new NotImplementedException();
        }

        protected virtual TEntityDto MapToEntityDto(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}