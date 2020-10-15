namespace Demo.Framework.EF
{
    public class PagedAndSortedResultRequestDto : PagedResultRequestDto, IPagedAndSortedResultRequest, IPagedResultRequest, ILimitedResultRequest, ISortedResultRequest
    {
        public PagedAndSortedResultRequestDto()
        {
        }

        public virtual string Sorting { get; set; }
    }
}