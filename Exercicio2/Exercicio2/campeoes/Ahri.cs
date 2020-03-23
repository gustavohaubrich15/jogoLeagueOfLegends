using Exercicio2.habilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.campeoes
{
    public class Ahri : Campeao
    {
        private const double Vida = 526;
        private const double Mana = 418;
        private const double Ataque = 53;
        private const double Habilidade = 450;
        private const double AumentoVida = 92;
        private const double AumentoMana = 25;
        private const double AumentoAtaque = 3;
        private const double AumentoHabilidade = 22;

        public Ahri()
        {
            this.Nome = "Ahri";
            this.Nivel++;
            this.PontosVida = Vida;
            this.PontosMana = Mana;
            this.PoderAtaque = Ataque;
            this.PoderHabilidade = Habilidade;
            Habilidades = new List<Habilidade>();
            OrbeIlusao orbeIlusao = new OrbeIlusao();
            FogoRaposa fogoRaposa = new FogoRaposa();
            Encanto encanto = new Encanto();
            ImpetoEspiritual impetoEspiritual = new ImpetoEspiritual();
            Habilidades.Add(orbeIlusao);
            Habilidades.Add(fogoRaposa);
            Habilidades.Add(encanto);
            Habilidades.Add(impetoEspiritual);

        }

        public override void AvancarNivel()
        {
            if (this.Nivel < NivelMaximo)
            {
                this.Nivel++;
                this.PontosVida += AumentoVida;
                this.PontosMana += AumentoMana;
                this.PoderAtaque += AumentoAtaque;
                this.PoderHabilidade += AumentoHabilidade;
            }
        }
    }
}
