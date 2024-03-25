using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Q1
{
    class Onibus : Veiculo
    {
        protected int assentos;

        public int Assentos { get => assentos; set => assentos = value; }

        public Onibus(string placa, int ano, int assentos) : base(placa, ano)
        {
            this.assentos = assentos;
        }

        public override double CalcAluguel()
        {
            double valorDiaria;
            valorDiaria = (30 * assentos) - (2024 - ano) * 70;
            return valorDiaria;

        }
    }
}
