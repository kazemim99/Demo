using System.Threading.Tasks;

namespace Demo.Framework.EF.CrudServices.Async.Interfaces
{
    public interface IAsyncCrudAppService<TEntityDto, TPrimaryKey, in TGetAllInput, in TCreateInput, in TUpdateInput, in TGetInput, in TDeleteInput>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TUpdateInput : IEntityDto<TPrimaryKey>
        where TGetInput : IEntityDto<TPrimaryKey>
        where TDeleteInput : IEntityDto<TPrimaryKey>
    {
        Task<TEntityDto> CreateAsync(TCreateInput input);

        Task DeleteAsync(TDeleteInput input);

        Task<PagedResultDto<TEntityDto>> GetAllAsync(TGetAllInput input);

        Task<TEntityDto> GetAsync(TGetInput input);

        Task<TEntityDto> UpdateAsync(TUpdateInput input);
    }
}