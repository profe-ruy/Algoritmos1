using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploVoid01
{
    public partial class Form1 : Form
    {
        //declaracion de variables
        int categoria;
        double promedio, pensionActual, descuento, pensionFinal;
        string mensaje;

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //lectura de datos
            lecturaDeDatos();
            //proceso de datos
            procesarDatos();
            //salida de datos
            salidaDeDatos(pensionActual, descuento, pensionFinal);
        }

        private void salidaDeDatos(double pensionActual, double descuento, double pensionFinal) {
            mensaje = "Pension Actual :" + pensionActual;
            mensaje += Environment.NewLine;
            mensaje += "Descuento : " + descuento;
            mensaje += Environment.NewLine;
            mensaje += "Pension Final :" + pensionFinal;
            txtResultado.Text = mensaje;
        }

        private void procesarDatos() {
            switch (categoria)
            {
                case 0: pensionActual = 550; break;
                case 1: pensionActual = 500; break;
                case 2: pensionActual = 460; break;
                case 3: pensionActual = 400; break;
            }
            //calcular el descuento
            calcularDescuento();
            calcularPensionFinal();
        }

        private void calcularPensionFinal() {
            pensionFinal = pensionActual - descuento;
        }

        private void calcularDescuento() {
            if (promedio > 0 && promedio < 14)
            {
                descuento = 0;
            }
            else if (promedio < 16)
            {
                descuento = 0.10 * pensionActual;
            }
            else if (promedio < 18)
            {
                descuento = 0.12 * pensionActual;
            }
            else descuento = 0.15 * pensionActual;
        }

        private void lecturaDeDatos() {
            categoria = cboCategoria.SelectedIndex;
            promedio = double.Parse(txtPromedio.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPromedio.Text = "";
            txtResultado.Text = "";
            cboCategoria.SelectedIndex = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //En una universidad, los alumnos están categorizados en cuatro categorías.A cada
            //categoría le corresponde una pensión mensual distinta dada en la siguiente tabla:
            //Categoría Pensión
            //A S/. 550
            //B S/. 500
            //C S/. 460
            //D S/. 400
            //Semestralmente, la universidad efectúa rebajas en las pensiones de sus estudiantes a
            //partir del segundo ciclo en base al promedio ponderado del ciclo anterior en
            //porcentajes dados en la tabla siguiente:
            //Promedio Descuento
            //0 a13.99 No hay descuento
            //14.00 a 15.99 10 %
            //16.00 a 17.99 12 %
            //18.00 a 20.00 15 %
            //Diseñe un programa que determine cuánto de rebaja recibirá un estudiante sobre su
            //pensión actual y a cuánto asciende su nueva pensión.
            //Declare todas las variables como globales y use métodos tipo void.
        }
    }
}
