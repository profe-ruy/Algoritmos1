using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploConRetorno01
{
    public partial class Form1 : Form
    {
        //declaracion de variables
        int tipoProducto, cantidad;
        double precioTotal;
        string regalo; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //leer datos
            tipoProducto = obtenerTipoProducto();
            cantidad = obtenerCantidad();
            //proceso de datos
            precioTotal = obtenerPrecioTotal(tipoProducto, cantidad);
            regalo = obtenerRegalo(cantidad);
            //salida de datos
            txtPrecioTotal.Text = precioTotal.ToString();
            txtRegalo.Text = regalo;
        }

        private string obtenerRegalo(int cantidad)
        {
            if (cantidad > 0 && cantidad < 26) return "Lapicero";
            else if (cantidad < 51) return "cuaderno";
            else return "agenda";
        }

        private double obtenerPrecioTotal(int tipoProducto, int cantidad)
        {
            double precioUnitario = 0;
            double precioTotal = 0;
            switch (tipoProducto)
            {
                case 0: precioUnitario = 15.0; break;
                case 1: precioUnitario = 17.5 ; break;
                default:precioUnitario = 20.0;break;
            }
            precioTotal = cantidad * precioUnitario;
            return precioTotal;
        }

        private int obtenerCantidad()
        {
            //int cantidad = 0;
            //cantidad = int.Parse(txtCantidad.Text);
            //return cantidad;
            return int.Parse(txtCantidad.Text);
        }

        public int obtenerTipoProducto() {
            //int tipoProducto = 0;
            //tipoProducto = cboTipoProducto.SelectedIndex;
            //return tipoProducto;
            return cboTipoProducto.SelectedIndex; 
        }

    }
}
