using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int valor1 = 0;
        int valor2 = 0;

        //criando a instância da classe a qual contém os métodos
        //que serão atribuidos aos objetos delegates
        static Calculadora calc = new Calculadora();

        //criando objetos delegates e atribuindo os métodos apropriados
        //que possuem a assinatura EXATA do delegate
        Calcular Somar = new Calcular(calc.Somar);
        Calcular Subtrair = new Calcular(calc.Subtrair);
        Calcular Multiplicar = new Calcular(calc.Multiplicar);
        Calcular Dividir = new Calcular(calc.Dividir);
        // adicionamos a forma de chamada em 1 Delegate para chamar duas funções ao mesmo tempo
        Calcular MultiCast = new Calcular(calc.Somar) + new Calcular(calc.Multiplicar);
        private void btnSomar_Click(object sender, EventArgs e)
        {
            valor1 = !string.IsNullOrEmpty(txtV1.Text)? Convert.ToInt32(txtV1.Text):0;
            valor2 = !string.IsNullOrEmpty(txtV2.Text) ? Convert.ToInt32(txtV2.Text) : 0;
            txtResultado.Text = Somar(valor1, valor2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            valor1 = !string.IsNullOrEmpty(txtV1.Text) ? Convert.ToInt32(txtV1.Text) : 0;
            valor2 = !string.IsNullOrEmpty(txtV2.Text) ? Convert.ToInt32(txtV2.Text) : 0;
            txtResultado.Text = Subtrair(valor1, valor2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            valor1 = !string.IsNullOrEmpty(txtV1.Text) ? Convert.ToInt32(txtV1.Text) : 0;
            valor2 = !string.IsNullOrEmpty(txtV2.Text) ? Convert.ToInt32(txtV2.Text) : 0;
            txtResultado.Text = Multiplicar(valor1, valor2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            valor1 = !string.IsNullOrEmpty(txtV1.Text) ? Convert.ToInt32(txtV1.Text) : 0;
            valor2 = !string.IsNullOrEmpty(txtV2.Text) ? Convert.ToInt32(txtV2.Text) : 0;
            txtResultado.Text = Dividir(valor1, valor2).ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtV1.Text = "";
            txtV2.Text = "";
            txtResultado.Text = "";
        }
        // exemplo Multicast
        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = !string.IsNullOrEmpty(txtV1.Text) ? Convert.ToInt32(txtV1.Text) : 0;
            valor2 = !string.IsNullOrEmpty(txtV2.Text) ? Convert.ToInt32(txtV2.Text) : 0;
            txtResultado.Text = MultiCast(valor1, valor2).ToString();

        }
    }
}
