using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Veiculos
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        // Construtor da classe Carro
        // Herança
        public Carro(string placa, string marca, string modelo, int ano, int quantidadePortas)
            : base(placa, marca, modelo, ano)
        {
            QuantidadePortas = quantidadePortas;
        }

        // Polimorfismo, para informar os dados 
        public override void MostrarInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}, Placa: {Placa}, Portas: {QuantidadePortas}");
        }
    }

}
