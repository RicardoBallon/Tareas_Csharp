using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos3
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONTADORES
            int[] valores = { 0, 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Total de valores" + valores.Length);
            int cont = 0;
            int contPares = 0;
            int contImpares = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                //cont = cont +1;
                cont++;
                if (valores[i] %2==0)
                {
                    contPares++;
                }
                else 
                {
                    contImpares++;
                }
               
            }
            Console.WriteLine("Cantidad de Elementos " + cont);
            Console.WriteLine("Cantidad de valores pares: " + contPares);
            Console.WriteLine("Cantidad de valores Impares: " + contImpares);
            //ACUMULADORES
            int acu = 0;
            int acuPares = 0;
            int acuImpares = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                //acu = acu + valores[i];
                acu += valores[i];
                if (valores[i]%2==0)
                {
                    acuPares = acuPares + valores[i];
                }
                else
                {
                    acuImpares = acuImpares + valores[i];
                }
            }
            Console.WriteLine("La suma de todos los numeros es: "+acu);
            Console.WriteLine("La suma de todos los numeros pares es: " + acuPares);
            Console.WriteLine("La suma de todos los numeros impares es: " + acuImpares);
            Console.Read();

        }
    }
}