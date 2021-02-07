using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploIF01
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
            condicionDos= bool.Parse(txtCondicion2.Text);
            //Procesar datos
            if (condicionUno) {
                mensaje = "Condicion 1 es verdad" + Environment.NewLine;
                mensaje += " Analizaremos tambien la condicion 2"+Environment.NewLine;
            }
            mensaje += "Jugando"+Environment.NewLine;
            if (condicionDos)
                mensaje += "Condicion2 es verdad"+Environment.NewLine;
            mensaje += "Mensaje final";
            //salida de datos
            txtResultado.Text = mensaje;


        }
    }
}
