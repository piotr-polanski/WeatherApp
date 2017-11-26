using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Web.Models
{
    public class WeatherQuestion
    {
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
    }
}