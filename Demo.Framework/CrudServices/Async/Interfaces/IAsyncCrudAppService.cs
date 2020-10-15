namespace Demo.Framework.EF.CrudServices.Async.Interfaces
{
    public interface IAsyncCrudAppService<TEntityDto, TPrimaryKey, in TGetAllInput> : IAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetAllInput, TEntityDto, TEntityDto>, IAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetAllInput, TEntityDto, TEntityDto, EntityDto<TPrimaryKey>>, IAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetAllInput, TEntityDto, TEntityDto, EntityDto<TPrimaryKey>, EntityDto<TPrimaryKey>> where TEntityDto : IEntityDto<TPrimaryKey>
    {
    }
}