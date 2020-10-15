using System.ComponentModel.DataAnnotations;

namespace Demo.Application.Shared
{
    public class CreateCityInput
    {
        [Required]
        public string Title { get; set; }
    }
}