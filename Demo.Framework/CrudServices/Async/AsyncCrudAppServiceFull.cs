using Demo.Framework.EF.Entity;
using System;
using System.Threading.Tasks;

namespace Demo.Framework.EF.CrudServices.Async
{
    public abstract class AsyncCrudAppServiceFull<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, TDeleteInput> : CrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput>
    where TEntity : class, IEntity<TPrimaryKey>
    where TEntityDto : IEntityDto<TPrimaryKey>
    where TUpdateInput : IEntityDto<TPrimaryKey>
    where TGetInput : IEntityDto<TPrimaryKey>
    where TDeleteInput : IEntityDto<TPrimaryKey>
    {
        protected AsyncCrudAppServiceFull(IRepositoryBase<TEntity> repository) : base(repository)
        {
        }

        public virtual Task DeleteAsync(TDeleteInput input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<PagedResultDto<TEntityDto>> GetAllAsync(TGetAllInput input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntityDto> GetAsync(TGetInput input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntityDto> UpdateAsync(TUpdateInput input)
        {
            throw new NotImplementedException();
        }

        protected virtual Task<TEntity> GetEntityByIdAsync(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }
    }
}