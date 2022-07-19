using System;
using System.Collections.Generic;

namespace Quitandinha
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Bem-vindo ao sistema de estoque!");

            Estoque estoque = new Estoque();

            
            Console.Write("Menu " +
                "\n[1] - Cadastrar produto no estoque " +
                "\n[2] - Efetuar consulta " +
                "\n[3] - Solicitar produto " +
                "\n[4] - Sair do sistema " +
                "\n\nDigite a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine());

            while(opcao != 4)
            {
                switch (opcao)
                {
                    case 1:
                        estoque.cadastrarItem();
                        break;

                    case 2:
                        estoque.exibirProdutos();
                        break;

                    case 3:
                        estoque.solicitarItem();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.Write("\nMenu " +
                "\n[1] - Cadastrar produto no estoque " +
                "\n[2] - Efetuar consulta " +
                "\n[3] - Solicitar produto " +
                "\n[4] - Sair do sistema " +
                "\n\nDigite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
