namespace TemperatureSpace
{
    internal class SensorStub3 : IWeatherSensor
    {
        int IWeatherSensor.Humidity()
        {
            return 50;
        }

        int IWeatherSensor.Precipitation()
        {
            return 19;
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
