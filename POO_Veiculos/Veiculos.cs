using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Veiculos
{
    public abstract class Veiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        // Construtor base
        // Encapsulamento (a proteção dos dados)
        protected Veiculo(string placa, string marca, string modelo, int ano)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        // Método abstrato que as subclasses devem implementar
        public abstract void MostrarInformacoes();
    }


}
