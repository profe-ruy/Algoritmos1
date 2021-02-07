using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploSwitch02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Diseñe un programa que determine la cantidad de días y el nombre de un mes
            //conociendo los valores numéricos del mes
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int mes ;
            string mensaje ,  nombreMes, diasMes;
            //lectura de datos
            if (txtMes.Text == "")
            {
                MessageBox.Show("Ingrese el mes");
            }
            else {
                mes = int.Parse(txtMes.Text);
                if (mes < 1 || mes > 12)
                {
                    MessageBox.Show("Ingrese mes valido");
                    return;
                }
                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        diasMes= "Este mes tiene 31 dias";
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        diasMes = "este mes tiene 30 dias";
                        break;

                    default:
                        diasMes = "Este mes tiene 28 dias";
                        break;
                }

                switch (mes)
                {
                    case 1: nombreMes = "Enero"; break;
                    case 2: nombreMes = "Febrero"; break;
                    case 3: nombreMes = "Marzo"; break;
                    case 4: nombreMes = "Abril"; break;
                    case 5: nombreMes = "Mayo"; break;
                    case 6: nombreMes = "Junio"; break;
                    case 7: nombreMes = "Julio"; break;
                    case 8: nombreMes = "Agosto"; break;
                    case 9: nombreMes = "Setiembre"; break;
                    case 10: nombreMes = "OctubreNoviembre"; break;
                    case 11: nombreMes = "Enero"; break;
                    default: nombreMes = "Diciembre"; break;
                }
                //salida de datos
                mensaje = "El nombre del mes es :" + nombreMes;
                mensaje += Environment.NewLine + diasMes;
                txtResultado.Text = mensaje;
            }
        }
    }
}
