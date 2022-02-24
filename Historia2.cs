using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchtarea
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "no";
            while (s == "no"||s=="n"||s=="No")
            {
                Console.WriteLine("Ingrese mes de nacimiento");
                string mes = Console.ReadLine();
                Console.WriteLine("Ingrese dia de nacimiento");
                int dia = int.Parse(Console.ReadLine());
                switch (mes)
                {
                    case "Marzo":
                        if (dia>=20)
                        {
                            Console.WriteLine("Aries");
                        }
                        else
                        {
                            Console.WriteLine("Picis");
                        }
                        break;
                    case "Abril":
                        if (dia>=21)
                        {
                            Console.WriteLine("Tauro");
                        }
                        else
                        {
                            Console.WriteLine("Aries");
                        }
                        break;
                    case "Mayo":
                        if (dia>=21)
                        {
                            Console.WriteLine("Geminis");
                        }
                        else
                        {
                            Console.WriteLine("Tauro");
                        }
                        break;
                    case "Junio":
                        if (dia>=22)
                        {
                            Console.WriteLine("Cancer");
                        }
                        else
                        {
                            Console.WriteLine("Geminis");
                        }
                        break;
                    case "Julio":
                        if (dia>=23)
                        {
                            Console.WriteLine("Leo");
                        }
                        else
                        {
                            Console.WriteLine("Cancer");
                        }
                        break;
                    case "Agosto":
                        if (dia>=24)
                        {
                            Console.WriteLine("Virgo");
                        }
                        else
                        {
                            Console.WriteLine("Leo");
                        }
                        break;
                    case "Septiembre":
                        if (dia>=23)
                        {
                            Console.WriteLine("libra");
                        }
                        else
                        {
                            Console.WriteLine("Virgo");
                        }
                        break;
                    case "Octubre":
                        if (dia>=23)
                        {
                            Console.WriteLine("Escorpio");
                        }
                        else
                        {
                            Console.WriteLine("Libra");
                        }
                        break;
                    case "Noviembre":
                        if (dia>=23)
                        {
                            Console.WriteLine("Sagitario");
                        }
                        else
                        {
                            Console.WriteLine("Escorpio");
                        }
                        break;
                    case "Diciembre":
                        if (dia>=22)
                        {
                            Console.WriteLine("Capricorneo");
                        }
                        else
                        {
                            Console.WriteLine("Sagitario");
                        }
                        break;
                    case "Enero":
                        if (dia>=21)
                        {
                            Console.WriteLine("Acuario");
                        }
                        else
                        {
                            Console.WriteLine("Capricorneo");
                        }
                        break;
                    case "Febrero":
                        if (dia>=20)
                        {
                            Console.WriteLine("Picis");
                        }
                        else
                        {
                            Console.WriteLine("Acuario");
                        }

                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.WriteLine("Terminar el programa s/n");
                s=Console.ReadLine();
            }
        }
    }
}
