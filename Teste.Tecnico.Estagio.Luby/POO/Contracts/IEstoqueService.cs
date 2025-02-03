using Teste.Tecnico.Luby.POO.Models;

namespace Teste.Tecnico.Luby.POO.Contracts
{
    public interface IEstoqueService
    {
        /// <summary>
        /// Exibe a lista de produtos disponíveis no estoque no formato de tabela.
        /// </summary>
        /// <param name="estoque">O objeto <see cref="EstoqueModel"/> contendo a lista de produtos a serem exibidos.</param>
        /// <remarks>
        /// O método imprime um cabeçalho formatado e, em seguida, lista os produtos com seus respectivos 
        /// IDs, nomes, preços unitários e quantidades disponíveis. Antes de exibir os produtos, ele reinicia 
        /// o contador de IDs da classe <see cref="ProdutoModel"/>.
        /// </remarks>
        void ExibirEstoque(EstoqueModel estoque);

        /// <summary>
        /// Pergunta ao usuário se deseja ver o estoque atualizado e valida a entrada.
        /// </summary>
        /// <returns>
        /// Retorna 'S' caso o usuário deseje ver o estoque atualizado, ou 'N' caso contrário.
        /// </returns>
        /// <remarks>
        /// O método solicita a entrada do usuário em um loop até que uma resposta válida seja fornecida.
        /// São aceitas apenas as opções 'S' ou 'N' (maiúsculas ou minúsculas).
        /// Caso a entrada seja inválida, uma mensagem de erro é exibida e o usuário deve tentar novamente.
        /// </remarks>
        char PerguntarSeDesejaVerOEstoqueAtualizado();
    }
}
