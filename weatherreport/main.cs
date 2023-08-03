using System.Diagnostics;

namespace TemperatureSpace
{
    class Weather
    {
        internal static string Report(IWeatherSensor sensor)
        {
            int precipitation = sensor.Precipitation();
            // precipitation < 20 is a sunny day
            string report = "Sunny Day";

            if (sensor.TemperatureInC() > 25)
            {
                if (precipitation >= 20 && precipitation < 60)
                    report = "Partly Cloudy";
                else if (sensor.WindSpeedKMPH() > 50)
                    report = "Alert, Stormy with heavy rain";
            }
            return report;
        }

        private static void testRainy()
        {
            IWeatherSensor sensor = new SensorStub();
            string report = Weather.Report(sensor);
            Console.WriteLine(report);
            Debug.Assert(report.Contains("rain"));
        }

        private static void testHighPrecipitation()
        {
            // add a new stub:
            // This instance of stub needs to give
            // high precipitation (>60) and low wind-speed (<50)
            IWeatherSensor sensor = new SensorStub();

            // design the assert to expose the bug
            // (function returns Sunny day, it should be Rainy)
            string report = Weather.Report(sensor);
            Debug.Assert(report != null);
        }

        static void Main(string[] args)
        {
            // Note 1: Focus of this task is to create stubs
            // It is not necessary to fix the bug in the Weather.Report() function
            // though the implementation leaves much to be desired.

            // Note 2: Understand how the sensor stub is designed
            // Stub only gives a single value now, which is pretty much useless
            // think of ways to test high precipitation condition 
            testRainy();
            testHighPrecipitation();
            Console.WriteLine("All is well (maybe!)");
        }
    }
}

