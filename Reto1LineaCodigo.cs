using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            this.Text = "Reto Resuelto!!!!";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mostrar serie numero desde 0 hasta el diez en vertical
            //lblSerie.Text = "0\n1\n2";
            
            
            for (int i = 0; i < 10; i++)
            {
               
                lblSerie.Text = lblSerie.Text + "\n"+i;
               
            }
            
            
        }

        private void lblSerie_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
