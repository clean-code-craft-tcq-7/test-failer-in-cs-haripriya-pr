namespace TemperatureSpace
{
    internal class SensorStub5 : IWeatherSensor
    {
        int IWeatherSensor.Humidity()
        {
            return 50;
        }

        int IWeatherSensor.Precipitation()
        {
            return 53;
        }

        double IWeatherSensor.TemperatureInC()
        {
            return 24;
        }

        int IWeatherSensor.WindSpeedKMPH()
        {
            return 49;
        }
    }
}
