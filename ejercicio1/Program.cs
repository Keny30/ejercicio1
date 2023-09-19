using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        public struct Empleado
        {
           public int codigo;
           public string nombre;
           public float salario;
        }
        static void Main(string[] args)
        {  
            


            //tipos de datos

            int num1, num2;
            num1 = 30;
            float flotante = 3.14f;
            double doble = 15.2;
            decimal deci = 15.15m;
            short corto = 5660;
            byte b = 25;
            long larga = 12345484774665;
            ulong ulargo = 56;

            Boolean boleano = false;
            char Letra = 'a';
            string cadena = "Hoy es lunes 18 de setiembre";

            //var // dynamic

            var variable = 15.25f;
            
            dynamic dinamica = 25.3f;
            dinamica = "Nombre empleado";
            dinamica = true;
            dinamica = 'c';

            Empleado emp;
            emp.codigo = 1;
            emp.nombre = "Kenia";
            emp.salario = 500;

            //arreglos

            int n = 4;
            string[] musico = new string[4];   
            musico[0] = "Carlos";
            musico[1] = "Maria";
            musico[2] = "Sofia";
            musico[3] = "Eva";

            float[] salario = new float[20];
            /*
             *  i = 0, 1, 2, 3, 4
             
             */
            
            for (int i = 0; i < salario.Length; i++)
            { 
                Console.WriteLine("Digite el salario"); 
                salario[i] = float.Parse(Console.ReadLine());   
            }
           if (true)
            {

            }

            while (true) { }

            do 
            { 
            
            } while (true);    


            Console.WriteLine("Listado de musicos");

            Console.WriteLine(musico[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);


          

            Console.ReadLine();
            string[] nombres = new string[] {"Ringo", "George","Paul", "John"};

            

                
        }
        
    }
        
}


