using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {

            grados();
        
            Console.ReadKey();
        }
        static void grados()
        {
            string entrada = "";
            int i = 0;
            float grados = 0f;

            float resultado = 0f;

            Console.WriteLine("\t \t Conversor de Grados  "); // Escribe por pantalla un string


           
            Console.WriteLine("Ingrese Numero de grados  "); // Escribe por pantalla un string 
            entrada = Console.ReadLine();
            grados = Convert.ToSingle(entrada);
            resultado = 3.15f * grados;

            Console.Write(" Resultado en Radianes es " + resultado); // Escribe por pantalla un string 
        }
    }
}