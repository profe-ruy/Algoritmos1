using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Débora, Raquel y Séfora aportan cantidades de dinero para formar un capital. Diseñe
            //un programa que determine el capital formado y el porcentaje de dicho capital que
            //aporta cada uno.

            //declaracion de variables
            double dineroDebora, dineroRaquel, dineroSefora, dineroTotal;
            double porcentajeDebora, porcentajeRaquel, porcentajeSefora;
            string mensaje;
            //lectura de datos
            dineroDebora = double.Parse(txtDebora.Text);
            dineroRaquel = double.Parse( txtRaquel.Text);
            dineroSefora = double.Parse(txtSefora.Text);
            //proceso 
            dineroTotal = dineroDebora + dineroRaquel + dineroSefora;
            mensaje = "El dinero total es :" + dineroTotal + Environment.NewLine;

            porcentajeDebora = dineroDebora / dineroTotal *100;
            mensaje = mensaje  + "El porcentaje de Debora es : " + porcentajeDebora.ToString("#.##") + "%" + Environment.NewLine;

            porcentajeRaquel = dineroRaquel / dineroTotal * 100;
            mensaje = mensaje  + "El porcentaje de Raquel es : " + porcentajeRaquel.ToString("#.##") + "%" + Environment.NewLine;

            porcentajeSefora= dineroSefora/ dineroTotal * 100;
            mensaje = mensaje + "El porcentaje de Sefora es : " + porcentajeSefora.ToString("#.##") + "%";

            //salida de datos
            txtResultado.Text = mensaje;
        }
    }
}
