using Teste.Tecnico.Luby.POO.Models;

namespace Teste.Tecnico.Luby.POO.Contracts
{
    public interface IVendaService
    {
        /// <summary>
        /// Adiciona um item à lista de itens vendidos em uma venda.
        /// </summary>
        /// <param name="produto">Objeto <see cref="ProdutoModel"/> que representa o produto a ser adicionado à venda.</param>
        /// <param name="quantidade">Quantidade do produto a ser adicionada à venda.</param>
        /// <param name="venda">Objeto <see cref="VendaModel"/> que representa a venda atual.</param>
        /// <remarks>
        /// Se o produto já existir na lista de itens vendidos, a quantidade e o valor total do item serão atualizados.  
        /// Caso contrário, um novo item será criado e adicionado à lista de itens vendidos.
        /// </remarks>
        void AdicionarItem(ProdutoModel produto, int quantidade, VendaModel venda);

        /// <summary>
        /// Registra uma venda, adicionando-a à lista de vendas existentes.
        /// </summary>
        /// <param name="venda">Objeto <see cref="VendaModel"/> que representa a venda a ser registrada.</param>
        /// <remarks>
        /// Este método adiciona a venda fornecida ao repositório de vendas armazenado na lista interna.
        /// </remarks>
        void RegistrarVenda(VendaModel venda);

        /// <summary>
        /// Obtém todas as vendas registradas.
        /// </summary>
        /// <returns>
        /// Retorna uma lista de objetos <see cref="VendaModel"/> que representa todas as vendas registradas.
        /// </returns>
        /// <remarks>
        /// Este método retorna o repositório de vendas armazenado na lista interna. 
        /// Caso não haja vendas, será retornada uma lista vazia.
        /// </remarks>
        List<VendaModel> ObterTodasVendas();

        /// <summary>
        /// Exibe os dados detalhados da venda, incluindo os produtos comprados, suas quantidades e o valor total.
        /// </summary>
        /// <param name="venda">
        /// A instância da classe <see cref="VendaModel"/> que contém os itens vendidos e o valor total da compra.
        /// </param>
        /// <remarks>
        /// Este método imprime no console a lista de produtos comprados, incluindo o nome do produto, 
        /// a quantidade comprada e o valor total por item. Ao final, exibe o valor total da compra.
        /// </remarks>
        void ExibirDadosDaVenda(VendaModel venda);

        /// <summary>
        /// Solicita o pagamento de uma venda, permitindo que o usuário insira o valor pago e
        /// calcula se o valor é suficiente ou se é necessário um troco.
        /// </summary>
        /// <param name="venda">
        /// A instância da classe <see cref="VendaModel"/> que contém o valor total da compra.
        /// </param>
        /// <remarks>
        /// O método pede ao usuário para inserir o valor pago. Se o valor for menor que o total da venda,
        /// o valor restante é informado e o usuário é solicitado a pagar novamente. Se o valor pago for maior,
        /// o método calcula e exibe o troco. O loop continua até que o valor pago seja suficiente ou o troco seja calculado.
        /// </remarks>
        void RequisitarPagamento(VendaModel venda);
    }
}
