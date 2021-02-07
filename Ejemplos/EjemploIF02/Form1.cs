using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploIF02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declarar variables
            bool condicionUno, condicionDos;
            string mensaje = "";
            //leer los datos
            condicionUno = bool.Parse(txtCondicionUno.Text);
            condicionDos = bool.Parse(txtCondicion2.Text);
            //proceso de datos
            if (condicionUno && condicionDos)
                mensaje = "Ambas son verdad" + Environment.NewLine;
            if (condicionUno || condicionDos)
                mensaje += "Al menos una era verdad" +Environment.NewLine;
            if (!(condicionUno && condicionDos))
                mensaje += "Ninguno era verdad";

            //salida de datos
            txtResultado.Text = mensaje;
        }
    }
}
