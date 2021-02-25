using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploTryCatch01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (txtEdad1.Text == "")
            {
                MessageBox.Show("Ingresar edad1");
                return;
            }

            if (txtEdad2.Text == "")
            {
                MessageBox.Show("Ingresar edad2");
                return;
            }

            //leer datos
            int edad1 = leerEdad(txtEdad1.Text);
            if (edad1 == -1)
            {
                MessageBox.Show("Ingresar valor apropiado para la edad 1");
                return;
            }
            int edad2 = leerEdad(txtEdad2.Text);
            if (edad2 == -1)
            {
                MessageBox.Show("Ingresar valor apropiado para la edad 2");
                return;
            }
            //procesar datos
            int sumaEdades = edad1 + edad2;
            //salida
            txtResultado.Text = sumaEdades.ToString();
        }

        private int leerEdad(string text)
        {
            try
            {
                return int.Parse(text);
            }
            //captura de error en nuestro codigo
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
