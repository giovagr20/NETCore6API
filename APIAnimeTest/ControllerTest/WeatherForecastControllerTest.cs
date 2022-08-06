using System;
using APIAnime;
using APIAnime.Controllers;

namespace APIAnimeTest.ControllerTest
{
    public class WeatherForecastControllerTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void MustDeliverWeatherToday()
        {
           
            var weather = new WeatherForecastController();

            IEnumerable<WeatherForecast> weatherForecasts = weather.Get();

            Assert.That(5, Is.EqualTo(weatherForecasts.Count()));

        }
    }
}

