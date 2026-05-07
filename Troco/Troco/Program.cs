
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double produto1, produto2, produto3, produto4, produto5;
            double total, pagamento, troco;
           

            Console.WriteLine("Digite o valor do produto 1: ");
            produto1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 2: ");
            produto2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 3: ");
            produto3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 4: ");
            produto4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 5: ");
            produto5 = Convert.ToDouble(Console.ReadLine());

            total = produto1 + produto2 + produto3 + produto4 + produto5;

            Console.WriteLine("O valor total da compra é: " + total);

            Console.WriteLine("Digite o valor do pagamento: ");
            pagamento =Convert.ToDouble(Console.ReadLine());

            troco= pagamento - total;

            Console.WriteLine("O valor do troco é: " + troco);

            Console.ReadLine();


        }
    }
}
