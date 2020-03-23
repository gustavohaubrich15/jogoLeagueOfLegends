using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    public class RetaMorte : Habilidade
    {
        private const int Valor = 100;
        private const int DanoMinimo = 275;
        private const double PercentualPontosAtaque = 1.10;
        public RetaMorte()
        {
            this.Custo = Valor;
            this.Nome = "Reta da morte";
        }
        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                this.Dano = DanoMinimo + (poderAtaque * PercentualPontosAtaque);
                Console.WriteLine("Você causou um dano de " + this.Dano + " arremessando seu machado");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
