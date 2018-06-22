namespace tabuleiro {
    class Tabuleiro {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro( int linha, int colunas) { // Definir quantas linhas e colunas tera o tabuleiro
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];   // Criando a matriz de acordo com a quantidade
        }
    }
}
