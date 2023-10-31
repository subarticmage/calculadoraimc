using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcIMC
{
    public partial class   Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double result = peso / (altura * altura);
            // resultado imc
            txtResultado.Text = result.ToString("n2");

            if (result <= 18.5)
            {
                txtIMC.Text = "abaixo do peso";
            }
            else if (result <=24.9)
            {
                txtIMC.Text = "peso ideal(parabens)";
            }
            else if(result <= 29.9)
            {
                txtIMC.Text = "levemente acima do peso";
            }
            else if (result <=34.9)
            {
                txtIMC.Text = "obesidade grau 1";
            }
            else if (result <=39.9)
            {
                txtIMC.Text = "obesidade grau 2(severa)";
            }
            else
            { 
                txtIMC.Text = "obesidade 3(morbida)"; 
            }

            
                
         


        }
    }
}
