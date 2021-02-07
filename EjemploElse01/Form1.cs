using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploElse01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //En un supermercado hay una promoción según la cual el cliente raspa una tarjeta
            //que contiene un número oculto.Si el número de la tarjeta es par no menor que
            //100, el cliente obtiene un descuento del 15 % sobre el importe de la compra; en
            //caso contrario, sólo se le descuenta el 5 %.Dado el número oculto de la tarjeta y
            //el importe de una compra, diseñe un algoritmo que determine el importe del
            //descuento y el importe a pagar para un cliente del supermercado.
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double montoCompra, descuento, montoPagar;
            int numeroTarjeta;
            //lectura de datos
            numeroTarjeta = int.Parse(txtTarjeta.Text);
            montoCompra = double.Parse(txtCompra.Text);
            //proceso de datos
            if (numeroTarjeta % 2 == 0 && numeroTarjeta > 100)
            {
                descuento = 15.0 / 100 * montoCompra;
            }
            else {
                descuento = 5.0 / 100 * montoCompra;
            }
            montoPagar = montoCompra - descuento;
            //salida de datos
            txtDescuento.Text = descuento.ToString();
            txtMontoPagar.Text = montoPagar.ToString();
        }
    }
}
