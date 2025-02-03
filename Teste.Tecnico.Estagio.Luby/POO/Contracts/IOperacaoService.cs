namespace Teste.Tecnico.Luby.POO.Contracts
{
    public interface IOperacaoService
    {
        /// <summary>
        /// Exibe o menu principal da máquina, apresentando as opções disponíveis para o usuário.
        /// </summary>
        /// <remarks>
        /// O menu contém as seguintes opções:
        /// <list type="number">
        ///     <item><description>Consultar o estoque.</description></item>
        ///     <item><description>Realizar uma compra.</description></item>
        ///     <item><description>Consultar o total de vendas realizadas.</description></item>
        /// </list>
        /// 
        /// Esse método apenas exibe o menu na tela e não realiza nenhuma ação com base na escolha do usuário.
        /// </remarks>
        void ApresentarMenuDaMaquina();

        /// <summary>
        /// Solicita ao usuário que informe a opção desejada e valida a entrada.
        /// </summary>
        /// <remarks>
        /// O método exibe uma solicitação para que o usuário insira o número correspondente a uma das opções disponíveis.
        /// Ele verifica se a entrada é um número inteiro válido e se está dentro do intervalo permitido (1 a 3).
        /// Caso contrário, solicita ao usuário que insira um valor válido até que uma entrada correta seja fornecida.
        /// </remarks>
        /// <returns>
        /// Retorna um número inteiro representando a opção escolhida pelo usuário.
        /// Os valores possíveis são:
        /// <list type="number">
        ///     <item><description>Consultar o estoque.</description></item>
        ///     <item><description>Realizar uma compra.</description></item>
        ///     <item><description>Consultar o total de vendas realizadas.</description></item>
        /// </list>
        /// </returns>
        int RequisitarOpcaoDeExecucao();

        /// <summary>
        /// Pergunta ao usuário se deseja executar outra opção do menu e valida a entrada.
        /// </summary>
        /// <remarks>
        /// O método exibe uma mensagem solicitando que o usuário informe 'S' para continuar ou 'N' para encerrar.
        /// Ele garante que a entrada seja válida, aceitando apenas um caractere ('S' ou 'N'),
        /// e faz a conversão para maiúscula para evitar problemas de diferenciação entre maiúsculas e minúsculas.
        /// </remarks>
        /// <returns>
        /// Retorna um caractere representando a escolha do usuário:
        /// <list type="bullet">
        ///     <item><description>'S' - O usuário deseja executar outra opção do menu.</description></item>
        ///     <item><description>'N' - O usuário deseja encerrar o programa.</description></item>
        /// </list>
        /// </returns>
        char EscolherOutraOpcao();

        /// <summary>
        /// Solicita ao usuário se ele deseja continuar comprando mais produtos.
        /// </summary>
        /// <returns>
        /// Retorna um caractere 'S' se o usuário deseja continuar comprando, 
        /// ou 'N' se o usuário deseja encerrar a lista de compras.
        /// </returns>
        /// <remarks>
        /// O método solicita ao usuário para digitar 'S' (Sim) para continuar comprando ou 'N' (Não) 
        /// para encerrar as compras. Se o usuário inserir uma opção inválida, será solicitado novamente 
        /// até que uma resposta válida seja fornecida.
        /// </remarks>
        char PerguntarSeDesejaContinuarComprando();
    }
}
