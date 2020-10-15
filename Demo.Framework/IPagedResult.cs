namespace Demo.Framework.EF
{
    public interface IPagedResult<T> : IListResult<T>, IHasTotalCount
    {
    }
}