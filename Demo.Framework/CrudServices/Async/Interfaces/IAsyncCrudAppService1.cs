namespace Demo.Framework.EF.CrudServices.Async.Interfaces
{
    public interface IAsyncCrudAppService<TEntityDto, TPrimaryKey, in TGetAllInput, in TCreateInput, in TUpdateInput> : IAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, EntityDto<TPrimaryKey>>, IAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, EntityDto<TPrimaryKey>, EntityDto<TPrimaryKey>>
       where TEntityDto : IEntityDto<TPrimaryKey>
       where TUpdateInput : IEntityDto<TPrimaryKey>
    {
    }
}