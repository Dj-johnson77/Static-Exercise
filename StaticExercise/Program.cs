namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Farenheit to celsius.");
            Console.WriteLine(TempConverter.FarenheitToCelsius(30)); 

            Console.WriteLine("Celsius to farenheit.");
            Console.WriteLine(TempConverter.CelsiusToFarenheit(-1.1111111111111112));
        }
    }
}
