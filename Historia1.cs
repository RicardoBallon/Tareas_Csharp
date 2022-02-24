using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 0-5 MUY MALO
             * 6-10 MALO
             * 11-12 REGULAR
             * 13-16 BUENO
             * 17-20 MUY BUENO
             */
            string x = "Si";

            while (x=="Si"||x=="si"||x=="s"||x=="S")
            {
                Console.WriteLine("INGRESE LAS 3 NOTAS SEPARADAS POR ENTER");
                double nota1 = double.Parse(Console.ReadLine());
                double nota2 = double.Parse(Console.ReadLine());
                double nota3 = double.Parse(Console.ReadLine());
                double prom = (nota1+nota2+nota3)/ 3;
                if (prom>=0)
                {
                    if (prom<=5)
                    {
                        Console.WriteLine("MUY MALO");
                    }
                    else if (prom>=6)
                    {
                        if (prom<=10)
                        {
                            Console.WriteLine("MALO");
                        }
                        else if (prom>=11)
                        {
                            if (prom<=12)
                            {
                                Console.WriteLine("REGULAR");
                            }
                            else if (prom>=13)
                            {
                                if (prom <= 16)
                                {
                                    Console.WriteLine("BUENO");
                                }
                                else if (prom>=17)
                                {
                                    if (prom <=20)
                                    {
                                        Console.WriteLine("Muy Bueno");
                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("Otra vez?");
                x = Console.ReadLine();
            }


        }
    }
}
