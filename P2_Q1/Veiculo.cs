using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Q1
{
    public abstract class Veiculo
    {
        protected string placa;
        protected int ano;

        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }

        protected Veiculo(string placa, int ano)
        {
            this.ano = ano;
            this.placa = placa;
        }

        public abstract double CalcAluguel();
    }
}
