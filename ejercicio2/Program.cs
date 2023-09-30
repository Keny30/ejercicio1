using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //acumuladores y contadores
            int contador = 0;
            float total = 0; int salario = 0;
             
            //contadores
            contador = contador + 1;
            contador++;
            ++contador;
            contador--;
            --contador;

            //acumuladores

            total = total + salario;
            total += salario;
            total += 5;
            total *= 2;
            total /= 6; //total = total / 6

            //sistema para calcular el promedio de n estudiantes
            // calcular cuantos estudiantes una nota superior al promedio

            string[] Estudiantes = new string[4];
            float[] notas = new float[4];
            float promedio = 0;
            total = 0;
            contador = 0;

            for (int i = 0; i < Estudiantes.Length; i++)
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                Estudiantes[i] = Console.ReadLine();
                Console.Write("Ingrese la nota: ");
                //convertir de string a flotante
                notas[i] = float.Parse(Console.ReadLine());
                total= total + notas[i];

            }
            total/=Estudiantes.Length;  //dividir las notas entre la cantidad de estudiantes

            Console.WriteLine($"El promedio es de: {total}");


            //calcular la cantidad de estudiantes con nota mayor al promedio

            for (int i = 0;i < notas.Length; i++)
            {
                if (notas[i] > total) // i = 0
                {
                    Console.WriteLine("Estudiante: " + Estudiantes[i]  + " Nota: " + notas[i]);
                    contador++; // contador = contador + 1

                }
            }
            Console.WriteLine($"La cantidad de estudiantes con nota mayor al promedio es de {contador}");
            Console.ReadLine();
        }
    }
}
