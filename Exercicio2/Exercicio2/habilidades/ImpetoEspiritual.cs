using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    public class ImpetoEspiritual : Habilidade
    {
        private const int Valor = 100;
        public ImpetoEspiritual()
        {
            this.Custo = Valor;
            this.Nome = "Impeto Espiritual";
        }
        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                Console.WriteLine("Avançou rapidamente em uma direção");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
