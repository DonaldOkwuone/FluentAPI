//using FluentAPI;
using FluentAPI;
using FluentValidation.TestHelper;

namespace WeatherTests
{
    public class WeatherForecastValidatorTests
    {
        private readonly FluentAPI.WeatherForecastValidator _validator = new WeatherForecastValidator();

        [Fact]
        public void GivenAnInvalidTemperatureCValue_ShouldHaveValidationError()
        {
            var validate = _validator.TestValidate(new WeatherForecast() { TemperatureC = 101 });
            validate.ShouldHaveValidationErrorFor(model => model.TemperatureC);
            //_validator.ShouldHaveValidationErrorFor(model => model.TemperatureC, 101);

        }

        [Theory]
        [InlineData(99)]
        [InlineData(100)]
        public void GivenValidTemperature_ShouldNotHaveValidationError(int temperature)
        {
            var validate = _validator.TestValidate(new WeatherForecast() { TemperatureC = temperature });
            validate.ShouldNotHaveValidationErrorFor(model => model.TemperatureC);
        }


    }
}