
namespace TemperatureSpace
{
    internal class Factory
    {
        internal static IWeatherSensor GetSensor()
        {
            string? devmode = Environment.GetEnvironmentVariable("devmode");
            if (devmode == null) devmode = string.Empty;

            bool inProd = devmode.CompareTo("PRODUCTION") == 0;

            return inProd ? new Sensor() : new SensorStub();
        }
    }
}
