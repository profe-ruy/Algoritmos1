using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploContadoresAcumuladores03
{
    public partial class Form1 : Form
    {
        //declaracion de variables
        int contadorAutomovil, contadorCamion, contadorCamioneta, contadorOmnibus, contadorOtros;
        int acumuladorAutomovil, acumuladorCamion, acumuladorCamioneta, acumuladorOmnibus, acumuladorOtros;

        private void btnReset_Click(object sender, EventArgs e)
        {
            contadorAutomovil = 0;
            contadorCamion = 0;
            contadorCamioneta = 0;
            contadorOmnibus = 0;
            contadorOtros= 0;
            acumuladorAutomovil = 0;
            acumuladorCamion = 0;
            acumuladorCamioneta = 0;
            acumuladorOmnibus = 0;
            acumuladorOtros = 0;
            MostrarMensaje();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //En un peaje se desea saber cuantos vehículos de cada tipo pasaron por el peaje y la
            //cantidad total de pasajeros por tipo de vehículo. Los tipos de vehículos a considerar
            //son: automóvil, camión, camioneta, omnibus y otros.
            MostrarMensaje();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //leer datos
            int tipo = cboTipo.SelectedIndex;
            int pasajeros = int.Parse(txtCantidad.Text);
            //proceso de datos
            switch (tipo)
            {
                case 0:
                    contadorAutomovil++;
                    acumuladorAutomovil += pasajeros;
                    break;
                case 1:
                    contadorCamion++;
                    acumuladorCamion += pasajeros;
                    break;
                case 2:
                    contadorCamioneta++;
                    acumuladorCamioneta += pasajeros;
                    break;
                case 3:
                    contadorOmnibus++;
                    acumuladorOmnibus += pasajeros;
                    break;
                default:
                    contadorOtros++;
                    acumuladorOtros += pasajeros;
                    break;
            }
            //salida de datos
            MostrarMensaje();
        }

        private void MostrarMensaje()
        {
            string mensaje =
                            "Informacion por Automoviles" + Environment.NewLine +
                            "---------------------------" + Environment.NewLine +
                            "Cantidad de veces que paso por el peaje : " + contadorAutomovil + Environment.NewLine +
                            "Pasajeros que pasaron en total por el peaje : " + acumuladorAutomovil + Environment.NewLine +


                            "Informacion por Camiones" + Environment.NewLine +
                            "---------------------------" + Environment.NewLine +
                            "Cantidad de veces que paso por el peaje : " + contadorCamion + Environment.NewLine +
                            "Pasajeros que pasaron en total por el peaje : " + acumuladorCamion + Environment.NewLine +

                            "Informacion por Camionetas" + Environment.NewLine +
                            "---------------------------" + Environment.NewLine +
                            "Cantidad de veces que paso por el peaje : " + contadorCamioneta + Environment.NewLine +
                            "Pasajeros que pasaron en total por el peaje : " + acumuladorCamioneta + Environment.NewLine +

                            "Informacion por Omnibus " + Environment.NewLine +
                            "---------------------------" + Environment.NewLine +
                            "Cantidad de veces que paso por el peaje : " + contadorOmnibus + Environment.NewLine +
                            "Pasajeros que pasaron en total por el peaje : " + acumuladorOmnibus + Environment.NewLine +


                            "Informacion por Otros " + Environment.NewLine +
                            "---------------------------" + Environment.NewLine +
                            "Cantidad de veces que paso por el peaje : " + contadorOtros + Environment.NewLine +
                            "Pasajeros que pasaron en total por el peaje : " + acumuladorOtros + Environment.NewLine;

            txtResultado.Text = mensaje;
        }
    }
}
