namespace Teste.Tecnico.Luby.POO.Models
{
    public class VendaModel
    {
        private static int _contadorId = 1;

        public int Id { get; private set; }
        public ProdutoModel Produto { get; set; }
        public List<ItemVendaModel> ItensVendidos { get; set; } = [];
        public decimal ValorTotal => ItensVendidos.Sum(item => item.ValorTotal);

        public VendaModel()
        {
            Id = _contadorId++;
        }
    }
}
