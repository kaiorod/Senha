using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, senha;

            Console.Beep();
            Console.Clear();
            Console.Write("Digite seu nome : ");
            nome = Console.ReadLine();

            if(nome != "")
            {
                Console.Write($"Olá {nome}, digite sua senha : ");
                senha = Console.ReadLine();

                if(senha == "1234abcd")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nAcesso Permitido");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nAcesso Negado");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Digite o nome de usuário!!");
                Console.ResetColor();
            }
        }
    }
}
