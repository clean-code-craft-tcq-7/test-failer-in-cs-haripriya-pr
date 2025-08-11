namespace TemperatureSpace
{
    internal class SensorStub6 : IWeatherSensor
    {
        int IWeatherSensor.Humidity()
        {
            return 70;
        }

        int IWeatherSensor.Precipitation()
        {
            return 18;
        }

        double IWeatherSensor.TemperatureInC()
        {
            return 29;
        }

        int IWeatherSensor.WindSpeedKMPH()
        {
            return 47;
        }
    }
}
