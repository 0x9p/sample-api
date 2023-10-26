using Microsoft.Extensions.Logging;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void Get_ReturnsFiveWeatherForecasts()
        {
            // Arrange
            var controller = new WeatherForecastController(new Logger<WeatherForecastController>(new LoggerFactory()));

            // Act
            var result = controller.Get();

            // Assert
            var weatherForecasts = Assert.IsType<List<WeatherForecast>>(result.ToList());
            Assert.Equal(5, weatherForecasts.Count);
        }
    }
}
