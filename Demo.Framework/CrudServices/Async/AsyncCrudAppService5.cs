using Demo.Framework.EF.Entity;

namespace Demo.Framework.EF.CrudServices.Async
{
    public abstract class AsyncCrudAppService<TEntity, TEntityDto> : AsyncCrudAppService<TEntity, TEntityDto, int>
        where TEntity : class, IEntity<int>
        where TEntityDto : IEntityDto<int>
    {
        protected AsyncCrudAppService(IRepositoryBase<TEntity> repository) : base(repository)
        {
        }
    }
}