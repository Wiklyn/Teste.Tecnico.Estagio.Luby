namespace Teste.Tecnico.Luby.POO.Models
{
    public class ItemVendaModel
    {
        public ProdutoModel Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }

        public ItemVendaModel(ProdutoModel produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            ValorTotal = Produto.Valor * Quantidade;
        }
    }
}
