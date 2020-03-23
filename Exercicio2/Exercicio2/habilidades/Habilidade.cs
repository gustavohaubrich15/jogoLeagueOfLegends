using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    public abstract class Habilidade
    {
        public string Nome { get; set; }
        public int Custo { get; set; }
        public double Dano { get; set; }

        public abstract bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade);

    }
}
