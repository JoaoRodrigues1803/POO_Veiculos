using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Veiculos
{
    public class SistemaCadastro
    {
        private List<Veiculo> veiculos = new List<Veiculo>();

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
                return;
            }

            Console.WriteLine("Veículos Cadastrados:");
            foreach (var veiculo in veiculos)
            {
                veiculo.MostrarInformacoes();
            }
        }
    }


}
