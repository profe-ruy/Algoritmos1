using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFor02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Imprime un rectángulo de altura n y ancho 2n relleno de asteriscos. Así, para n igual a 5, 
             el programa deberá imprimir un rectángulo de 10 asteriscos de ancho por 5 asteriscos de alto 
             como el que se muestra a continuación:

                **********
                **********
                **********
                **********
                **********
             */
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //leer los datos
            int numero = int.Parse(txtNumero.Text);
            string mensaje = "";
            //procesar los datos
            //Altura
            for (int i = 1; i <= numero; i++)
            {
                //largo
                for (int j = 1; j<=2* numero; j++)
                {
                    mensaje += "*"  ;
                }
                mensaje += Environment.NewLine;
            }
            //salda de datos
            txtResultado.Text = mensaje;
        }
    }
}
