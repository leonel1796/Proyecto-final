using System;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor, x, suma1, suma2;

            string linea;

            x = 1;

            suma1 = 0;

            suma2 = 0;

            Console.WriteLine("Primer lista");

            while (x <= 5)

            {

                Console.Write("Ingrese valor:");

                linea = Console.ReadLine();

                valor = int.Parse(linea);

                suma1 = suma1 + valor;

                x = x + 1;

            }



            Console.Clear();

            Console.WriteLine("Segunda lista");

            x = 1;

            while (x <= 5)

            {

                Console.Write("Ingrese valor:");

                linea = Console.ReadLine();

                valor = int.Parse(linea);

                suma2 = suma2 + valor;

                x = x + 1;

            }



            Console.Clear();

            if (suma1 > suma2)

            {

                Console.Write("Lista 1 mayor.");

            }

            else

            {

                if (suma2 > suma1)

                {

                    Console.Write("Lista2 mayor.");

                }

                else

                {

                    Console.Write("Listas iguales.");

                }

            }

            Console.ReadKey();
        }
    }
}
