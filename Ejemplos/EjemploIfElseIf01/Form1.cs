using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploIfElseIf01
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
            string categoria, mensaje;
            double notaPromedio, pensionActual, descuento, pensionNueva;
            txtResultado.Text = "";
            //validaciones
            if (cboCategoria.Text == "")
            {
                MessageBox.Show("No ingreso la categoria");
                return;
            }
            if (txtPromedio.Text == "")
            {
                MessageBox.Show("No ingreso el promedio");
                return;
            }

            //lectura de datos
            notaPromedio = double.Parse(txtPromedio.Text);
            categoria = cboCategoria.Text;

            if (notaPromedio > 20 || notaPromedio < 0) {
                MessageBox.Show("Promedio invalido");
                return;
            }

            //proceso de datos
            if (categoria == "A")
                pensionActual = 550.0;
            else if (categoria == "B")
                pensionActual = 500.0;
            else if (categoria == "C")
                pensionActual = 460.0;
            else pensionActual = 400;

            if (notaPromedio > 0 && notaPromedio <= 13.99)
                descuento = 0;
            else if (notaPromedio >= 14.00 && notaPromedio <= 15.99)
                descuento = 10.0 / 100 * pensionActual;
            else if (notaPromedio >= 16 && notaPromedio <= 17.99)
                descuento = 12.0 / 100 * pensionActual;
            else if (notaPromedio >= 18.0 && notaPromedio <= 20.00)
                descuento = 15.0 / 100 * pensionActual;
            else descuento = 0;

            pensionNueva = pensionActual - descuento;

            // salida de datos
            mensaje = "El valor de la pension actual es S/." + pensionActual + Environment.NewLine;
            mensaje += "El valor del descuento es  S/." + descuento + Environment.NewLine;
            mensaje += "El valor de la nueva pension es S/." + pensionNueva;
            txtResultado.Text = mensaje;
        }
    }
}
