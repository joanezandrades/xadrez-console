﻿
namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            this.Posicao = posicao;
            this.Tab = tabuleiro;
            this.Cor = cor;
            this.QteMovimentos = 0;
        }
    }
}
