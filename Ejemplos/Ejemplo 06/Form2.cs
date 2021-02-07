using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_06
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Dada una cantidad de dinero en soles, diseñe un programa que descomponga
            //dicha cantidad en billetes de S /. 100, S /. 50, S / .10 y monedas de S/. 5, S /. 2 y
            //S / .1.Así, por ejemplo, S/. 3778 puede descomponerse en 37 billetes de S /. 100,
            //mas 1 billete de S /. 50, mas 2 billetes de S /. 10, mas 1 moneda de S /. 5, mas 1
            //moneda de S / .2 y más 1 moneda de S /. 1.

            //declaracion de variables
            int dinero, billetesCien, billetesCincuenta, billetesDiez, monedasCinco, monedasDos, monedasUno;
            string mensaje;
            //lectura de datos
            dinero = int.Parse(txtDinero.Text);
            //proceso de datos
            billetesCien = dinero / 100;
            billetesCincuenta = (dinero % 100) / 50;
            billetesDiez = ((dinero % 100) % 50)/10;
            monedasCinco = (((dinero % 100) % 50) % 10) / 5;
            monedasDos = ((((dinero % 100) % 50) % 10) % 5) / 2;
            monedasUno = (((((dinero % 100) % 50) % 10) % 5) % 2);
            //salida
            mensaje = "El dinero se puede entregar de la siguiente manera :" + Environment.NewLine;
            mensaje += "- Billetes de 100 : " + billetesCien + Environment.NewLine;
            mensaje += "- Billetes de 50 : " + billetesCincuenta + Environment.NewLine;
            mensaje += "- Billetes de 10 : " + billetesDiez + Environment.NewLine;
            mensaje += "- Monedas de 5 : " + monedasCinco + Environment.NewLine;
            mensaje += "- Monedas de 2 : " + monedasDos + Environment.NewLine;
            mensaje += "- Monedas de 1 : " + monedasUno + Environment.NewLine;
            txtResultado.Text = mensaje;
        }
    }
}
