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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Modulo de Matriculas";
            /*HISTORIA: MODULO DE MATRICULAS
             * TAREA1
             * AL CARGAR EL FORMULARIO (LOAD)
             * LOS PROGRAMAS DEBEN APARECER EN EL COMBOBOX
             * TAREA 2 
             * LOS CURSOS DEBEN CARGAR SEGUN EL PROGRAMA SELECCIONADO
             * 
             * 
             */
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] programas = { "Computacion", "Contabilidad", "Cocina" };
            //                          0               1              2
            /*for (int i = 0; i < 3; i++)
            {
                cbxPrograma.Items.Add(programas[i]);
            }*/
            for (int i = 0; i < programas.Length; i++)
            {
                cbxPrograma.Items.Add(programas[i]);
            }
        }

        private void cbxPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(cbxPrograma.SelectedIndex.ToString()+" "+cbxPrograma.SelectedItem);
            string[] CursosComputacion = {"Excel","Windows" };
            //Aumentar los cursos para los otros programas
            string[] CursosContabilidad = {"Asistente Financiero","Asistente Contable" };
            string[] CursosCocina = {"Reposteria","Jugos","Desayunos"};
            if (cbxPrograma.SelectedIndex==0)
            {

                cbxCurso.Items.Clear();
                for (int i = 0; i < CursosComputacion.Length; i++)
                {
                    cbxCurso.Items.Add(CursosComputacion[i]);
                }
            }
            
            if (cbxPrograma.SelectedIndex==1)
            {
                cbxCurso.Items.Clear();
                for (int i = 0; i < CursosContabilidad.Length; i++)
                {
                    cbxCurso.Items.Add(CursosContabilidad[i]);
                }
            }
            if (cbxPrograma.SelectedIndex==2)
            {
                cbxCurso.Items.Clear();
                for (int i = 0; i < CursosCocina.Length; i++)
                {
                    cbxCurso.Items.Add(CursosCocina[i]);
                }
            }
            
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            
            String Nombre = txtAlumno.Text; 
            int Monto = int.Parse(txtMonto.Text);
            int Duracion = int.Parse(txtDuracion.Text);
            MessageBox.Show("El Alumno: "+Nombre+" debe Pagar: "+Monto*Duracion);
            
        }
    }
}
