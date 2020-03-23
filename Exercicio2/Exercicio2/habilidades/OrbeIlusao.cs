using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    public class OrbeIlusao : Habilidade
    {
        private const int Valor = 70;
        private const int DanoMinimo = 115;
        private const double PercentualPontosAtaque = 0.35;
        public OrbeIlusao()
        {
            this.Custo = Valor;
            this.Nome = "Orbe da ilusao";
        }
        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                this.Dano = DanoMinimo + (poderHabilidade * PercentualPontosAtaque);
                Console.WriteLine("Você causou um dano de " + this.Dano + " lancando um orbe de poder");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
