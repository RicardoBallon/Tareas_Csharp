using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO2.Entidad;

namespace POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "s";
            while (s == "s")
            {
                //Creando objeto
                Alumno a1 = new Alumno();
                Console.WriteLine("Ingrese nombre:");
                a1.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese apellido:");
                a1.Apellido = Console.ReadLine();
                //a1.Nota1 = int.Parse
                Console.WriteLine("Ingrese Nota 1: ");
                a1.Nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Nota 2: ");
                a1.Nota2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Nota 3: ");
                a1.Nota3 = int.Parse(Console.ReadLine());
                Console.Clear();
                //Reporte de datos ingresados
                Console.WriteLine("Nombre: " + a1.Nombre + " " + a1.Apellido);
                Console.WriteLine("Notas: " + a1.Nota1 + " - " + a1.Nota2 + " - " + a1.Nota3);
                //CALCULAR EL PROMEDIO DEL OBJETO A1
                int promedio = (a1.Nota1 + a1.Nota2 + a1.Nota3) / 3;
                Console.WriteLine("Promedio: " + promedio);

                //PROCESAR SI APRUEBA / DESAPRUEBA
                if (promedio > 11)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Desaprobado");
                }
                Console.WriteLine("Ingresar Otro Alumno (s/n)");
                s = Console.ReadLine();
                Console.Clear();
            }
            
            
        }
    }
}
