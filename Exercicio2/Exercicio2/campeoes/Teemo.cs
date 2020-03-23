using Exercicio2.habilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    public class Teemo:Campeao
    {
        private const double Vida = 528;
        private const double Mana = 334;
        private const double Ataque = 54;
        private const double Habilidade = 300;
        private const double AumentoVida = 90;
        private const double AumentoMana = 20;
        private const double AumentoAtaque = 54;
        private const double AumentoHabilidade = 20;

        public Teemo()
        {
            this.Nome = "Teemo";
            this.Nivel++;
            this.PontosVida = Vida;
            this.PontosMana = Mana;
            this.PoderAtaque = Ataque;
            this.PoderHabilidade = Habilidade;
            Habilidades = new List<Habilidade>();
            DanoOfuscante danoOfuscante = new DanoOfuscante();
            MoverDepressa moverDepressa = new MoverDepressa();
            TiroToxico tiroToxico = new TiroToxico();
            ArmadilhaVenenosa armadilhaVenenosa = new ArmadilhaVenenosa();
            Habilidades.Add(danoOfuscante);
            Habilidades.Add(moverDepressa);
            Habilidades.Add(tiroToxico);
            Habilidades.Add(armadilhaVenenosa);
        }

        public override void AvancarNivel()
        {
            if (this.Nivel < NivelMaximo)
            {
                this.Nivel++;
                this.PontosVida+=AumentoVida;
                this.PontosMana+=AumentoMana;
                this.PoderAtaque+=AumentoAtaque;
                this.PoderHabilidade+=AumentoHabilidade;
            }
        }

    }
}
