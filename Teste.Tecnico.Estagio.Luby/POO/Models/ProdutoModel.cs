namespace Teste.Tecnico.Luby.POO.Models
{
    public class ProdutoModel
    {
        private static int _contadorId = 1;

        public int Id { get; private set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }

        public ProdutoModel(string nome, decimal valor, int quantidade)
        {
            Id = _contadorId++;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        // Tive um problema que toda vez que essa classe era instanciada,
        // o Id dos produtos continuava sendo alterado. Então, na primeira
        // vez, os Ids era 1, 2, 3 e 4. Na segunda vez, os IDs era 5, 6, 7 e 8.
        // Para resolver isso, esse método é chamada toda vez que o estoque
        // precisa ser exibido.
        public static void ReiniciarContadorId()
        {
            _contadorId = 1;
        }
    }
}
