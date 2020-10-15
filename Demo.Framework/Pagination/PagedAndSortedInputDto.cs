namespace Demo.Framework.EF.Pagination
{
    public class PagedAndSortedInputDto : PagedInputDto, ISortedResultRequest
    {
        public string Sorting { get; set; }

        public bool IsDescending { get; set; }

        public PagedAndSortedInputDto()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
            IsDescending = false;
            Sorting = "Id";
        }
    }
}