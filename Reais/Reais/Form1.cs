using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double  cotacaoDolar, quantidadeDolar, valorReal;

            Console.Write("Digite a cotação do dólar: ");
            cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de dólares: ");
            quantidadeDolar = Convert.ToDouble(Console.ReadLine());

            valorReal = cotacaoDolar * quantidadeDolar;

            Console.WriteLine("Valor em reais: R$ + valorEmReais ");

            Console.ReadKey();
        }
    }
}
