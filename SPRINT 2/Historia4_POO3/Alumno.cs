using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3.Negocio
{
    class Alumno
    {
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }

        public int Promediar(int n1, int n2, int n3)
        {
            int promedio = (n1 + n2 + n3) / 3;
            return promedio;
        }
        public void Limpiar()
        {
            Console.Clear();
        }
        public void MostrarDatos()
        {
            Console.WriteLine("---DATOS DEL ALUMNO---");
            Console.WriteLine("DNI: " + this.DNI);
            Console.WriteLine("Nombres: " + this.Nombres);
            Console.WriteLine("Apellidos: " + this.Apellidos);
            Console.WriteLine("Sexo: " + this.Sexo);
        }
        public string GenerarCodigo()
        {
            string codigo = this.DNI.Substring(0, 5) + this.Apellidos.Substring(0, 3);
            //Substring Extraemos caracteres 
            return codigo;
        }
        public string LeerNota(int nota)
        {
            string notaTexto = null;
            if (nota==0)
            {
                notaTexto = "Cero";
            }
            else if (nota ==1)
            {
                notaTexto = "Uno";
            }
            else if (nota == 2)
            {
                notaTexto = "Dos";
            }
            else if (nota == 3)
            {
                notaTexto = "Tres";
            }
            else if (nota == 4)
            {
                notaTexto = "Cuatro";
            }
            else if (nota == 5)
            {
                notaTexto = "Cinco";
            }
            else if (nota == 6)
            {
                notaTexto = "Seis";
            }
            else if (nota == 7)
            {
                notaTexto = "Siete";
            }
            else if (nota == 8)
            {
                notaTexto = "Ocho";
            }
            else if (nota == 9)
            {
                notaTexto = "Nueve";
            }
            else if (nota == 10)
            {
                notaTexto = "Diez";
            }
            else if (nota == 11)
            {
                notaTexto = "Once";
            }
            else if (nota == 12)
            {
                notaTexto = "Doce";
            }
            else if (nota == 13)
            {
                notaTexto = "Trece";
            }
            else if (nota == 14)
            {
                notaTexto = "Catorce";
            }
            else if (nota == 15)
            {
                notaTexto = "Quince";
            }
            else if (nota == 16)
            {
                notaTexto = "Dieciceis";
            }
            else if (nota == 17)
            {
                notaTexto = "Dieciciete";
            }
            else if (nota == 18)
            {
                notaTexto = "Dieciocho";
            }
            else if (nota == 19)
            {
                notaTexto = "Diecinueve";
            }
            else if (nota == 20)
            {
                notaTexto = "Veinte";
            }
            return notaTexto;
        }

    }
}
