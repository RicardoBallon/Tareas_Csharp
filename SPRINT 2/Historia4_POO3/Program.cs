using POO3.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando objeto Alumno
            Alumno alumno = new Alumno();
            //Ingresando datos del Alumno
            Console.WriteLine("Ingrese DNI: ");
            alumno.DNI = Console.ReadLine();
            Console.WriteLine("Ingrese Nombres: ");
            alumno.Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese Apellidos: ");
            alumno.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese Sexo (Masculino/Femenino)");
            alumno.Sexo = Console.ReadLine();
            //Ingresando NOTAS
            Console.WriteLine("Ingrese Nota 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Nota 2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Nota 3: ");
            int n3 = int.Parse(Console.ReadLine());
            alumno.Limpiar();
            alumno.MostrarDatos();
            Console.WriteLine("El codigo del alumno es: " + alumno.GenerarCodigo());
            Console.WriteLine("El promedio del alumno es: "+alumno.Promediar(n1, n2, n3));//Calculando el promedio con el metodo promedio
            Console.WriteLine("La nota final del alumno es: " + alumno.LeerNota(alumno.Promediar(n1,n2,n3)));
            Console.ReadLine();
        }
    }
}
