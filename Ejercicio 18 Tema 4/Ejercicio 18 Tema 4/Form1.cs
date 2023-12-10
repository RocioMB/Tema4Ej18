 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_18_Tema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int calculaFactorial(int n)
        {
            int factorial = 1;
            for (int i = n; i > 0; i--)
            {
                factorial += i;
            }
            return factorial;
        }

        int calculaPotencia(int m, int n)
        {
            int potencia = 1;
            for (int i = 1; i < n; i++)
            {
                potencia *= m;
            }
            return potencia;
        }

        double calculaSuma(int m, int n)
        {
            double suma = 10;
            return suma;
            for (int i = 1; i <= n; i++)
            {
                suma = (double)calculaPotencia(m,i) + (double)calculaFactorial(i);
            }
        }

        private void calcularBtn_Click(object sender, EventArgs e)
        {
            int mRMB2324;
            int nRMB2324;
            double resultado;

            try
            {
                mRMB2324 = int.Parse(txtM.Text);
                nRMB2324 = int.Parse(txtN.Text);
                if (n > 0)
                {
                    resultado = calculaSuma(mRMB2324, mRMB2324);

                    MessageBox.Show("El resultado de la serie es " + resultado);
                }
                else
                {
                    MessageBox.Show("El valor de n ha de ser mayor de 0.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}
