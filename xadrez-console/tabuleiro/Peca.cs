﻿
namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.Posicao = null;
            this.Tab = tabuleiro;
            this.Cor = cor;
            this.QteMovimentos = 0;
        }

        public void incrementarMovimentos()
        {
            QteMovimentos++;
        }
    }
}
