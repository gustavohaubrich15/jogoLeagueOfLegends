using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2.habilidades
{
    class RevolucaoMachado:Habilidade
    {
        private const int Valor = 45;
        private const int NivelMinimo = 10;
        private const int DanoMinimo = 35;
        private const int DanoMaximo = 55;
        private const double PercentualPontosAtaqueMinimo = 0.65;
        private const double PercentualPontosAtaqueMaximo = 1.05;
        public RevolucaoMachado()
        {
            this.Custo = Valor;
            this.Nome = "Revolucao do Machado";
        }
        public override bool Utilizar(int nivel, double pontosVida, double pontosMana, double poderAtaque, double poderHabilidade)
        {
            if (pontosMana >= this.Custo)
            {
                if (nivel >= NivelMinimo)
                {
                    
                    this.Dano = DanoMaximo+(poderAtaque* PercentualPontosAtaqueMaximo);
                }
                else
                {
                    this.Custo = Valor;
                    this.Dano = DanoMinimo + (poderAtaque * PercentualPontosAtaqueMinimo);
                }
                this.Custo = Valor;
                Console.WriteLine("Você causou um dano de " + this.Dano);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
