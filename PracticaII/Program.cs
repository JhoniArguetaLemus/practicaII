using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PracticaII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            // horas a minutos y segundos
             Console.WriteLine("-----------Ejercicio 1 -----------------------");
             int horas, segundos, minutos;
             Console.WriteLine("¿Qué operación desea realizar? \n1.Convertir horas a minutos \n2.Convertir horas a segundos");
             int opcion = int.Parse(Console.ReadLine());

             Console.WriteLine("Ingrese la cantidad de horas: ");
             horas = int.Parse(Console.ReadLine());

             if(opcion == 1)
             {
                 minutos = horas * 60;
                 Console.WriteLine("La cantidad de minutos es: " + minutos);
             }else if (opcion == 2)
             {
                 segundos = horas * 3600;
                 Console.WriteLine("La cantidad de segundos es: " + segundos);
             }






             //ejercicio II

             //calcular Area

             //A=B.H/2

             double baseTriangulo, altura, area;
             Console.WriteLine("\n-----------Ejercicio 2 -----------------------\n");

             Console.WriteLine("¿Cuantas veces quiere ejecutar el programa?");
             int numEjecuciones = int.Parse(Console.ReadLine());

             for (int i = 1; i <= numEjecuciones; i++)
             {
                 Console.WriteLine("\nCalcular área\n");
                 Console.WriteLine("Ingrese la base del triángulo: ");
                 baseTriangulo = Double.Parse(Console.ReadLine());

                 Console.WriteLine("Ingrese  la altura del triángulo: ");
                 altura = Double.Parse(Console.ReadLine());

                 area = (baseTriangulo * altura) / 2;

                 Console.WriteLine("El area del triángulo es: " + area);


                 //calcular perimetro

                 //a+b+c
                 double valorA, valorB, valorC, perimetro;
                 Console.WriteLine("\nCalcular perímetro \n");
                 Console.WriteLine("Ingrese el valor de a: ");
                 valorA = Double.Parse(Console.ReadLine());

                 Console.WriteLine("Ingrese el valor de b: ");
                 valorB = Double.Parse(Console.ReadLine());

                 Console.WriteLine("Ingrese el valor de c: ");
                 valorC = Double.Parse(Console.ReadLine());

                 perimetro = valorA + valorB + valorC;

                 Console.WriteLine("El perimetro del triángulo es: " + perimetro);
             }
            
            
           //ejercicio III calcular area y volumen de un cilindro
           //a=2PI*R(h+R)
           //V=PI*R2*h
           Console.WriteLine("\n---Ejercicio 3-------\n");
           int numeroIngresado = 1;
           while (numeroIngresado != 0)
           {
               Console.WriteLine("\nÁrea y volumen de un cilindro\n");

               double radioCilindro, alturaCilindro, areaCilindro, volumenCilindro;

               Console.WriteLine("Ingrese el Radio: ");

               radioCilindro = Double.Parse(Console.ReadLine());

               Console.WriteLine("Ingrese la altura: ");
               alturaCilindro = Double.Parse(Console.ReadLine());

               areaCilindro = 2 * Math.PI * radioCilindro * (alturaCilindro + radioCilindro);

               volumenCilindro = Math.PI * (radioCilindro * radioCilindro) * alturaCilindro;

               Console.WriteLine("\nEl  área del cilindro es: " + areaCilindro + "\nEl volumen del cilindro es: " + volumenCilindro);
               Console.WriteLine("Ingrese 0 para detener el programa");
               numeroIngresado = int.Parse(Console.ReadLine());

           }

            Console.Read();
        }
    }
}
