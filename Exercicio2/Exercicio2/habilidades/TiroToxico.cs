using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    public class TiroToxico : Habilidade
    {
        private const int Valor = 0;

        public TiroToxico()
        {
            this.Custo = Valor;
            this.Nome = "Tiro Tóxico";
        }
        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                Console.WriteLine("Envenenou seu Oponente");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
