using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    public class DanoOfuscante : Habilidade
    {
        private const int Valor = 70;
        private const int AcrescimoNivel10 = 20;
        private const int NivelMinimo = 10;
        private const int DanoMinimo = 80;
        private const int DanoMaximo = 215;
        private const double PercentualPontosHabilidade = 0.80;

        public DanoOfuscante()
        {
            this.Custo = Valor;
            this.Nome = "Dano Ofuscante";
        }

        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                if (nivel >= NivelMinimo)
                {
                    this.Custo = Valor + AcrescimoNivel10;
                    this.Dano = DanoMaximo;
                }
                else
                {
                    this.Custo = Valor;
                    this.Dano = DanoMinimo;
                }
                this.Dano += (poderHabilidade * PercentualPontosHabilidade);

                Console.WriteLine("Você causou um dano de " + this.Dano);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
