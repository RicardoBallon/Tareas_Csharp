using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using FORM_POO8.IMPLEMENTACION;
using FORM_POO8.INTERFACES;
namespace FORM_POO8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Objeto Polimorfo";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnProcesarVenta_Click(object sender, EventArgs e)
        {
            if (rdBtnBoleta.Checked)
            {
                Comprobante boleta = new Boleta();
                lblReporte.Text = boleta.ProcesarVenta
                    (
                    int.Parse(txtCantidad.Text),
                    txtProducto.Text,
                    double.Parse(txtPrecio.Text)
                    );
            }
            if (rdBtnFactura.Checked)
            {
                Comprobante factura = new Factura();
                lblReporte.Text = factura.ProcesarVenta
                   (
                   int.Parse(txtCantidad.Text),
                   txtProducto.Text,
                   double.Parse(txtPrecio.Text)
                   );
            }
           
        }
    }
}
