using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography;

namespace Ejercicio_con_funciones_pero_de_verdad
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escriba el año que desee evaluar: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int prueba1 = year % 4;
            int prueba2 = year % 100;
            int prueba3 = year % 400;

            if (prueba1 == 0)
            {
                if (prueba2 != 0)
                {
                    Verdadero();
                }
                else if (prueba2 == 0)
                {
                    if (prueba3 == 0)
                    {
                        Verdadero();
                    }
                    else if (prueba3 != 0)
                    {
                        Falso();
                    }
                }
            }
            else if (prueba1 != 0)
            {
                Falso();
            }
        }
        public static void Verdadero()
        {
            Console.WriteLine("El año que ingreso si es bisiesto!");
        }
        public static void Falso()
        {
            Console.WriteLine("El año que ingreso no es bisiesto.");
        }
    }
}