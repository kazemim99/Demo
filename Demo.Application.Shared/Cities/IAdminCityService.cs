using Demo.Framework.EF.CrudServices.Async.Interfaces;

namespace Demo.Application.Shared.Cities
{
    public interface IAdminCityService : IAsyncCrudAppService<CityDto, int, CityPagedSortedAndFilteredInput, CreateCityInput, UpdateCityInput>
    {
    }
}