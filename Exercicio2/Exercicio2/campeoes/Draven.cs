using Exercicio2.habilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.campeoes
{
    public class Draven : Campeao
    {
        private const double Vida = 574;
        private const double Mana = 360;
        private const double Ataque = 60;
        private const double Habilidade = 50;
        private const double AumentoVida = 88;
        private const double AumentoMana = 39;
        private const double AumentoAtaque = 3.61;
        private const double AumentoHabilidade = 0.5;

        public Draven()
        {
            this.Nome = "Draven";
            this.Nivel++;
            this.PontosVida = Vida;
            this.PontosMana = Mana;
            this.PoderAtaque = Ataque;
            this.PoderHabilidade = Habilidade;
            Habilidades = new List<Habilidade>();
            RevolucaoMachado revolucaoMachado = new RevolucaoMachado();
            Adrenalina adrenalina = new Adrenalina();
            SaiDaFrente saiDaFrente = new SaiDaFrente();
            RetaMorte retaMorte = new RetaMorte();
            Habilidades.Add(revolucaoMachado);
            Habilidades.Add(adrenalina);
            Habilidades.Add(saiDaFrente);
            Habilidades.Add(retaMorte);

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
