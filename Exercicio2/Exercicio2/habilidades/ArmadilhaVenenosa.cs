using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    public class ArmadilhaVenenosa : Habilidade
    {
        private const int Valor = 400;

        public ArmadilhaVenenosa()
        {
            this.Custo = Valor;
            this.Nome = "Armadilha Venenosa";
        }
        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                Console.WriteLine("Voce colocou uma armadilha com veneno no chão");
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
