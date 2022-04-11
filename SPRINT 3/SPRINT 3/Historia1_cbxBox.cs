using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Carga de datos 1
            //Pasa los datos a una coleccion y despues los carga
            cbxbox1.Items.Add("Manzana");
            cbxbox1.Items.Add("Pera");
            cbxbox1.Items.Add("Durazno");
            cbxbox1.Items.Add("Naranja");//llavefrancesa atributos o propiedades
            //QUITAR LOS ELEMENTOS

            cbxbox1.Items.Remove("Pera");
            cbxbox1.Items.RemoveAt(2);



        }

        private void cbxbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MOSTRAR EL ITEM SELECCIONADO
            
            if(cbxbox1.SelectedItem!=null)
            {
                MessageBox.Show(cbxbox1.SelectedItem.ToString());
            }
            if (cbxbox1.SelectedIndex != -1)
            {
                MessageBox.Show(cbxbox1.SelectedIndex.ToString());
            }


        }
    }
}
