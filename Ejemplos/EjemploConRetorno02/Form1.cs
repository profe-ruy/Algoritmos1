using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploConRetorno02
{
    public partial class Form1 : Form
    {
        //declaracion de variables
        int tipoPlaton, cantidad, cantidadDeRegalo;
        double precioTotal, precioPlanton;
        string mensaje;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
            txtCantidad.Text = "";
            txtResultado.Text = "";
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //lectura de datos
            tipoPlaton = leerTipoPlanton();
            cantidad = leerCantidad();
            //proceso de datos
            precioPlanton = obtenerPrecioPlanton(tipoPlaton);
            precioTotal = obtenerPrecioTotal(cantidad, precioPlanton);
            cantidadDeRegalo = obtenerCantidadDeRegalo(cantidad);
            //salida de datos
            mensaje = obtenerMensaje(precioPlanton, precioTotal, cantidadDeRegalo);
            txtResultado.Text = mensaje;
        }

        private string obtenerMensaje(double precioPlanton, double precioTotal, int cantidadDeRegalo)
        {
            return "El precio Por Planton es : " + precioPlanton + Environment.NewLine +
                    "El precio Total es  : " + precioTotal + Environment.NewLine +
                    "la cantidad de regalo es  :" + cantidadDeRegalo;
        }

        private int obtenerCantidadDeRegalo(int cantidad)
        {
            int cantidadDeDocenas = cantidad / 12;
            if (cantidadDeDocenas > 10) return cantidadDeDocenas * 3;
            return  cantidadDeDocenas;
        }

        private double obtenerPrecioTotal(int cantidad, double precioPlanton)
        {
            return cantidad * precioPlanton;
        }

        private double obtenerPrecioPlanton(int tipoPlaton)
        {
            switch (tipoPlaton)
            {
                case 0: return 0.35;
                case 1: return 0.50;
                case 2: return 2.00;
                case 3: return 3.00;
                default:return 5.00;
            }
        }

        private int leerCantidad()
        {
            return int.Parse(txtCantidad.Text);
        }

        private int leerTipoPlanton()
        {
            return tipoPlaton = cboTipo.SelectedIndex;
        }
    }
}
