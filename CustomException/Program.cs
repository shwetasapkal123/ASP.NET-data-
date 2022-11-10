using System;

namespace CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Temperature temperature = new Temperature();
            try
            {
                temperature.ShowTemperature();
            }
            catch(TemperatureZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
