using System.Diagnostics;

namespace TemperatureSpace
{
    class Weather
    {
        internal static string Report(IWeatherSensor sensor)
        {
            int precipitation = sensor.Precipitation();
            // precipitation < 20 is a sunny day
            string report = string.Empty;

            if (sensor.TemperatureInC() > 25)
            {
                if (precipitation >= 20 && precipitation < 60)
                    report = "Partly Cloudy";
                else if (sensor.WindSpeedKMPH() > 50)
                    report = "Alert, Stormy with heavy rain";
                else if (precipitation >= 60)
                    report = "Rainy day";
                else if (sensor.Humidity() > 60)
                    report = "Very humid";
                else
                    report = "Sunny Day";
            }
            else {
                report = "Cold day";
            }
            return report;
        }

        private static void TestWeather(IWeatherSensor sensor, string weatherResult)
        {
            string report = Weather.Report(sensor);
            Console.WriteLine(report);
            Debug.Assert(report.Contains(weatherResult, StringComparison.OrdinalIgnoreCase));
        }

        static void Main(string[] args)
        {
            // Note 1: Focus of this task is to create stubs
            // It is not necessary to fix the bug in the Weather.Report() function
            // though the implementation leaves much to be desired.

            // Note 2: Understand how the sensor stub is designed
            // Stub only gives a single value now, which is pretty much useless
            // think of ways to test high precipitation condition 
            TestWeather(new SensorStub(), "rain");
            TestWeather(new SensorStub2(), "rain");
            TestWeather(new SensorStub3(), "sunny");
            TestWeather(new SensorStub4(), "cloudy");
            TestWeather(new SensorStub5(), "cold");
            TestWeather(new SensorStub6(), "humid");
            Console.WriteLine("All is well (maybe!)");
        }
    }
}

