using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using WeatherService.Controllers;
using WeatherService.Models;
using Xunit;

namespace WeatherService.Tests.Controllers
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void ShouldReturnDefultLocationWhenUserIsNotGiven()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(logger.Object);

            var result = controller.Get();

            result.UserLocationForecasts.Should().NotBeEmpty();
        }
    }
}
