namespace TemperatureSpace
{
    internal class SensorStub4 : IWeatherSensor
    {
        int IWeatherSensor.Humidity()
        {
            return 40;
        }

        int IWeatherSensor.Precipitation()
        {
            return 55;
        }

        double IWeatherSensor.TemperatureInC()
        {
            return 27;
        }

        int IWeatherSensor.WindSpeedKMPH()
        {
            return 46;
        }
    }
}
