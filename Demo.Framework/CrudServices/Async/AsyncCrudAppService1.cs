using Demo.Framework.EF.Entity;

namespace Demo.Framework.EF.CrudServices.Async
{
    public abstract class AsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput> : AsyncCrudAppServiceFull<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, EntityDto<TPrimaryKey>>
      where TEntity : class, IEntity<TPrimaryKey>
      where TEntityDto : IEntityDto<TPrimaryKey>
      where TUpdateInput : IEntityDto<TPrimaryKey>
      where TGetInput : IEntityDto<TPrimaryKey>
    {
        protected AsyncCrudAppService(IRepositoryBase<TEntity> repository) : base(repository)
        {
        }
    }
}