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
