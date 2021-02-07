using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploWhile02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int numerador = 1;
            int denominador = 2;
            int contador = 1;
            double suma = 0;
            string mensaje = "";

            while (contador<=100)
            {
                string numero = numerador + "/" + denominador;
                mensaje += "#" + contador + ":" + numero + Environment.NewLine;
                suma += (numerador*1.0/denominador);
                numerador += 2;
                denominador += 3;
                contador++;
            }
            mensaje += Environment.NewLine + "La suma total es  : " + suma;
            txtProcesar.Text = mensaje;
        }
    }
}
