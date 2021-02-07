using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploContadoresAcumuladores02
{
    public partial class Form1 : Form
    {
        //declaracion de variables
        int contadorNotas;
        double sumaDeNotas, notaPromedio;
        double notaMinima=20, notaMaxima=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //lectura de datos
            double nota = double.Parse(txtNotas.Text);
            //proceso de datos
            contadorNotas ++;
            sumaDeNotas += nota;
            notaPromedio = sumaDeNotas / contadorNotas;

            if (notaMinima > nota) notaMinima = nota;
            if (notaMaxima < nota) notaMaxima = nota;

            //salidade datos
            string mensaje = "La cantidad de notas es :" + contadorNotas + Environment.NewLine +
                            "La suma de notas es : " + sumaDeNotas + Environment.NewLine +
                            "El promedio de nota es : " + notaPromedio + Environment.NewLine +
                            "Nota minima es: " + notaMinima + Environment.NewLine +
                            "nota maxima es :" + notaMaxima;
            txtResultado.Text = mensaje;
        }
    }
}
