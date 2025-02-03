namespace Teste.Tecnico.Luby.POO.Contracts
{
    public interface IMenuService
    {
        /// <summary>
        /// Consulta e exibe o estoque atual chamando o serviço responsável por exibir as informações de estoque.
        /// </summary>
        /// <remarks>
        /// O método obtém o estoque de um banco de dados simulado através do método 
        /// <see cref="BancoDeDadosMockado.ObterEstoqueMockado"/> e, em seguida, 
        /// chama o serviço <see cref="_estoqueService.ExibirEstoque"/> para exibir as informações do estoque para o usuário.
        /// </remarks>
        void ConsultarEstoque();

        /// <summary>
        /// Realiza o processo completo de compra de produtos, incluindo a consulta ao estoque, seleção de produtos, 
        /// adição ao carrinho de compras, exibição dos dados da venda, e o registro da compra finalizada.
        /// </summary>
        /// <remarks>
        /// O método interage com o estoque simulado e permite ao usuário escolher produtos, 
        /// definir a quantidade desejada e continuar comprando até que o usuário opte por encerrar. 
        /// O valor da venda é calculado, e o pagamento é requisitado do usuário.
        /// Após a compra, os dados da venda são exibidos e a venda é registrada no sistema.
        /// </remarks>
        void RealizarCompra();

        /// <summary>
        /// Consulta e exibe todas as vendas registradas no sistema, incluindo o ID e o valor total de cada venda.
        /// Também exibe a quantidade total de vendas e o valor total acumulado das vendas.
        /// </summary>
        /// <remarks>
        /// O método recupera todas as vendas registradas, exibe informações detalhadas sobre cada venda e 
        /// fornece um resumo com a quantidade total de vendas e o valor total acumulado de todas as vendas.
        /// </remarks>
        void ConsultarVendas();
    }
}
