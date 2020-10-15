using System.ComponentModel.DataAnnotations;

namespace Demo.Framework.EF
{
    public class PagedResultRequestDto : LimitedResultRequestDto, IPagedResultRequest, ILimitedResultRequest
    {
        [Range(0, int.MaxValue)]
        public virtual int SkipCount { get; set; }
    }
}