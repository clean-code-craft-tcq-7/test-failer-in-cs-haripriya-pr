using System;
using System.Diagnostics;

namespace TemperatureSpace
{
    /// <summary>
    /// The class that communicates with firmware / microcontrollers 
    /// The firmware reads the weather data from temperature and other sensor hardware
    /// This class could even use an opensource or an off the shelf third party library
    /// to achieve this.
    /// </summary>
    class Sensor : IWeatherSensor 
    {
        int IWeatherSensor.Humidity()
        {
            throw new NotImplementedException();
        }

        int IWeatherSensor.Precipitation()
        {
            throw new NotImplementedException();
        }

        double IWeatherSensor.TemperatureInC()
        {
            throw new NotImplementedException();
        }

        int IWeatherSensor.WindSpeedKMPH()
        {
            throw new NotImplementedException();
        }
    }
}
