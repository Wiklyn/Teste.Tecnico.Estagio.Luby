using Teste.Tecnico.Luby.POO.Models;

namespace Teste.Tecnico.Luby.POO.Contracts
{
    public interface IProdutoService
    {
        /// <summary>
        /// Solicita ao usuário que informe o ID do produto desejado para compra e valida a entrada.
        /// </summary>
        /// <param name="estoque">Objeto contendo a lista de produtos disponíveis no estoque.</param>
        /// <param name="idsValidos">Lista de IDs válidos dos produtos disponíveis para compra.</param>
        /// <param name="venda">Objeto que armazena os itens vendidos na transação atual.</param>
        /// <remarks>
        /// O método solicita ao usuário que informe o ID do produto desejado.  
        /// Ele verifica se a entrada é um número inteiro e se o ID informado pertence à lista de produtos disponíveis.  
        /// Caso contrário, exibe mensagens de erro e solicita uma nova entrada até que um ID válido seja informado.
        /// </remarks>
        /// <returns>
        /// Retorna um objeto <see cref="ProdutoModel"/> correspondente ao ID informado pelo usuário.
        /// </returns>
        ProdutoModel RequisitarProdutoDesejado(EstoqueModel estoque, List<int> idsValidos, VendaModel venda);

        /// <summary>
        /// Solicita ao usuário a quantidade desejada de um produto para compra e valida a entrada.
        /// </summary>
        /// <param name="produto">Objeto <see cref="ProdutoModel"/> que representa o produto selecionado.</param>
        /// <remarks>
        /// O método solicita ao usuário que informe a quantidade desejada do produto.  
        /// Ele verifica se a entrada é um número inteiro válido e se a quantidade informada está disponível no estoque.  
        /// Caso contrário, exibe mensagens de erro e solicita uma nova entrada até que uma quantidade válida seja informada.  
        /// A quantidade selecionada é subtraída do estoque do produto.
        /// </remarks>
        /// <returns>
        /// Retorna um número inteiro representando a quantidade do produto escolhida pelo usuário.
        /// </returns>
        int RequisitarQuantidadeDesejada(ProdutoModel produto);
    }
}
