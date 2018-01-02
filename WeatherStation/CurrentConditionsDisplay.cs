using System;

namespace WeatherStation
{
    internal class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private ISubject _weatherData;
        private float _temperature;
        private float _humidity;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature +  "F degrees and " + _humidity + "% humidity");
        }
    }
}