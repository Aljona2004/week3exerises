using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitu kraadi on õues?");
            int temp = Convert.ToInt32(Console.ReadLine());

            if(temp >= 35)
            {
                Console.WriteLine("Boiling hot.");
            }
            else if (temp >= 30 && temp < 35)
            {
                Console.WriteLine("Hot.");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("Nice.");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("Chilly.");
            }
            else if (temp >= 0 && temp < 10)
            {
                Console.WriteLine("Cold.");
            }
            else  
            {
                Console.WriteLine("Freezing cold");
            }
        }
    }
}
