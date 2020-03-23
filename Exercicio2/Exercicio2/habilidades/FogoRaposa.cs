using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    public class FogoRaposa : Habilidade
    {
        private const int Valor = 40;
        private const int DanoMinimo = 110;
        private const double PercentualPontosAtaque = 0.30;
        public FogoRaposa()
        {
            this.Custo = Valor;
            this.Nome = "Fogo da Raposa";
        }
        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                this.Dano = DanoMinimo + (poderHabilidade * PercentualPontosAtaque);
                Console.WriteLine("Você causou um dano de " + this.Dano + " liberando 3 fogos de raposa");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
