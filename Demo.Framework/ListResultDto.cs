using System.Collections.Generic;

namespace Demo.Framework.EF
{
    public class ListResultDto<T> : IListResult<T>
    {
        public ListResultDto()
        {
        }

        public ListResultDto(IReadOnlyList<T> items)
        {
        }

        public IReadOnlyList<T> Items { get; set; }
    }
}