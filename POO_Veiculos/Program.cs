using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaCadastro sistema = new SistemaCadastro();

            while (true)
            {
                Console.WriteLine("1. Cadastrar Carro");
                Console.WriteLine("2. Cadastrar Moto");
                Console.WriteLine("3. Cadastrar Caminhão");
                Console.WriteLine("4. Listar Veículos");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // Cadastro de Carro
                        Console.WriteLine("Digite os dados do carro:");
                        Console.Write("Placa: ");
                        string placaCarro = Console.ReadLine();
                        Console.Write("Marca: ");
                        string marcaCarro = Console.ReadLine();
                        Console.Write("Modelo: ");
                        string modeloCarro = Console.ReadLine();
                        Console.Write("Ano: ");
                        int anoCarro = int.Parse(Console.ReadLine());
                        Console.Write("Quantidade de Portas: ");
                        int portasCarro = int.Parse(Console.ReadLine());

                        Carro carro = new Carro(placaCarro, marcaCarro, modeloCarro, anoCarro, portasCarro);
                        sistema.AdicionarVeiculo(carro);
                        break;

                    case "2":
                        // Cadastro de Moto
                        Console.WriteLine("Digite os dados da moto:");
                        Console.Write("Placa: ");
                        string placaMoto = Console.ReadLine();
                        Console.Write("Marca: ");
                        string marcaMoto = Console.ReadLine();
                        Console.Write("Modelo: ");
                        string modeloMoto = Console.ReadLine();
                        Console.Write("Ano: ");
                        int anoMoto = int.Parse(Console.ReadLine());
                        Console.Write("Cilindradas /: ");
                        int CCMoto = int.Parse(Console.ReadLine());

                        Moto moto = new Moto(placaMoto, marcaMoto, modeloMoto, anoMoto, CCMoto);
                        sistema.AdicionarVeiculo(moto);
                        break;

                    case "3":
                        // Cadastro de Caminhão
                        Console.WriteLine("Digite os dados do caminhão:");
                        Console.Write("Placa: ");
                        string placaCaminhao = Console.ReadLine();
                        Console.Write("Marca: ");
                        string marcaCaminhao = Console.ReadLine();
                        Console.Write("Modelo: ");
                        string modeloCaminhao = Console.ReadLine();
                        Console.Write("Ano: ");
                        int anoCaminhao = int.Parse(Console.ReadLine());
                        Console.Write("Capacidade de Carga (toneladas): ");
                        double capacidadeCarga = double.Parse(Console.ReadLine());

                        Caminhao caminhao = new Caminhao(placaCaminhao, marcaCaminhao, modeloCaminhao, anoCaminhao, capacidadeCarga);
                        sistema.AdicionarVeiculo(caminhao);
                        break;

                    case "4":
                        // Listar veículos
                        sistema.ListarVeiculos();
                        break;

                    case "5":
                        // Sair do programa
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine(); // Linha em branco para melhor formatação
            }
        }
    }



}
