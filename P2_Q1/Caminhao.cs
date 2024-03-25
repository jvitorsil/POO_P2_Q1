using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Q1
{
    class Caminhao : Veiculo
    {
        protected int eixos;

        public int Eixos { get => eixos; set => eixos = value; }
        public Caminhao(string placa, int ano, int eixos) : base(placa, ano)
        {
            this.eixos = eixos;
        }

        public override double CalcAluguel()
        {
            double valorDiaria;
            valorDiaria = (300 * eixos) - (2024 - ano) * 50;
            return valorDiaria;
        }
    }
}
