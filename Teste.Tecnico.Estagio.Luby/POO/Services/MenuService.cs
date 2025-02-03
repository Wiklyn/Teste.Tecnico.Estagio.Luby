using Teste.Tecnico.Luby.POO.Contracts;
using Teste.Tecnico.Luby.POO.Data;
using Teste.Tecnico.Luby.POO.Models;

namespace Teste.Tecnico.Luby.POO.Services
{
    public class MenuService
    {
        private readonly IEstoqueService _estoqueService;
        public readonly IProdutoService _produtoService;
        private readonly IVendaService _vendaService;
        private readonly IOperacaoService _operacoesService;

        public MenuService(
            IEstoqueService estoqueService,
            IProdutoService produtoService,
            IVendaService vendaService,
            IOperacaoService operacoesService)
        {
            _estoqueService = estoqueService;
            _produtoService = produtoService;
            _vendaService = vendaService;
            _operacoesService = operacoesService;
        }

        public void ConsultarEstoque()
        {
            var estoque = BancoDeDadosMockado.ObterEstoqueMockado();
            _estoqueService.ExibirEstoque(estoque);
        }

        public void RealizarCompra()
        {
            var estoque = BancoDeDadosMockado.ObterEstoqueMockado();
            List<int> idsValidos = estoque.Produtos.Select(produto => produto.Id).ToList();
            VendaModel venda = new();
            ProdutoModel produtoEscolhido;
            char consultarEstoque = 'S';
            bool continuarComprando = true;

            while (continuarComprando)
            {
                if (venda.ItensVendidos.Count == 0)
                    _estoqueService.ExibirEstoque(estoque);
                else
                {
                    consultarEstoque = _estoqueService.PerguntarSeDesejaVerOEstoqueAtualizado();

                    if (consultarEstoque == 'S')
                        _estoqueService.ExibirEstoque(estoque);
                }

                produtoEscolhido = _produtoService.RequisitarProdutoDesejado(estoque, idsValidos, venda);

                if (produtoEscolhido.Quantidade == 0)
                {
                    Console.WriteLine("\nInfelizmente não possuímos unidades disponíveis em estoque do produto escolhido.");
                    continuarComprando = _operacoesService.PerguntarSeDesejaContinuarComprando() == 'S';
                }
                else
                {
                    var quantidadeDeProduto = _produtoService.RequisitarQuantidadeDesejada(produtoEscolhido);

                    _vendaService.AdicionarItem(produtoEscolhido, quantidadeDeProduto, venda);

                    char comprarMais = _operacoesService.PerguntarSeDesejaContinuarComprando();

                    if (comprarMais == 'N')
                        continuarComprando = false;
                }
            }

            _vendaService.ExibirDadosDaVenda(venda);

            _vendaService.RequisitarPagamento(venda);

            _vendaService.RegistrarVenda(venda);
        }

        public void ConsultarVendas()
        {
            var vendas = _vendaService.ObterTodasVendas();
            Console.WriteLine();

            foreach (var venda in vendas)
            {
                Console.WriteLine($"ID: {venda.Id}, Valor: {venda.ValorTotal}");
            }

            Console.WriteLine($"Quantidade total de vendas: {vendas.Count}, Valor total de vendas: {vendas.Sum(venda => venda.ValorTotal),5:C}");
        }
    }
}
