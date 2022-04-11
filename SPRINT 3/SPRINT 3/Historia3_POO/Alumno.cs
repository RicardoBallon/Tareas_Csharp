using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2.Entidad
{
    class Alumno
    {
        private string nombre;
        //public int MyProperty { get; set; }
        //Pones prop doble tab
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
    }
}
