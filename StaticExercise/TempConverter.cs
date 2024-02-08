using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        static TempConverter()
        {
        }

        public static void FahrenheitToCelsius(double fahrenheit)
        {
            var result = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {result} degrees Celsius!");

        }

        public static void CelsiusToFahrenheit(double celsius)
        {
            var result = celsius * 9 / 5 + 32;
            Console.WriteLine($"{celsius} degrees Celsius is {result} degrees Fahrenheit!");
        }


    }
}
