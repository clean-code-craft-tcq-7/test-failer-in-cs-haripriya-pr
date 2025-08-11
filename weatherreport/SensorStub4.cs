namespace TemperatureSpace
{
    internal class SensorStub4 : IWeatherSensor
    {
        int IWeatherSensor.Humidity()
        {
            return 50;
        }

        int IWeatherSensor.Precipitation()
        {
            return 55;
        }

        double IWeatherSensor.TemperatureInC()
        {
            return 30;
        }

        int IWeatherSensor.WindSpeedKMPH()
        {
            return 49;
        }
    }
}
