using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base:");
            double baseRet = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura");
            double altura = double.Parse(Console.ReadLine());



            double area = baseRet * altura;

            Console.WriteLine("area do retângulo é:" + area);
            Console.ReadKey();


        }
    }
}
