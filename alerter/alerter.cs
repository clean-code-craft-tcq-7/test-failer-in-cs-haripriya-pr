using System;

namespace AlerterSpace
{
    class Alerter
    {
        static int alertFailureCount = 0;
        static int codeOk = 200;
        static int codeNotOk = 500;
        static int tempThresholdInC = 200;
        static int networkAlertStub(float celcius)
        {
            Console.WriteLine("ALERT: Temperature is {0} celcius, Threshold: {1} celcius",
                celcius, tempThresholdInC);
            // Return code 200 when successful in alerting breach on network
            // Return code 500 for if failed in alerting breach on network
            // stub always succeeds and returns 200
            return codeOk;
        }
        static void alertInCelcius(float farenheit)
        {
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = networkAlertStub(celcius);
            if (returnCode == codeNotOk)
            {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 0;
            }
        }
        static void Main(string[] args)
        {
            alertInCelcius(100.8f);
            alertInCelcius(392f);
            alertInCelcius(393.5f);
            alertInCelcius(450.6f);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}