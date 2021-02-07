using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploIF03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Los ángulos se clasifican de la siguiente manera:
            //Magnitud Clasificación
            //β = 0º Nulo
            //0º < β < 90º Agudo
            //β = 90º Recto
            //90º < β < 180º Obtuso
            //β = 180º Llano
            //180º < β < 360º Cóncavo
            //β = 360º Completo
            //Diseñe un algoritmo que determine la clasificación de un ángulo dado en grados,
            //minutos y segundos.Asuma que el ángulo está en el intervalo de 0º a 360º.
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double angulo;
            string resultado="";
            //lectura de datos
            angulo = double.Parse(txtAngulo.Text);

            //procesa de datos
            if (angulo < 0 || angulo > 360)
                resultado = "Incorrecto";
            if (angulo == 0)
                resultado = "Nulo";
            if (angulo > 0 && angulo < 90)
                resultado = "Agudo";
            if (angulo == 90)
                resultado = "Recto";
            if (angulo > 90 && angulo < 180)
                resultado = "Obtuso";
            if (angulo == 180)
                resultado = "LLano";
            if (angulo > 180 && angulo < 360)
                resultado = "Concavo";
            if (angulo == 360)
                resultado = "Completo";

            //salida de datos
            txtResultado.Text = resultado;
        }
    }
}
