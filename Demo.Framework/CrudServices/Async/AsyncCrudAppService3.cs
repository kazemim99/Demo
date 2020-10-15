using Demo.Framework.EF.Entity;

namespace Demo.Framework.EF.CrudServices.Async
{
    public abstract class AsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput> : AsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TEntityDto, TEntityDto>
     where TEntity : class, IEntity<TPrimaryKey>
     where TEntityDto : IEntityDto<TPrimaryKey>
    {
        protected AsyncCrudAppService(IRepositoryBase<TEntity> repository) : base(repository)
        {
        }
    }
}