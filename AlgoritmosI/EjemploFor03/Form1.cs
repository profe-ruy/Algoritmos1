using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFor03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Diseñe un algoritmo que determine los divisores de un número natural
            Y muestre la cantidad de los divisores que son PARES

            Ejemplo : 24                        ||      Ejemplo : 50
            - 1                                 ||      - 1
            - 2                                 ||      - 2
            - 3                                 ||      - 5
            - 4                                 ||      - 10
            - 6                                 ||      - 25
            - 8 
            - 12                                ||      - 50
            - 24                                ||
            Cantidad de divisores pares : 6     || Cantidad de divisores pares : 3
             */
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // lectura de datos
            int numero = int.Parse(txtNumero.Text);
            string mensaje = "";
            int contadorPares = 0;
            //proceso de datos
            for (int i = 1; i <= numero; i++)
            {
                var esDivisior = numero % i == 0;
                if (esDivisior)
                {
                    mensaje += "Es divisor : " + i + Environment.NewLine;
                    if (i % 2 == 0)
                    {
                        contadorPares++;
                    }
                }
            }
            if (contadorPares > 0)
                mensaje += "Tiene " + contadorPares + " divisores pares";
            //salida de mensaje
            txtResultado.Text = mensaje;
        }
    }
}
