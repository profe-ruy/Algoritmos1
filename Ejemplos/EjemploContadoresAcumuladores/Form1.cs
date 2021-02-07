using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploContadoresAcumuladores
{
    public partial class Form1 : Form
    {
        //declaracion de variabels
        int contador;
        int edades;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //leer la edad
            int edad = int.Parse(txtEdades.Text);
            edades = edades + edad;
            contador = contador + 1;
            //salida del mensaje
            txtResultado.Text = "La cantidad de clicks son :" + contador + Environment.NewLine+ 
                                "la suma de edades es : " + edades;
        }
    }
}
