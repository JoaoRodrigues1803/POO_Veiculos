using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Veiculos
{
    public class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; }

        // Construtor da classe Caminhao
        public Caminhao(string placa, string marca, string modelo, int ano, double capacidadeCarga)
            : base(placa, marca, modelo, ano)
        {
            CapacidadeCarga = capacidadeCarga;
        }

        public override void MostrarInformacoes()
        {
            Console.WriteLine($"Caminhão: {Marca} {Modelo}, Ano: {Ano}, Placa: {Placa}, Capacidade de Carga: {CapacidadeCarga} toneladas");
        }
    }

}
