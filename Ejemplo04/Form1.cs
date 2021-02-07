using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double baseDelRectangulo, alturaDelRectangulo, area, perimetro;
            //lectura de datos
            baseDelRectangulo = double.Parse(txtBase.Text);
            alturaDelRectangulo = double.Parse(txtAltura.Text);
            //proceso de datos
            area = baseDelRectangulo * alturaDelRectangulo;
            perimetro =2 * ( baseDelRectangulo + alturaDelRectangulo );
            //salida de datos
            txtArea.Text = area.ToString();
            txtPerimetro.Text = perimetro.ToString();
        }
    }
}
