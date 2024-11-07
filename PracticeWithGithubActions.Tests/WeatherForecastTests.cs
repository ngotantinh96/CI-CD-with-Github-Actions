using Microsoft.Extensions.Logging;
using Moq;
using PracticeWithGithubActions.API;
using PracticeWithGithubActions.API.Controllers;

namespace PracticeWithGithubActions.Tests
{
    public class WeatherForecastTests
    {
        [Fact]
        public void Get_WeatherForecast_WithAListOfWeatherForecasts()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(mockLogger.Object);

            // Act
            var result = controller.Get();

            // Assert
            var weatherForecasts = Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(result);
            Assert.Equal(5, weatherForecasts.Count());
        }
    }
}