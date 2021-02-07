using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploSwitch03
{
    public partial class Form1 : Form
    {
        //declaracion de variables
        int ejemplo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //En un cine, los precios de las entradas son los mostrados en la siguiente tabla:
            /*
                Día                 ||    General  ||   Niños
                Lunes               ||    S/. 9    ||   S/.7
                Martes              ||    S/. 7    ||   S/.7
                Miércoles a Viernes ||    S/. 10   ||   S/.8
                Sábado y Domingo    ||    S/. 12   ||   S/.9 
             */
            //Adicionalmente si compra más de 10 entradas tiene un descuento del 20%
            //Diseñe un programa que calcule el Subtotal Precio General, el subtotal Precio Niños,
            //el subtotal , descuento , precio total 
            
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int dia, entradasGenerales, entradasNiños;
            double precioGenerales, precioNiños, subtotalGeneral, subtotalNiños, subTotal, descuento, precioTotal;
            string mensaje;
            int calculo ;
            //lectura de datos
            dia = cboDia.SelectedIndex;
            entradasGenerales = int.Parse(txtGenerales.Text);
            entradasNiños = int.Parse(txtNiños.Text);
            //proceso de datos
            switch (dia)
            {
                case 0: // indice 0, o dia lune
                    precioGenerales = 9;
                    precioNiños = 7;
                    break;
                case 1: // indice 1, o dia martes
                    precioGenerales = 7;
                    precioNiños = 7;
                    break;
                case 2: // indice 2, o dia miercoles-viernes
                    precioGenerales = 10;
                    precioNiños = 8;
                    break;
                default:
                    precioGenerales = 12;
                    precioNiños = 9;
                    break;
            }
            subtotalGeneral = precioGenerales * entradasGenerales;
            subtotalNiños = precioNiños * entradasNiños;
            subTotal = subtotalGeneral + subtotalNiños;
            if (entradasGenerales + entradasNiños > 10)
            {
                descuento = subTotal * 20.0 / 100;
            }
            else descuento = 0;
            precioTotal = subTotal - descuento;
            //salida de datos
            mensaje = "precio General para este dia : " + precioGenerales + Environment.NewLine +
                        "precio para niños : " + precioNiños + Environment.NewLine +
                        "Subtotal General " + subtotalGeneral + Environment.NewLine +
                        "Subtotal Niños" + subtotalNiños + Environment.NewLine +
                        "El descuento es : " + descuento + Environment.NewLine +
                        "El total a pagar es : " + precioTotal
                        + "Valor de eejmeplo:" + ejemplo;
                        
                    
            txtResultado.Text = mensaje;
        }

    }
}