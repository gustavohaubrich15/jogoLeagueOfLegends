using Exercicio2.campeoes;
using System;
using System.Collections.Generic;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Campeao> campeoes = new List<Campeao>();
            Teemo teemo = new Teemo();
            Draven draven = new Draven();
            Ahri ahri = new Ahri();
            campeoes.Add(teemo);
            campeoes.Add(draven);
            campeoes.Add(ahri);
            char digitado = '1';
            int campeaoEscolhido = 0;
            int habilidadeEscolhido = 0;

            while (digitado != '5')
            {
                Console.WriteLine("1 - Escolher um Personagem");
                Console.WriteLine("2 - Usar Habilidade");
                Console.WriteLine("3 - Visualizar Status");
                Console.WriteLine("4 - Aumentar Nivel campeao");
                Console.WriteLine("5 - Sair");
                Console.Write("\nDigite uma opcao:");
                digitado = char.Parse(Console.ReadLine());
                switch (digitado)
                {
                    case '1':
                        do
                        {
                            int indice = 1;
                            Console.WriteLine("\n----------Campeoes-------");
                            foreach (Campeao campeao in campeoes)
                            {
                                Console.WriteLine(indice + " ) " + campeao.Nome);
                                indice++;
                            }
                            Console.Write("\nDigite o valor de um campeao:");
                            campeaoEscolhido = int.Parse(Console.ReadLine()) - 1;
                            Console.WriteLine("\n\n");
                        } while (campeaoEscolhido + 1 > campeoes.Count || campeaoEscolhido < 0);
                        break;
                    case '2':
                        do
                        {
                            int indices = 1;
                            Console.WriteLine("\n----------Habilidade-------");
                            foreach (Habilidade habilidade in campeoes[campeaoEscolhido].Habilidades)
                            {
                                Console.WriteLine(indices + " ) " + habilidade.Nome);
                                indices++;
                            }
                            Console.Write("\nDigite o valor de um campeao:");
                            habilidadeEscolhido = int.Parse(Console.ReadLine()) - 1;
                            Console.WriteLine("\n\n");
                        } while (habilidadeEscolhido + 1 > campeoes[campeaoEscolhido].Habilidades.Count || habilidadeEscolhido < 0);
                        if (campeoes[campeaoEscolhido].Habilidades[habilidadeEscolhido].Utilizar(campeoes[campeaoEscolhido].Nivel, campeoes[campeaoEscolhido].PontosVida,
                            campeoes[campeaoEscolhido].PontosMana, campeoes[campeaoEscolhido].PoderAtaque, campeoes[campeaoEscolhido].PoderHabilidade))
                        {

                            campeoes[campeaoEscolhido].PontosMana -= campeoes[campeaoEscolhido].Habilidades[habilidadeEscolhido].Custo;

                        }
                        else
                        {
                            Console.WriteLine("Você nao possui mana suficiente.....");
                        }
                        break;
                    case '3':
                        Console.WriteLine("\n--------Status  " + campeoes[campeaoEscolhido].Nome + " ---------");
                        Console.WriteLine("Nivel - " + campeoes[campeaoEscolhido].Nivel);
                        Console.WriteLine("Pontos de Vida - " + campeoes[campeaoEscolhido].PontosVida);
                        Console.WriteLine("Pontos de Mana - " + campeoes[campeaoEscolhido].PontosMana);
                        Console.WriteLine("Poder de Ataque  - " + campeoes[campeaoEscolhido].PoderAtaque);
                        Console.WriteLine("Poder de Habilidade - " + campeoes[campeaoEscolhido].PoderHabilidade);
                        Console.WriteLine("\n\n");

                        break;
                    case '4':
                        campeoes[campeaoEscolhido].AvancarNivel();
                        Console.WriteLine("\nNivel aumentado para " + campeoes[campeaoEscolhido].Nivel + "\n");
                        break;
                    case '5':
                        Console.WriteLine("Saindo.......");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida...");
                        break;
                }
            }
        }
    }
}
