using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevado_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, resultado;

            Console.WriteLine("Digite o valor de x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de y:");
            y = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(x, y);

            Console.WriteLine("Resultado de x elevado a y " + resultado);

            Console.ReadKey();
        }
    }
}
