namespace Demo.Framework.EF.Pagination
{
    public class PagedSortedAndFilteredInputDto : PagedAndSortedInputDto
    {
        public string Filter { get; set; }
    }
}