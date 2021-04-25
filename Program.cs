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
            string QuantidadeDigitada; 
            string letras;
            bool NumeroValido;
            bool NumeroValido2;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-----Bem-Vindo-----\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite o Numerador....: ");

            Console.ForegroundColor = ConsoleColor.White;
            letras = Console.ReadLine();
            NumeroValido2 = Int32.TryParse(letras, out Numerador);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite o Denominador..: ");

            Console.ForegroundColor = ConsoleColor.White;
            QuantidadeDigitada = Console.ReadLine();
            NumeroValido = Int32.TryParse(QuantidadeDigitada, out Denominador);
            
            if (!NumeroValido2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\nERROR: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Só dividimos Números.");
            }
            else
            {  
                if (!NumeroValido)
                {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\nERROR: ");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Só Dividimos Números.");
                }
                else
                {
                    if (Denominador == 0)
                    {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\nERROR: ");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Não é possível dividir por zero.");
                    Environment.Exit(-1);
                    }
                    else
                    {
                    int Resultado = Numerador / Denominador;

                    Console.Write($"\n {Numerador} dividido por {Denominador} é {Resultado}.");
                    }
                }    
            }            
            Console.ResetColor();
        }
    }
}
