using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    public class Encanto : Habilidade
    {
        private const int Valor = 70;
        private const int DanoMinimo = 120;
        private const double PercentualPontosAtaque = 0.40;
        public Encanto()
        {
            this.Custo = Valor;
            this.Nome = "Encanto";
        }
        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                this.Dano = DanoMinimo + (poderHabilidade * PercentualPontosAtaque);
                Console.WriteLine("Você causou um dano de " + this.Dano + " encantando seu inimigo");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
