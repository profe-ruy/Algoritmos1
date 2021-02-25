using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = leerNumero(txtNumero.Text);
                int divisor = leerNumero(txtDivisor.Text);
                if (numero == -1 || divisor == -1) {
                    MessageBox.Show("Ingresar datos correctos");
                    return;
                }
                //proceso de datos
                bool esDivisible = numero % divisor == 0;
                //salida
                //if (esDivisible)
                //    txtResultado.Text = numero + " es divisible entreo " + divisor;
                //else
                //    txtResultado.Text = numero + " NO es divisible entreo " + divisor;

                string mensaje = numero + (esDivisible ? "" : "NO" ) + " es divisible entreo " + divisor;
                txtResultado.Text = mensaje;
            }
            catch (Exception ex)
            {
                txtResultado.Text = ex.Message;
            }
        }


        private int leerNumero(string text)
        {
            try
            {
                return int.Parse(text);
            }
            //captura de error en nuestro codigo
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
