using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro, raio, area;

            Console.Write("Digite o diâmetro:");
            diametro = double.Parse(Console.ReadLine());

            raio = diametro / 2;
            area = raio * 2;

            Console.Write("Área do circulo:" +  area);  



        }
    }
}
