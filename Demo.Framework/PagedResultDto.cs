using System.Collections.Generic;

namespace Demo.Framework.EF
{
    public class PagedResultDto<T> : ListResultDto<T>, IPagedResult<T>, IListResult<T>, IHasTotalCount
    {
        public PagedResultDto()
        {
        }

        public PagedResultDto(int totalCount, IReadOnlyList<T> items)
        {
        }

        public int TotalCount { get; set; }
    }
}