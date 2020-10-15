using System.ComponentModel.DataAnnotations;

namespace Demo.Framework.EF.Pagination
{
    public class PagedInputDto : IPagedResultRequest
    {
        [Range(1, 1000)]
        public int MaxResultCount { get; set; }

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        public PagedInputDto()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}