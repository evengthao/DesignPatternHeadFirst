using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this._temperature = temp;
            this._pressure = pressure;
            this._humidity = humidity;
            MeasurementsChanged();
        }
    }
}
