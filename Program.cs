using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int Numerador;
            int Denominador; 

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-----Bem-Vindo-----\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite o Numerador....: ");

            Console.ForegroundColor = ConsoleColor.White;
            Numerador = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite o Denominador..: ");

            Console.ForegroundColor = ConsoleColor.White;
            Denominador = Convert.ToInt32(Console.ReadLine());

             if (Denominador == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\nERROR: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Não é possível dividir por zero.");
                Environment.Exit(-1);
            }

            int Resultado = Numerador / Denominador;

            Console.Write($"\n {Numerador} dividido por {Denominador} é {Resultado}.");

            Console.ResetColor();
        }
    }
}
