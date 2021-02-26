using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploVoid02
{
    public partial class Form1 : Form
    {
        //declaracion de vairbles
        int cantidadObservaciones, minutosTardanza;
        int puntosObservaciones, puntosTardanza, puntosTotal;
        double BonificacionTotal;
        string mensaje;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //lectura de datos
            leerDatos();
            //procesar Datos
            procesarDatos();
            //salidaDeDatos
            salidaDeDatos();
        }

        private void salidaDeDatos()
        {
            mensaje = "Puntos por Tardanza :" + puntosTardanza;
            mensaje += Environment.NewLine;
            mensaje += "Puntos Por Obsevacion" + puntosObservaciones;
            mensaje += Environment.NewLine;
            mensaje += "Puntos Total" + puntosTotal;
            mensaje += Environment.NewLine;
            mensaje += "Bonificacion" + BonificacionTotal;
            mensaje += Environment.NewLine;
            txtResultado.Text = mensaje;
        }

        private void procesarDatos()
        {
            calcularPuntosTardanza();
            calcularPuntosObservaciones();
            calcularPuntosTotales();
            calcularBonificacion(puntosTotal);
        }

        private void calcularBonificacion(int puntosTotal)
        {
            if (puntosTotal < 11) BonificacionTotal = 2.5 * puntosTotal;
            else if (puntosTotal < 14) BonificacionTotal = 5.0 * puntosTotal;
            else if (puntosTotal < 17) BonificacionTotal = 7.5 * puntosTotal;
            else if (puntosTotal < 20) BonificacionTotal = 10.0 * puntosTotal;
            else BonificacionTotal = 12.5 * puntosTotal;
        }

        private void calcularPuntosTotales()
        {
            puntosTotal = puntosTardanza + puntosObservaciones;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtMinutos.Text = "";
            txtObservaciones.Text = "";
            txtResultado.Text = "";
        }

        private void calcularPuntosObservaciones()
        {
            switch (cantidadObservaciones)
            {
                case 0: puntosObservaciones = 10; break;
                case 1: puntosObservaciones = 8; break;
                case 2: puntosObservaciones = 5; break;
                case 3: puntosObservaciones = 1; break;
                default: puntosObservaciones = 0; break;
            }
        }

        private void calcularPuntosTardanza()
        {
            if (minutosTardanza > -1 && minutosTardanza < 1)
            {
                puntosTardanza = 10;
            }
            else if (minutosTardanza < 3)
            {
                puntosTardanza = 8;
            }
            else if (minutosTardanza < 6)
            {
                puntosTardanza = 6;
            }
            else if (minutosTardanza < 10)
                puntosTardanza = 4;
            else puntosTardanza = 0;
        }

        private void leerDatos()
        {
            cantidadObservaciones = int.Parse(txtObservaciones.Text);
            minutosTardanza = int.Parse(txtMinutos.Text);
        }
    }
}
