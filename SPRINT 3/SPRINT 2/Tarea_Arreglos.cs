using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] alumno = {"A","B","C","D","E" };
            int[] notas = {16,20,10,13,8 };         
            
            //REPORTES GENERALES
            Console.WriteLine("Reporte General ==002==\n");
            for (int i = 0; i < alumno.Length; i++)
            {
                if (notas[i] >= 13)
                {
                    //Console.ForegroundColor = ConsoleColor.Blue;
                   // Console.WriteLine(alumno[i] + " aprueba");
                    Console.WriteLine("Alumnos: " + alumno[i] + "\tNota: " + notas[i]+"\tAprobado");
                }
                else
                {
                    //Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine(alumno[i] + " desaprueba");
                    Console.WriteLine("Alumnos: " + alumno[i] + "\tNota: " + notas[i] + "\tDesaprobado");
                }
                //Console.WriteLine("Alumnos: " +alumno[i]+"\tNota: "+notas[i]);
            }

            Console.WriteLine("\nReporte General ==003==\n");
            for (int i = 0; i < alumno.Length; i++)
            {
                if (notas[i] >= 13)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    // Console.WriteLine(alumno[i] + " aprueba");
                    Console.WriteLine("Alumnos: " + alumno[i] + "\tNota: " + notas[i] );
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine(alumno[i] + " desaprueba");
                    Console.WriteLine("Alumnos: " + alumno[i] + "\tNota: " + notas[i] );
                }
                //Console.WriteLine("Alumnos: " +alumno[i]+"\tNota: "+notas[i]);
            }
            Console.Read();           

        }
    }
}