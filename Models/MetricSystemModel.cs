using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class MetricSystemModel
    {
        [Required(ErrorMessage = "Please enter a temperature in Fahrenheit.")]
        [Range(-1000, 1000, ErrorMessage =
       "Fahrenheit temperature must be between -1000 and 1000.")]
        public decimal? Fahrenheit { get; set; }

        public decimal? Celsius { get; private set; }

        public decimal? ConvertToCelsius()
        {
            if (Fahrenheit.HasValue)
            {
                Celsius = (Fahrenheit.Value - 32) * 5 / 9;
            }
            return Celsius;
        }
    }
}
