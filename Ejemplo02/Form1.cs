using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int cantidadNiños, cantidadRegalos, cantidadTotal;
            //lectura de datos
            cantidadNiños = int.Parse(txtCantidadNiños.Text);
            cantidadRegalos = int.Parse(txtRegalosPorNiño.Text);
            //procesar
            cantidadTotal = cantidadNiños * cantidadRegalos;
            //Salida de datos
            txtResultado.Text = "La cantidad total es :"+  cantidadTotal;
        }
    }
}
