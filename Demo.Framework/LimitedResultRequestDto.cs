using System.ComponentModel.DataAnnotations;

namespace Demo.Framework.EF
{
    public class LimitedResultRequestDto : ILimitedResultRequest
    {
        [Range(1, int.MaxValue)]
        public virtual int MaxResultCount { get; set; }
    }
}