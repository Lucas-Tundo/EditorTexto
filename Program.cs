using System;

namespace nomedoprojeto {
    internal class Program {
        public static void Main() {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");

            short op = short.Parse(Console.ReadLine());

            switch (op) {
                case 0: 
                    System.Environment.Exit(0);
                    break;
                case 1: 
                    Abrir();
                    break;
                case 2: 
                    Editar();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Digite uma opção valida!");
                    Menu();
                    break;
            }

        }

        static void Abrir() {
            Console.Clear();
        }

        static void Editar() {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
            Console.WriteLine("------------------------");
            string text = "";

            do {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write(text);
        }
    }
}