# Jogo League Of Legends - Orientação a Objetos em C#

 A equipe de desenvolvedores da Riot Games convidou você para participar de um
projeto do jogo League of Legends. O seu trabalho é implementar as classes
básicas para representar alguns personagens do jogo. Todo campeão possui uma
série de características em comum que são: Nome, nível (1 até 18), pontos de vida,
pontos de mana, poder de ataque, poder de habilidade, além de ter quatro
habilidades especiais. Todo campeão pode avançar de nível e, sempre que isso
acontecer, todos os seus status são aumentados. Toda vez que o jogador utilizar
uma habilidade especial, o programa deve imprimir uma mensagem com o efeito da
habilidade. Toda habilidade tem um custo de mana, se não houver mana suficiente,
a habilidade não pode ser usada. As características de cada campeão podem ser
visualizadas abaixo.


Com estas informações, implemente as classes e/ou interfaces necessárias
para representação dos personagens. No método Main, apresente um menu onde
seja possível escolher um personagem para jogar, usar uma das quatro habilidades
e visualizar os status do campeão.
- ● Teemo
○ Status
■ Vida: 528 (+90/nível)
■ Mana: 334 (+20/nível)
■ P. Ataque: 54 (+3/nível)
■ P. Habilidade: 300 (+20/nível)
○ Habilidades
■ Dardo ofuscante (Custo: 70, 90 depois do nv. 10): Causa
80/215 (depois do nv.10) de dano + 80% do P. Habilidade.
■ Mover depressa (Custo: 40): Teemo sai em disparada
■ Tiro tóxico (Custo: 0): Teemo envenena o seu oponente
■ Armadilha Venenosa (Custo: 400): Teemo coloca uma
armadilha com veneno no chão

● Draven
○ Status
■ Vida: 574 (+88/nível)
■ Mana: 360 (+39/nível)
■ P. Ataque: 60 (+3,61/nível)
■ P. Habilidade: 50 (+0.5/nível)
○ Habilidades
■ Revolução do Machado (Custo: 45): Causa 35+65% do seu P.
Ataque de dano (55+105% do P. Ataque, depois do nv. 10) ao
seu oponente
■ Adrenalina (Custo: 40): Draven ganha velocidade de
movimento
■ Sai da Frente (Custo: 70): Draven arremessa seus machados
e causa 110+50% do seu P.Ataque
■ Reta da Morte (Custo: 100): Draven arremessa seus
machados causando 275+110% do seu P.Ataque


● Ahri
○ Status
■ Vida: 526 (+92/nível)
■ Mana: 418 (+25/nível)
■ P. Ataque: 53 (+3/nível)
■ P. Habilidade: 450 (+22/nível)
○ Habilidades
■ Orbe da ilusão (Custo: 70): Ahri lança um orbe de poder e
causa 115+35% do seu P. Habilidade
■ Fogo da Raposa (Custo: 40): Ahri libera 3 fogos de raposa que
causam 110+30% do seu P. Habilidade
■ Encanto (Custo: 70): Ahri encanta seu inimigo e causa
120+40% do seu P. Habilidade
■ Ímpeto Espiritual (Custo: 100): Ahri avança rapidamente em
uma direção
