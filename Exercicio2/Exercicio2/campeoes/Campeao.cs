using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    public abstract class Campeao
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public double PontosVida { get; set; }
        public double PontosMana { get; set; }
        public double PoderAtaque { get; set; }
        public double PoderHabilidade { get; set; }

        public List<Habilidade> Habilidades;

        protected const int NivelMaximo = 18;
        
        public virtual void AvancarNivel()
        {
            if (this.Nivel < NivelMaximo)
            {
                this.Nivel++;
                this.PontosVida++;
                this.PontosMana++;
                this.PoderAtaque++;
                this.PoderHabilidade++;
            }
        }


    }
}
