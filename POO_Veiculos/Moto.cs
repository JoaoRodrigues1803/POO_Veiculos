using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Veiculos
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        // Construtor da classe Moto
        public Moto(string placa, string marca, string modelo, int ano, int CC)
            : base(placa, marca, modelo, ano)
        {
            Cilindradas = CC;
        }

        public override void MostrarInformacoes()
        {
            Console.WriteLine($"Moto: {Marca} {Modelo}, Ano: {Ano}, Placa: {Placa}, Luva: {Cilindradas}");
        }
    }

}
