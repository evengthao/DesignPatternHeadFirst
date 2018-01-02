﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class ForcastDisplay : IObserver, IDisplayElement
    {
        private WeatherData _weatherData;
        private float _currentPressure = 30.02f;
        private float _lastPressure;

        public ForcastDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData; 
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.Write("Forecast: ");

            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Better weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }
}
