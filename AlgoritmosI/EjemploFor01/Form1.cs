using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFor01
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
             
            
            for que imprime los números: 100, 97, 94, 91, ..., 18, 15, 12, 9 
             */
        }

        private void btnProcesar1_Click(object sender, EventArgs e)
        {
            //for que imprime los números: 0, 1, 2, 3, ..., 48, 49, 50
            string mensaje = "";
            for (int contador = 0; contador <= 50; contador++)
            {
                mensaje += contador + "" + Environment.NewLine;
            }
            txtResultado.Text = mensaje;
        }

        private void btnProcesar2_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            for (int i = 100; i >= 10; i--)
            {
                mensaje += i + "" + Environment.NewLine;
            }

            txtResultado.Text = mensaje;
        }

        private void btnProcesar3_Click(object sender, EventArgs e)
        {
            //for que imprime los números: 10, 12, 14, 16, ..., 98, 99, 100
            string mensaje = "";
            for (int contador = 10; contador <= 100; contador+=2)
            {
                mensaje += contador + "" + Environment.NewLine;
            }
            txtResultado.Text = mensaje;
        }

        private void btnProcesar4_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            for (int i = 100; i >= 0; i-=3)
            {
                mensaje += i + "" + Environment.NewLine;
            }
            txtResultado.Text = mensaje;
        }
    }
}
