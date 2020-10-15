using System.Collections.Generic;

namespace Demo.Framework.EF
{
    public interface IListResult<T>
    {
        IReadOnlyList<T> Items { get; set; }
    }
}