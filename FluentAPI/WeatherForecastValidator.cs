using FluentValidation;

namespace FluentAPI
{
    public class WeatherForecastValidator : AbstractValidator<WeatherForecast>
    {
      
        public WeatherForecastValidator() 
        {
            RuleFor(model => model.TemperatureC).LessThanOrEqualTo(100);
        }
    }
}
