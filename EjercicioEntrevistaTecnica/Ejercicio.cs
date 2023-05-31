using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntrevistaTecnica
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese un color: ");
            string color = Console.ReadLine();

            //Declaración de las dos funciones
            MetodoIf(color);
            MetodoSwitch(color);

            Console.ReadLine();
        }

        static void MetodoIf(string color)
        {
            if (color == "Amarillo")
            {
                Console.WriteLine("\nTabla del 2:");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = 2 * i;
                    Console.WriteLine($"2 x {i} = {resultado}");
                }
            }
            else if (color == "Morado")
            {
                Console.WriteLine("\nTabla del 7:");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = 7 * i;
                    Console.WriteLine($"7 x {i} = {resultado}");
                }
            }
            else if (color == "Rosa")
            {
                Console.WriteLine("\nTabla del 9:");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = 9 * i;
                    Console.WriteLine($"9 x {i} = {resultado}");
                }
            }
            else if (color == "Azul")
            {
                Console.WriteLine("\nTabla del 6:");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = 6 * i;
                    Console.WriteLine($"6 x {i} = {resultado}");
                }
            }
            else if (color == "Blanco")
            {
                Console.WriteLine("\nTabla del 12:");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = 12 * i;
                    Console.WriteLine($"12 x {i} = {resultado}");
                }
            }
            else
            {
                Console.WriteLine("\nColor no válido.");
            }
        }

        static void MetodoSwitch(string color)
        {
            switch (color)
            {
                case "Amarillo":
                    Console.WriteLine("\nTabla del 2:");
                    for (int i = 1; i <= 10; i++)
                    {
                        int resultado = 2 * i;
                        Console.WriteLine($"2 x {i} = {resultado}");
                    }
                    break;

                case "Morado":
                    Console.WriteLine("\nTabla del 7:");
                    for (int i = 1; i <= 10; i++)
                    {
                        int resultado = 7 * i;
                        Console.WriteLine($"7 x {i} = {resultado}");
                    }
                    break;

                case "Rosa":
                    Console.WriteLine("\nTabla del 9:");
                    for (int i = 1; i <= 10; i++)
                    {
                        int resultado = 9 * i;
                        Console.WriteLine($"9 x {i} = {resultado}");
                    }
                    break;

                case "Azul":
                    Console.WriteLine("\nTabla del 6:");
                    for (int i = 1; i <= 10; i++)
                    {
                        int resultado = 6 * i;
                        Console.WriteLine($"6 x {i} = {resultado}");
                    }
                    break;

                case "Blanco":
                    Console.WriteLine("\nTabla del 12:");
                    for (int i = 1; i <= 10; i++)
                    {
                        int resultado = 12 * i;
                        Console.WriteLine($"12 x {i} = {resultado}");
                    }
                    break;

                default:
                    Console.WriteLine("\nColor no válido.");
                    break;
            }
        }
    }
}
