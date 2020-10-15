namespace Demo.Framework.EF.CrudServices.Async.Interfaces
{
    public interface IAsyncCrudAppService<TEntityDto, TPrimaryKey, in TGetAllInput, in TCreateInput, in TUpdateInput, in TGetInput> : IAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, EntityDto<TPrimaryKey>>
     where TEntityDto : IEntityDto<TPrimaryKey>
     where TUpdateInput : IEntityDto<TPrimaryKey>
     where TGetInput : IEntityDto<TPrimaryKey>
    {
    }
}