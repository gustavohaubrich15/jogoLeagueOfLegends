using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    public class MoverDepressa : Habilidade
    {
        private const int Valor = 40;
        public MoverDepressa()
        {
            this.Custo = Valor;
            this.Nome = "Mover Depressa";
        }

        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                Console.WriteLine("Sai em disparada");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
