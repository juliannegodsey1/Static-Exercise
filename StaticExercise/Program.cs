namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperate in degrees Fahrenheit to find out the equivalent in Celsius:");
            TempConverter.FahrenheitToCelsius(int.Parse(Console.ReadLine()));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Enter a temperate in degrees Celsius to find out the equivalent in Fahrenheit:");
            TempConverter.CelsiusToFahrenheit(int.Parse(Console.ReadLine()));
        }
    }
}
