using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.WriteLine("Digite a temperatura em celsius:");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (9.0 / 5.0) * celsius +  32;

            Console.WriteLine("Temperaturaem Fahrenheit:" + fahrenheit);


        
        }
    }
}
