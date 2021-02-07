using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Dada la longitud de un cable en metros, diseñe un algoritmo que exprese dicha
            //longitud en pies y en yardas.Considere los siguientes factores de conversión:
            //1 metro = 100 centímetros
            //1 pulgada = 2.54 centímetros
            //1 pie = 12 pulgadas
            //1 yarda = 3 pies
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double metros, yardas, pies;
            //lectura de datos
            metros = double.Parse(txtMetros.Text);
            //proceso de datos
            pies = (((metros * 100) / 2.54) / 12);
            yardas = pies / 3;
            //salida de datos
            txtPies.Text = pies.ToString();
            txtYardas.Text = yardas.ToString();
        }
    }
}
