using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploIfElseIf02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Una empresa de préstamos tiene el siguiente esquema de cobros:
            //Monto del préstamo(S /.)   ||   Número de cuotas
            //Hasta 5000                 ||    2
            //Más de 5000 hasta 10000    ||    4
            //Más de 10000 hasta 15000   ||    6
            //Más de 15000               ||    10
            //Si el monto del préstamo es mayor a S /. 10000, la empresa cobra 3 % de interés mensual; 
            //en caso contrario, cobra 5 % de interés mensual.
            //Dado el monto del préstamo de un cliente, diseñe un programa que determine el
            //monto de la cuota mensual y el monto del interés total entre todas las cuotas
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double montoPrestamo, cuotaMensual, interes;
            int numeroCuotas;
            string mensaje;
            //lectura de datos
            montoPrestamo = double.Parse(txtMonto.Text);
            //proceso de datos
            if (montoPrestamo > 0 && montoPrestamo <= 5000) numeroCuotas = 2;
            else if (montoPrestamo <= 10000) numeroCuotas = 4;
            else if (montoPrestamo <= 15000) numeroCuotas = 6;
            else numeroCuotas = 10;

            if (montoPrestamo > 10000)
                interes = montoPrestamo * 3.0 / 100;
            else
                interes = montoPrestamo * 5.0 / 100;

            cuotaMensual = (montoPrestamo / numeroCuotas) + interes;
            //salida de datos
            mensaje = "El numero de cuotas es : " + numeroCuotas+ Environment.NewLine;
            mensaje += "El interes es : " + interes + Environment.NewLine;
            mensaje += "El valor de la cuota mensual es " + cuotaMensual;

            txtResultado.Text = mensaje;
        }
    }
}
