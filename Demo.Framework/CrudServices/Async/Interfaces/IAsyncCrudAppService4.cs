namespace Demo.Framework.EF.CrudServices.Async.Interfaces
{
    public interface IAsyncCrudAppService<TEntityDto, TPrimaryKey> : IAsyncCrudAppService<TEntityDto, TPrimaryKey, PagedAndSortedResultRequestDto>, IAsyncCrudAppService<TEntityDto, TPrimaryKey, PagedAndSortedResultRequestDto, TEntityDto, TEntityDto>, IAsyncCrudAppService<TEntityDto, TPrimaryKey, PagedAndSortedResultRequestDto, TEntityDto, TEntityDto, EntityDto<TPrimaryKey>>, IAsyncCrudAppService<TEntityDto, TPrimaryKey, PagedAndSortedResultRequestDto, TEntityDto, TEntityDto, EntityDto<TPrimaryKey>, EntityDto<TPrimaryKey>> where TEntityDto : IEntityDto<TPrimaryKey>
    {
    }
}