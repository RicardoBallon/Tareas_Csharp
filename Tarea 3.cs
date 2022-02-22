using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            double n3 = double.Parse(txtN3.Text);
            double promedio = (n1 + n2 + n3) / 3;
            lblPromedio.Text = promedio.ToString();
            //TAREA: MOSTRAR EN ROJO O AZUL SEGUN CORRESPONDA
            //de 0 a 12 ROJO
            //de 13 a 20 AZUL
            //CON un IF
            if (promedio>=13)
            {
                lblPromedio.ForeColor = Color.Blue;
            }
            else
            {
                lblPromedio.ForeColor = Color.Red;
            }
            txtN1.Text = String.Empty;
            txtN2.Text = "";
            txtN3.Text = String.Empty;
        }
    }
}