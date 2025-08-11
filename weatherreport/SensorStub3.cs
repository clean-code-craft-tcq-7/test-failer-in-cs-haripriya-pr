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
            return 17;
        }

        double IWeatherSensor.TemperatureInC()
        {
            return 28;
        }

        int IWeatherSensor.WindSpeedKMPH()
        {
            return 45;
        }
    }
}
