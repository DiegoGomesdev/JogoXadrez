using System;

namespace Xadrez.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Enum cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Enum cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
        }
    }
}
