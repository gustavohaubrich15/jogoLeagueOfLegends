using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    public class Adrenalina : Habilidade
    {
        private const int Valor = 40;
        public Adrenalina()
        {
            this.Custo = Valor;
            this.Nome = "Adrenalina";
        }
        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                Console.WriteLine("Ganhou velocidade de movimento");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
