using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Dado un tiempo en segundos, diseñe un algoritmo que exprese dicho tiempo en el
            //formato HH: MM: SS.Por ejemplo, si el tiempo es 14600 segundos, el algoritmo
            //deberá mostrar 4:3:20.
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declaracion de varibales
            int tiempo , horas , minutos , segundos ;
            string mensaje;
            //lectura de datos
            tiempo = int.Parse(txtTiempo.Text);
            //proceso de datos
            horas = tiempo / 3600;
            minutos = (tiempo % 3600) / 60;
            segundos = (tiempo % 3600) % 60;
            //salida de datos
            //mensaje = horas + ":" + minutos + ":" + segundos;
            mensaje = string.Format("{0}:{1}:{2}", horas, minutos, segundos);
            txtResultado.Text = mensaje;
        }
    }
}
