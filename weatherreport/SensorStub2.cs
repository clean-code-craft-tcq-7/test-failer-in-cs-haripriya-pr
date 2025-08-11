namespace TemperatureSpace
{
    internal class SensorStub2 : IWeatherSensor
    {
        int IWeatherSensor.Humidity()
        {
            return 74;
        }

        int IWeatherSensor.Precipitation()
        {
            return 71;
        }

        double IWeatherSensor.TemperatureInC()
        {
            return 27;
        }

        int IWeatherSensor.WindSpeedKMPH()
        {
            return 49;
        }
    }
}
