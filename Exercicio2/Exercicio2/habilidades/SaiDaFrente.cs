using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    public class SaiDaFrente : Habilidade
    {
        private const int Valor = 70;
        private const int DanoMinimo = 110;
        private const double PercentualPontosAtaque = 0.50;

        public SaiDaFrente()
        {
            this.Custo = Valor;
            this.Nome = "Sai da Frente";
        }
        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                this.Dano = DanoMinimo + (poderAtaque * PercentualPontosAtaque);
                this.Custo = Valor;
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
