using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploIF04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Una tienda vende un producto a precios unitarios que dependen de la cantidad de
            //unidades adquiridas de acuerdo a la siguiente tabla:
            //Unidades adquiridas 
            //Precio unitario
            //1 a 25 S /. 27.7
            //26 a 50 S /. 25.5
            //51 a 75 S /. 23.5
            //76 en adelante S /. 21.5
            //Adicionalmente, si el cliente adquiere más de 50 unidades la tienda le descuenta el
            //15 % del importe de la compra; en caso contrario, sólo le descuenta el 5 %.
            //Diseñe un programa que determine el importe de la compra, el importe del descuento
            //y el importe a pagar por la compra de cierta cantidad de unidades del producto.
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int cantidad;
            double precioUnitario = 0, precioSubtotal, descuento=0, precioTotal;
            //lectura de datos
            cantidad = int.Parse(txtCantidad.Text);
            //proceso de datos
            if (cantidad > 0 && cantidad <= 25)
                precioUnitario = 27.7;
            if (cantidad > 25 && cantidad < 51)
                precioUnitario = 25.5;
            if (cantidad > 50 && cantidad < 76)
                precioUnitario = 23.5;
            if (cantidad >= 76)
                precioUnitario = 21.5;
            precioSubtotal = precioUnitario * cantidad;
            if (cantidad > 50)
                descuento = 15.0 / 100 * precioSubtotal;
            if (cantidad <= 50)
                descuento = 5.0 / 100 * precioSubtotal;
            precioTotal = precioSubtotal - descuento;

            //salida de datos
            txtPrecioUnitario.Text = precioUnitario.ToString();
            txtSubTotal.Text = precioSubtotal.ToString();
            txtDescuentos.Text = descuento.ToString();
            txtTotal.Text = precioTotal.ToString();
        }
    }
}
