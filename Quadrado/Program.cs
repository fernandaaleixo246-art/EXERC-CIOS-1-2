using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aresta, area; 
            Console.WriteLine("Digite o valor da aresta do quadrado"); 
            aresta = double.Parse(Console.ReadLine());

            area = aresta * aresta;

            Console.WriteLine("Area = " + area); 


             
           



        }
    }
}
