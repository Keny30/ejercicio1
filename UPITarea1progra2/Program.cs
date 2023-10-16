using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace UPITarea1progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- ejercicio 1");
                Console.WriteLine("2- ejercicio 2");
                Console.WriteLine("3- ejercicio 3");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Console.Clear();
                        Ejercicio1();
                        break;
                    case 2: Console.Clear();
                        Ejercicio2();
                        break;
                    case 3: Console.Clear();
                        Ejercicio3();
                        break;
                    default:
                        break;

                }
            } while (opcion != 4);//mientras que la opcion sea diferente de 4


        }
  

        public static void Ejercicio1()
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;
            float descuentoTotal = 0f;
            float descuento= 0f;

            Console.WriteLine("Digite el precio de la camisa");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            descuento = calcularDescuento(cantidad);

            descuentoTotal = (cantidad * precio) * descuento;
            total = (cantidad * precio) - descuentoTotal;

            Console.WriteLine($"total a pagar: {total} con descuento de {descuento}%");   
        }
        public static float calcularDescuento(float cantidad)
        {
            float  descuento = 0f;

            if (cantidad == 1)
            {
                descuento = 0f;
            }

            else if (cantidad > 1 && cantidad < 6)
            {
                descuento = 0.15f;
            }

            else if (cantidad <= 6)
            {
                descuento = 0.20f;
            }
            return descuento;
        }
        public static float calcularPromedios(float nota1, float nota2, float nota3)
        {
            float resultado = (nota1 + nota2 + nota3) / 3;
            
            return resultado;
        }
        public static float calcularPorcentaje(float notaPromedio, float valorPorcentual)
        {
            float resultado = (notaPromedio * valorPorcentual) / 100;

            return resultado;
        }
        public static float calcularNotaFinal(float nota1, float nota2,float nota3)
        {
            float resultado = (nota1 + nota2 + nota3);

            return resultado;
        }
        public static string obtenerCondicionEstudiante(float notaFinal)
        {
            string estado = string.Empty;

            if (notaFinal >= 70)
            {
                estado = "APROBADO";
            }

            else if (notaFinal >= 50 && notaFinal < 70)
            {
                estado = "APLAZADO";
            }

            else if (notaFinal < 50)
            {
                estado = "REPROBADO";

            }

            return estado;

        }

        public static void Ejercicio2()
        {

            string nombre = string.Empty;
            int id = 0;
            float quiz1 = 0f;
            float quiz2 = 0f;
            float quiz3 = 0f;
            float exam1 = 0f;
            float exam2 = 0f;
            float exam3 = 0f;
            float tarea1 = 0f;
            float tarea2 = 0f;
            float tarea3 = 0f;
            float promedioquiz = 0f;
            float promediotarea = 0f;
            float promedioexamenes = 0f;


            Console.WriteLine("Digite el nombre del estudiante");
            nombre = (Console.ReadLine());
            Console.WriteLine("Digite la cedula del estudiante");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del primer quiz");
            quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del segundo quiz");
            quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del tercer quiz");
            quiz3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota de la primer tarea");
            tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota de la segunda tarea");
            tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota de la tercer tarea");
            tarea3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del primer examen");
            exam1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del segundo examen");
            exam2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota del tercer examen");
            exam3 = float.Parse(Console.ReadLine());

            promedioquiz = calcularPromedios(quiz1, quiz2, quiz3);
            promediotarea = calcularPromedios(tarea1, tarea2 , tarea3);
            promedioexamenes = calcularPromedios(exam1 ,exam2 ,exam3);

            float ponderado1 = 0;
            float ponderado2 = 0;
            float ponderado3 = 0;

            ponderado1 = calcularPorcentaje(promedioquiz,25);
            ponderado2 = calcularPorcentaje(promediotarea, 30);
            ponderado3 = calcularPorcentaje(promedioexamenes, 45);

            float notafinal = 0;

            notafinal = calcularNotaFinal(ponderado1 ,ponderado2 ,ponderado3);

            string estado = string.Empty;
                   estado = obtenerCondicionEstudiante(notafinal);
        

            Console.WriteLine("Estudiante: " + nombre);
            Console.WriteLine("Carnet: " + id);
            Console.WriteLine("Porcentage Quices: " + ponderado1);
            Console.WriteLine("Porcentage Tareas: " + ponderado2);
            Console.WriteLine("Porcentage Examenes: " + ponderado3);
            Console.WriteLine("Nota Final: " +  notafinal);
            Console.WriteLine("Condicion del estudiante: " + estado);
        }
        public static void Ejercicio3()
        {

            int Cantidad_Productos = 0;
            float precio = 0;
            float Total = 0;

            Console.WriteLine("Cuantos productos desea adquirir? ");
            Cantidad_Productos = int.Parse(Console.ReadLine());


            if (Cantidad_Productos <= 10)
            {
                precio = 20;
                Total = Cantidad_Productos * precio;
            }else if (Cantidad_Productos > 10)
            {
                precio = 15;
                Total = Cantidad_Productos * precio;
            }
            Console.WriteLine($"El precio por producto es de: ${precio}");
            Console.WriteLine($"Total a pagar: $ {Total}");


        }

    }
}
