using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            var forcastDisplay = new ForcastDisplay(weatherData);

            weatherData.SetMeasurements(90,66,32.3f);

            Console.ReadKey();
        }
    }
}
