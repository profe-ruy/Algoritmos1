using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploElse03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Una empresa paga a sus vendedores un sueldo bruto igual a la suma de un
            //sueldo básico de S /. 300 más una comisión igual al 15 % del monto total vendido.
            //Por otro lado, si el sueldo bruto del vendedor es mayor que S/. 1800, recibe un
            //descuento del 15 % del sueldo bruto; en caso contrario, recibe un descuento del
            //11 % del sueldo bruto. Además, como incentivo, la empresa obsequia 3 polos si es
            // que el monto vendido es mayor a S /. 500; en caso contrario, sólo obsequia 1 polo.
            //Diseñe un algoritmo que determine el sueldo bruto, el descuento, el sueldo neto y
            //el número de polos de obsequio correspondiente a un vendedor de la empresa.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double montoVenta , comision , sueldoBruto, sueldoNeto, descuento;
            const double SUELDO_BASE = 300;
           
            string mensaje, regalos;
            //leer datos
            montoVenta = double.Parse(txtMontoVenta.Text);
            //validaciones
            if (montoVenta < 0) {
                MessageBox.Show("Monto invalido");
                return;
            }
            //procesar datos
            comision = 15.0 / 100 * montoVenta;
            sueldoBruto = comision + SUELDO_BASE;
            if (sueldoBruto > 1800)
                descuento = 15.0 / 100 * sueldoBruto;
            else
                descuento = 11.0 / 100 * sueldoBruto;
            sueldoNeto = sueldoBruto - descuento;
            if (montoVenta > 500)
                regalos = "3 polos";
            else
                regalos = "1 polo";
            //Salida de datos
            mensaje = "Sueldo Bruto : S/." + sueldoBruto + Environment.NewLine;
            mensaje += "Descuento : S/." + descuento + Environment.NewLine;
            mensaje += "Sueldo Neto : S/." + sueldoNeto + Environment.NewLine;
            mensaje += "El regalo es : " + regalos;
            txtResultado.Text = mensaje;
        }
    }
}
