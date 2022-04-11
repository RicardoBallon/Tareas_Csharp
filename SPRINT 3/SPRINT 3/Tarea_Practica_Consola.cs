using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Variables y Estructuras de Control \n" +
                                "1.Ingresar 5 números y mostrar su promedio \n" +
                                "2.Ingresar un número y mostrar su cuadrado y cubo. \n" +
                                "3.Mostrar los números impares entre el 0 y el 100. \n" +
                                "4.Mostrar los números pares entre el 0 y el 100. \n" +
                                "5.Mostrar los números del 0 al 100\n" +
                                "6.Ingresar un número y mostrar el listado hasta ese número\n" +
                                "7.Ingresar un número de inicio y un número final, mostrar el listado de números entre ambos\n" +
                                "8.Mostrar los números del 100 al 0 \n" +
                                "9.Mostrar los múltiplos de 3 del 0 al 100\n" +
                                "10.Ingresar un número y mostrar la suma de los números que lo anteceden\n." +
                                "11.Mostrar los números del 1 hasta el número ingresado.\n" +
                                "12.Contar los múltiplos de 3 desde la unidad hasta un núm.que ingresamos\n" +
                                "13.Ingresar 10 números sumar los + y multiplicar los – \n" +
                                "14.Por teclado se ingresa el valor hora de un empleado.Posteriormente se ingresa el nombre del empleado,\n" +
                                "la antigüedad y la cantidad de horas trabajadas en el mes.Se pide calcular el importe a cobrar\n" +
                                "teniendo en cuenta que al total que resuelta de multiplicar el valor hora por la cantidad de horas trabajadas,\n" +
                                "hay que sumarle la cantidad de años trabajados multiplicados por $30, y al total de todas esas operaciones\n" +
                                "restarle el 13 % en concepto de descuentos.Imprimir el recibo correspondiente con el nombre, la antigüedad,\n" +
                                "el valor hora, el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar.\n" +
                                "15.Realizar la tabla de multiplicar de un número entre 0 y 10 de forma que se visualice de la siguiente forma: 4x1 = 4\n" +
                                "16.Ingresar 2 números, imprima los números naturales que hay entre ambos.empezando por el más pequeño,\n" +
                                "contar cuántos números hay y cuántos de ellos son pares.\n" +
                                "17.De 10 números ingresados indicar cuantos son mayores a cero y cuantos son menores a cero.\n");
            /*
            Console.WriteLine("Ingresar 5 Numeros y mostrar su promedio");
            Console.WriteLine("========================================");
            Console.WriteLine("Ingresar 1er Número: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar 2do Número: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar 3er Número: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar 4to Número: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar 5to Número: ");
            double e = Convert.ToDouble(Console.ReadLine());
            double promedio = (a+b+c+d+e)/ 5;
            Console.WriteLine("El promedio es: " + promedio);*/

            /*
            Console.WriteLine("Ingresar un Numero y Mostrar su Cuadrado y su Cubo");
            Console.WriteLine("==================================================");
            Console.WriteLine("Ingresar Numero");
            double CC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Su Cuadrado es: " + CC * CC + " Su Cubo es: " + CC * CC * CC);*/

            /*
            Console.WriteLine("Mostrar los números pares entre el 0 y el 100");
            Console.WriteLine("===============================================");
            for (int i = 0; i < 101; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*
            Console.WriteLine("Mostrar los números impares entre el 0 y el 100");
            Console.WriteLine("=============================================");
            for (int i = 0; i < 101; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*
            Console.WriteLine("Mostrar los números de 0 al 100");
            Console.WriteLine("===============================");
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
            }*/

            /*
            Console.WriteLine("Ingresar un número y mostrar el listado hasta ese número");
            Console.WriteLine("========================================================");
            Console.WriteLine("Ingresar hasta que número contar");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= k; i++)
            {
                Console.WriteLine(i);
            }*/

            /*
            Console.WriteLine("Ingresar un número de inicio y un número final, mostrar el listado de números entre ambos");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("Ingresar numero de inicio");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar numero final");
            int k = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= k; i++)
            {
                Console.WriteLine(i);
            }*/

            /*
            Console.WriteLine("Mostrar los números del 100 al 0");
            Console.WriteLine("================================");
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }*/

            /*
            Console.WriteLine("Mostrar los múltiplos de 3 del 0 al 100");
            Console.WriteLine("=======================================");
            for (int i = 0; i < 100; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*
            Console.WriteLine("Ingresar un número y mostrar la suma de los números que lo anteceden.");
            Console.WriteLine("=====================================================================");
            Console.WriteLine("Ingresar Numero");
            int s = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            for (int i = 0; i < s; i++)
            {
                suma = i + suma;
                //Console.WriteLine(suma);
            }
            Console.WriteLine(suma);*/

            /*
            Console.WriteLine("Mostrar los números del 1 hasta el número ingresado.");
            Console.WriteLine("====================================================");
            Console.WriteLine("Ingresar numero");
            int serie = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= serie; i++)
            {
                Console.WriteLine(i);
            }*/

            /*
            Console.WriteLine("Contar los múltiplos de 3 desde la unidad hasta un núm. que ingresamos");
            Console.WriteLine("======================================================================");
            Console.WriteLine("Ingresar numero");
            int m3i=Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            for (int i = 0; i < m3i; i++)
            {
                if (i%3 == 0)
                {
                    contador = contador + 1;
                }
            }
            Console.WriteLine(contador);*/

            /*
            Console.WriteLine("Ingresar 10 números sumar los + y multiplicar los – ");
            Console.WriteLine("Ingresar 1er Numero");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar 2do Numero");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar 3ro Numero");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar 4to Numero");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar 5to Numero");
            int n5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar 6to Numero");
            int n6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar 7mo Numero");
            int n7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar 8vo Numero");
            int n8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar 9no Numero");
            int n9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar 10mo Numero");
            int n10 = Convert.ToInt32(Console.ReadLine());
            List<int> numeros = new List<int>();
            numeros.Add(n1);
            numeros.Add(n2);
            numeros.Add(n3);
            numeros.Add(n4);
            numeros.Add(n5);
            numeros.Add(n6);
            numeros.Add(n7);
            numeros.Add(n8);
            numeros.Add(n9);
            numeros.Add(n10);
            int suma = 0;
            int multiplicar = 1;
            foreach (var numero in numeros)
            {
                if (numero > 0)
                {
                    suma = suma + numero;
                }
                else
                {
                    multiplicar = multiplicar * numero;
                }
            }
            Console.WriteLine(suma);
            Console.Write(multiplicar);*/

            /*
            Console.WriteLine("Problema 14");
            Console.WriteLine("Ingresar Ganacia por horas");
            int Ghoras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar nombre del empleado");
            string nombre = Console.ReadLine();
            Console.WriteLine("Antiguedad del empleado");
            int Antiguedad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cantidad de horas trabajadas en el mes");
            int horasT = Convert.ToInt32(Console.ReadLine());
            double CobroTotal = (horasT*Ghoras+Antiguedad*30);
            double descuentos = CobroTotal * 13 / 100;
            double CobroNeto = CobroTotal - descuentos;
            Console.Clear();
            Console.WriteLine("Recibo del Empleado");
            Console.WriteLine("===================");
            Console.WriteLine(nombre);
            Console.WriteLine("Antiguedad del empleado: "+Convert.ToString(Antiguedad));
            Console.WriteLine("Valor de hora: " + Ghoras);
            Console.WriteLine("Total a cobrar en bruto: " + CobroTotal);
            Console.WriteLine("Total de descuentos: " + descuentos);
            Console.WriteLine("Valor Neto a cobrar: " + CobroNeto);*/

            /*
            Console.WriteLine("Realizar la tabla de multiplicar de un número entre 0 y 10\n" +
                "de forma que se visualice de la siguiente forma: 4x1=4");
            Random numeroRandom = new Random();
            int azar;
            azar = numeroRandom.Next(0,10);
            Console.WriteLine("Tabla de multiplicar del: "+azar);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(Convert.ToString(azar) + " x " + i + " = " + azar*i );
            }*/


            /*
            Console.WriteLine("Ingresar 2 números, imprima los números naturales que hay entre ambos.\n" +
                "empezando por el más pequeño, contar cuántos números hay y cuántos de ellos son pares.");
            Console.WriteLine("Ingresar 1er Numero");
            int n1601 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar 2do Numero");
            int n1602 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int contador = 0;
            int contadorPares = 0;
            if (n1601 > n1602)
            {
                for (int i = n1602+1; i < n1601; i++)
                {
                    contador = contador + 1;
                    Console.Write(i+"-");
                    if (i%2==0)
                    {
                        contadorPares = contadorPares + 1;
                    }
                }
            }
            else
            {
                for (int j = n1601+1; j < n1602; j++)
                {
                    contador = contador + 1;
                    Console.Write(j+"-");
                    if (j%2==0)
                    {
                        contadorPares = contadorPares + 1;
                    }
                }
            }
            Console.WriteLine(" Hay: " + contador +" numero entre ellos y "+contadorPares+" son pares.");*/

            /*
            Console.WriteLine("De 10 números ingresados indicar cuantos son mayores a cero y cuantos son menores a cero");
            List<int> numeros1710 = new List<int>();
            int contadorMayor = 0;
            int contadorMenor = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Ingresar Numero: " + i);
                numeros1710.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (var numeros17 in numeros1710)
            {
                if (numeros17>0)
                {
                    contadorMayor = contadorMayor + 1;
                }
                else
                {
                    contadorMenor = contadorMenor + 1;
                }
            }

            Console.WriteLine("De los 10 numeros ingresados " + contadorMayor + " son mayores a 0 y " + contadorMenor + " son menores a 0");*/

            /*
            Console.WriteLine("Listas, Arreglos, Vectores.\n\n" +
                "18.Se registran 10 empleados de una empresa Número de legajo,\n" +
                "sueldo, sexo(1 = femenino y 2 = masculino).\n" +
                "Mostrar cuantas mujeres ganan más de $500 pesos y\n" +
                "cuantos hombres ganan menos de $400.\n\n" +
                "19.Hacer el algoritmo que imprima el mayor y el menor de una serie de 5 números\n" +
                "que vamos introduciendo por teclado\n\n" +
                "20.Ingresar el nombre y el promedio final de alumnos\n" +
                "(solo mientras dicho promedio es >= 0 y <= 20),\n" +
                "los datos serán almacenados en Listas.\n" +
                "Realizar el conteo de alumnos desaprobados y aprobados.\n\n" +
                "21.Un Programa que inicialmente muestre el siguiente Texto:\n" +
                "¿Desea Agregar un Nuevo Registro?.Mientras el usuario ingrese “s”\n" +
                "el programa solicitara el ingreso de los siguientes datos:\n" +
                "Nombre, Apellidos, Cant.De días trabajados, sueldo diario.\n" +
                "La Aplicación deberá calcular el sueldo total del empleado.\n" +
                "Si el sueldo total del empleado es < 1000(menor a mil).\n" +
                "Se le asignará una bonificación del 10 %, en caso contrario(sueldo_total >= 1000)\n" +
                "la bonificación será de 0.Dichos datos serán almacenados en listas\n" +
                "(1 lista por cada dato).Mostrar los datos de los trabajadores que tienen bonificación.\n\n" +
                "22.Crear un programa que inicialmente pida la cantidad de elementos introducidos\n" +
                "en un arreglo de tipo String, seguidamente los datos deberán ser ingresados a dicho arreglo.\n");*/

            /*
            Console.WriteLine("18.Se registran 10 empleados de una empresa Número de legajo,\n" +
                "sueldo, sexo(1 = femenino y 2 = masculino).\n" +
                "Mostrar cuantas mujeres ganan más de $500 pesos y\n" +
                "cuantos hombres ganan menos de $400.\n\n");
            string[] empleado = new string[5];
            int[] sueldo = new int[5];
            int[] sexo = new int[5];
            int ContadorM = 0;
            int ContadorH = 0;
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("Ingresar Nombre");
               // empleado[i] = Console.ReadLine();
                Console.WriteLine("Ingresar Sueldo");
                sueldo[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresar Sexo 1 = Femenino 2 = Masculino");
                sexo[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (sexo[i]==1)
                {
                    if (sueldo[i]>500)
                    {
                        ContadorM = ContadorM + 1;
                    }
                }
                else
                {
                    if (sueldo[i]<400)
                    {
                        ContadorH = ContadorH + 1;
                    }
                }
            }
            Console.WriteLine(ContadorM);
            Console.WriteLine(ContadorH);*/

            /*
            Console.WriteLine("19.Hacer el algoritmo que imprima el mayor y el menor de una serie de 5 números\n" +
                "que vamos introduciendo por teclado.");

            int[] mayor_menor = new int[5];
            //Console.WriteLine("Introducir numero");
            //mayor_menor[0] = Convert.ToInt32(Console.ReadLine());
            mayor_menor[0] = 0;
            mayor_menor[1] = 0;
            mayor_menor[2] = 0;
            mayor_menor[3] = 0;
            mayor_menor[4] = 0;
            for (int i = 0; i < mayor_menor.Length; i++)
            {
                Console.WriteLine("Introducir numero");
                mayor_menor[i] = Convert.ToInt32(Console.ReadLine());
                if (i>=1)
                {
                    if (mayor_menor[i-1]>mayor_menor[i])
                    {
                        Console.WriteLine("El mayor es: " + mayor_menor[i-1] + " El menor es: " + mayor_menor[i]);                        
                    }
               
                    else
                    {
                        Console.WriteLine("" + mayor_menor[i] + "-" + mayor_menor[i-1]);
                    }
                }
                

            }*/

            /*
            Console.WriteLine("20.Ingresar el nombre y el promedio final de alumnos\n" +
                "(solo mientras dicho promedio es >=0 y <=20),\n" +
                " los datos serán almacenados en Listas\n. " +
                "Realizar el conteo de alumnos desaprobados y aprobados.\n");
            
            List<int> alumnosNotas = new List<int>();
            List<string> alumnosNombres = new List<string>();
            int ContadorAprobados = 0;
            Console.WriteLine("Ingrese Cantidad total de Alumnos");
            int Cantidad_Alumnos = Convert.ToInt32(Console.ReadLine());
            int[] notas = new int[Cantidad_Alumnos];
            for (int i = 0; i < Cantidad_Alumnos; i++)
            {
                Console.WriteLine("Ingresar Alumno");
                alumnosNombres.Add(Console.ReadLine());
                Console.WriteLine("Ingresar Nota entre 0 y 20");
                notas[i] = Convert.ToInt32(Console.ReadLine());
                while (notas[i]<0)
                {
                    Console.WriteLine("Ingresar Nota entre 0 y 20");
                    notas[i] = Convert.ToInt32(Console.ReadLine());
                }
                while (notas[i] > 20)
                {
                    Console.WriteLine("Ingresar Nota entre 0 y 20");
                    notas[i] = Convert.ToInt32(Console.ReadLine());
                }
                alumnosNotas.Add(notas[i]);          
                             
            }
            for (int i = 0; i < Cantidad_Alumnos; i++)
            {
                if (alumnosNotas[i] > 10)
                {
                    ContadorAprobados = ContadorAprobados + 1;
                }
            }
            Console.WriteLine("Total de Alumnos aprobados: " + ContadorAprobados + " Total de Alumnos desaprobados: " + (Cantidad_Alumnos - ContadorAprobados));*/

            Console.WriteLine("21.Un Programa que inicialmente muestre el siguiente Texto: ¿Desea Agregar un Nuevo Registro?.\n" +
                "Mientras el usuario ingrese “s” el programa solicitara el ingreso de los siguientes datos:\n" +
                "Nombre, Apellidos, Cant. De días trabajados, sueldo diario.\n " +
                "La Aplicación deberá calcular el sueldo total del empleado.\n" +
                "Si el sueldo total del empleado es <1000 (menor a mil).\n" +
                "Se le asignará una bonificación del 10%, en caso contrario\n" +
                "(sueldo_total>=1000) la bonificación será de 0. \n" +
                "Dichos datos serán almacenados en listas (1 lista por cada dato). \n" +
                "Mostrar los datos de los trabajadores que tienen bonificación.");
            Console.WriteLine("¿Desea Agregar un Nuevo Registro? (s/n)");
            string respuesta = Console.ReadLine();
            List<string> nombres = new List<string>();
            List<int> Cant_Dias = new List<int>();
            List<int> Sueldo_Diario = new List<int>();
            List<int> sueldo = new List<int>();
            List<int> sueldototal = new List<int>();
            List<int> bonificacion = new List<int>();
            int boni;
            int ContBoni = 0;
            while (respuesta == "s")
            {               
                Console.WriteLine("Ingresar Nombre y Apellidos");
                nombres.Add(Console.ReadLine());
                Console.WriteLine("Ingresar Cant. de Dias Trabajados");
                Cant_Dias.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Ingresar Sueldo Diario");
                Sueldo_Diario.Add(Convert.ToInt32(Console.ReadLine()));
                
                Console.WriteLine("¿Desea Agregar un Nuevo Registro? (s/n)");
                respuesta = Console.ReadLine();
                
            }
            Console.Clear();
            for (int i = 0; i < nombres.Count; i++)
            {
                sueldo.Add(Cant_Dias[i] * Sueldo_Diario[i]);
            }
            for (int i = 0; i < nombres.Count; i++)
            {
                if (sueldo[i] < 1000)
                    {
                        boni=((sueldo[i] / 100) * 10)+sueldo[i];
                        
                        Console.WriteLine("Registro de trabajadores con Modificacion: ");
                        Console.WriteLine("Nombres y Apellidos: " + nombres[i] + "\n"+
                                            "Sueldo: "+sueldo[i]+"\n"+
                                            "Bonificacion: " + (sueldo[i] / 100) * 10+"\n"+
                                           "Sueldo total: " + boni + "\n");                    
                        ContBoni = ContBoni + 1;
                    }
                
            }
           
            /*
            Console.WriteLine("22.Crear un programa que inicialmente pida la cantidad de elementos introducidos\n" +
                "en un arreglo de tipo String, seguidamente los datos deberán ser ingresados a dicho arreglo.");
            Console.WriteLine("Cantidad de elementos introducidos");
            int can_ele = Convert.ToInt32(Console.ReadLine());
            string[] arreglo = new string[can_ele];
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Ingresar Datos");
                arreglo[i] = Console.ReadLine();
            }
            foreach (var i in arreglo)
            {
                Console.WriteLine("{0}",i);
            }*/

            Console.Read();

        }
    }
}
