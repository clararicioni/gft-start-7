using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("1234-5678", "Nokia 1100", "000111222333444", 512);
        Iphone iphone = new Iphone("9876-5432", "iPhone 13", "999888777666555", 4096);

        bool sair = false;

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Teste de Celulares ===");
            Console.WriteLine("1 - Testar Nokia");
            Console.WriteLine("2 - Testar iPhone");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    TestarCelular(nokia);
                    break;
                case "2":
                    TestarCelular(iphone);
                    break;
                case "0":
                    sair = true;
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void TestarCelular(Smartphone celular)
    {
        bool voltar = false;

        while (!voltar)
        {
            Console.Clear();
            Console.WriteLine($"=== Testando {celular.GetType().Name} ===");
            Console.WriteLine("1 - Ligar");
            Console.WriteLine("2 - Receber Ligação");
            Console.WriteLine("3 - Instalar Aplicativo");
            Console.WriteLine("0 - Voltar");
            Console.Write("Escolha uma ação: ");
            string acao = Console.ReadLine();

            switch (acao)
            {
                case "1":
                    celular.Ligar();
                    break;
                case "2":
                    celular.ReceberLigacao();
                    break;
                case "3":
                    Console.Write("Digite o nome do aplicativo para instalar: ");
                    string nomeApp = Console.ReadLine();
                    celular.InstalarAplicativo(nomeApp);
                    break;
                case "0":
                    voltar = true;
                    break;
                default:
                    Console.WriteLine("Ação inválida! Pressione qualquer tecla para tentar novamente.");
                    break;
            }

            if (!voltar)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
