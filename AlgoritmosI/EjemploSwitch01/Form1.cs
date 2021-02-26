using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploSwitch01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declaracion de varibles
            string mensaje;
            int trimestre;
            //lectura de datos
            trimestre = int.Parse(cboTrimestre.Text);
            //proceso de datos
            switch (trimestre)
            {
                case 1:
                    mensaje = "El primer trimestre";
                    break;

                case 2:
                    mensaje = "El segundo trimestre";
                    break;
                case 3:
                    mensaje = "El tercer trimestre";
                    break;
                case 4:
                    mensaje = "El cuarto trimestre";
                    break;
                default:
                    mensaje = "No se eligio nada";
                    break;
            }
            //salida de datos
            txtResultado.Text = mensaje;
        }
    }
}
