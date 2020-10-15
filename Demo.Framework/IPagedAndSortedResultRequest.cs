namespace Demo.Framework.EF
{
    //
    // Summary:
    //     This interface is defined to standardize to request a paged and sorted result.
    public interface IPagedAndSortedResultRequest : IPagedResultRequest, ILimitedResultRequest, ISortedResultRequest
    {
    }
}