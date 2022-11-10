using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException
{
    public class Temperature
    {
        int temperature = 0;
        public void ShowTemperature()
        {
            if(temperature==0)
            {
                throw (new TemperatureZeroException("Zero temperature found "));
            }
            else
            {
                Console.WriteLine("Temperature is "+temperature);
            }
        }
    }
    public class TemperatureZeroException:Exception
    {
        public TemperatureZeroException(string message):base(message)
        {

        }
    }
}
