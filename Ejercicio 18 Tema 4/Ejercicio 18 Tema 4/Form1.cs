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
                //!? Se debe multiplpicar, no sumar
                factorial *= i;
            }
            return factorial;
        }

        int calculaPotencia(int m, int n)
        {
            int potencia = 1;
            //!? si i < n nunca entra en el bucle, se cambia por i <= n
            for (int i = 1; i <= n; i++)
            {
                potencia *= m;
            }
            return potencia;
        }

        double calculaSuma(int m, int n)
        {
            //!? La variable suma hay que inicializarla a 0
            double suma = 0;
            for (int i = 1; i <= n; i++)
            {
                //!? La operación entre ambas funciones debe ser una división
                //!? Se añade += en vez de solo =
                suma += (double)calculaPotencia(m,i) / (double)calculaFactorial(i);
            }
            return suma;
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
                if (nRMB2324 > 0)
                {   
                    //!? Se le pasa el mismo parámetro (mRMB2324)
                    //!? EL segundo parámetro debe ser nRMB2324
                    resultado = calculaSuma(mRMB2324, nRMB2324);

                    MessageBox.Show("El resultado de la serie es " + resultado);
                }
                else
                {
                    MessageBox.Show("El valor de n ha de ser mayor de 0.");
                }
            }
            //!? Depurando me he dado cuenta de que nunca va a entrar en este catch
            //!? Ya que se controla en el else anterior
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }
        }
    }
}
