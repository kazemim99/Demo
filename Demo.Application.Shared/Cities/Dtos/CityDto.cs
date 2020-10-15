using Demo.Framework.EF;
using System.ComponentModel.DataAnnotations;

namespace Demo.Application.Shared
{
    public class CityDto : EntityDto<int>
    {
        [Required]
        public string Title { get; set; }
    }
}