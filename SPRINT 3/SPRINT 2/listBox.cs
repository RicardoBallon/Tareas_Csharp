using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesdeAlmacenamiento
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(int)Keys.Enter)
            {
                if (txtAlumno.Text.Length != 0) //Validar si la caja texto no esta vacia
                {
                    //e.KeyChar==13
                    listAlumnos.Items.Add(txtAlumno.Text);
                    txtAlumno.Clear();
                }
                else
                {
                    MessageBox.Show("Ingresar nombre");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listAlumnos.Items.Clear();
            txtAlumno.Focus();//evento foco
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listAlumnos.Items.RemoveAt(3);
            listAlumnos.Items.RemoveAt(listAlumnos.SelectedIndex);
        }
    }
}
