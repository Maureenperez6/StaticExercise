using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var result = (fahrenheit - 32) / 1.8;
            return result;
        }
        public static double CelciusToFahrenheit(double celcius)
        {
            return(celcius * 9) / 5 + 32;
        }
            
    }
}
