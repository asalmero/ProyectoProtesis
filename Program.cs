using System;

namespace AplicacionPrueba
{
    class Program
    {
        static void Main(string[] args)

        {
            int number, i, j, count = 1;
            Console.Write("Rows :");
            number = int.Parse(Console.ReadLine()); // Convertidor de Tipo de dato
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                //Edita la linea de abajo por favor.
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            // Console.ReadLine();
            count = 1;
            for (j =1; j<= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
                      
            }

             Console.ReadLine();


        }
    }
   
}
