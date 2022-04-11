using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos01
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARANDO UN ARREGLO DE TIPO ALUMNOS (STRING)
            string[] alumnos = new string[3];
            //INSERCION DE DATOS (ESTATICOS)
            alumnos[0] = "Dennis";
            alumnos[1] = "Cesar";
            alumnos[2] = "Anthony";
            //RECORRIENDO EL ARREGLO
            Console.WriteLine("---Reporte General I---");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Elemento del indice "+i+" => "+alumnos[i]);
            }
            //RECORRIENDO EL ARREGLO II
            Console.WriteLine("---Reporte General II---");
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Elemento del indice "+i+" -> " +alumnos[i]);
            }
            //RECORRIENDO EL ARREGLO III
            Console.WriteLine("---Reporte General III(foreach)---");
            foreach (string alumno in alumnos) 
            {
                Console.WriteLine(alumno);
            }
            //RECORRIENDO EL ARREGLO IV
            Console.WriteLine("---Reporte General IV(while)---");
            int indice = 0;
            while (indice<alumnos.Length)
            {
                Console.WriteLine("Alumno del indice"+indice+" -> "+alumnos[indice]);
                indice++;
            }

            //Tareas
            //Reporte v
            Console.WriteLine("Reporte 5");
            for (int i = 2; i >= 0 ; i--)
            {
                
                Console.WriteLine("Elemento del indice " + i + " => " + alumnos[i]);
            }
            //reporte 6
            Console.WriteLine("Reporte 6");
            int indice1 = 2;
            while (indice1>=0)
            {
                Console.WriteLine("Alumno del indice" + indice + " -> " + alumnos[indice]);
                indice1--;
            }
            Console.ReadLine();
        }
    }
}
