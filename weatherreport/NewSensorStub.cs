namespace TemperatureSpace
{
    internal class NewSensorStub : IWeatherSensor
    {
        int IWeatherSensor.Humidity()
        {
            return 72;
        }

        int IWeatherSensor.Precipitation()
        {
            return 70;
        }

        double IWeatherSensor.TemperatureInC()
        {
            return 26;
        }

        int IWeatherSensor.WindSpeedKMPH()
        {
            return 49;
        }
    }
}
