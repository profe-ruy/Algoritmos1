using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploElse02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//Un padre ha decidido dar una propina a su hijo en base a sus notas en los cursos de Matemáticas, Física e Historia del Perú.
//• Si la nota de Matemática es mayor a 17, le dará S /. 3 de propina por cada punto; en caso contrario, sólo le dará S/. 1.0 por cada punto.
//• Si la nota de Física es mayor a 15, le dará S /. 2.0 de propina por cada punto; en caso contrario, sólo le dará S/ .0.5 por cada punto.
//• Si la nota de Historia del Perú es mayor a 15, le dará S /. 1.5 por cada punto; en caso contrario, sólo le dará S/. 0.30 por cada punto.
//• Además, si la nota de Matemática es mayor a 17, le obsequiará un reloj; en caso, contrario, le obsequiará un lapicero.
//Diseñe un algoritmo que determine el monto total de la propina y el obsequio que le corresponde al hijo. 
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double notaMate, notaFisica, notaHistoria;
            double dineroMate, dineroFisica, dineroHistoria;
            string mensaje , regalo;
            //lectura de datos
            notaMate = double.Parse(txtMatematica.Text);
            notaFisica = double.Parse(txtFisica.Text);
            notaHistoria = double.Parse(txtHistoria.Text);
            //validaciones
            if (notaMate < 0 || notaMate > 20)
            {
                MessageBox.Show("Nota ingresada no es correcta");
                return;
            }
            //else { 
                //procesar de datos
                if (notaMate > 17)
                {
                    dineroMate = 3.0 * notaMate;
                    regalo = "Regalo : un reloj";
                }
                else
                {
                    dineroMate = 1.0 * notaMate;
                    regalo = "Regalo : un lapicero";
                }
                if (notaFisica > 15)
                    dineroFisica = 2.0 * notaFisica;
                else
                    dineroFisica = 0.5 * notaFisica;
                if (notaHistoria > 15)
                    dineroHistoria = 1.5 * notaHistoria;
                else
                    dineroHistoria = 0.3 * notaHistoria;

                //salida de datos
                mensaje = "Total a pagar por Mate :" + dineroMate + Environment.NewLine;
                mensaje += "Total a pagar por Fisica" + dineroFisica + Environment.NewLine;
                mensaje += "Total a pagar por Historia" + dineroHistoria + Environment.NewLine;
                mensaje += regalo;
                txtResultado.Text = mensaje;
            //}

        }
    }
}
