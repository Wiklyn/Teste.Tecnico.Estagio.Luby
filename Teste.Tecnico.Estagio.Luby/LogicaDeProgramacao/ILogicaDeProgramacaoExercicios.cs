namespace Teste.Tecnico.Luby.LogicaDeProgramacao
{
    public interface ILogicaDeProgramacaoExercicios
    {
        /// <summary>
        /// Calcula o fatorial do valor passadoc como parâmetro
        /// </summary>
        /// <param name="numero">O valor a ser calculado o fatorial</param>
        /// <returns>O valor do fatorial calculado</returns>
        int CalcularFatorial(int numero);

        /// <summary>
        /// Calcula o valor total do prêmio utilizando o tipo de prêmio como fator multiplicativo primário.
        /// </summary>
        /// <param name="valorInicial">Valor inicial do prêmio</param>
        /// <param name="tipoDoPremio">Tipo do prêmio. Os tipos permitidos são: "basic", "vip", "premium", "deluxe" e "special"</param>
        /// <param name="fatorDeMultiplicacao">Fatir multiplicativo opcional</param>
        /// <returns>O valor total do prêmio calculado.</returns>
        /// <remarks>
        /// O cálculo do prêmio segue a seguinte lógica:
        /// <list type="bullet">
        ///     <item>É verificado se existe o parâmetro <paramref name="fatorDeMultiplicacao"/> e, caso exista, se este é maior que zero. Caso essa verificação seja positiva, o parâmetro é usado como fator multiplicativo.</item>
        ///     <item>Caso não exista o parâmetro <paramref name="fatorDeMultiplicacao"/>, é verificado se o tipo do prêmio fornecido é válido. Caso seja, este será usado como fator multiplicativo.</item>
        ///     <item>Se o tipo do prêmio não for reconhecido, o valor inicial do prêmio é retornado.</item>
        /// </list>
        /// 
        /// <para><b>ATENÇÃO:</b> O parâmetro <paramref name="valorInicial"/> deve ser maior que zero.
        /// Se um valor menor ou igual a zero for passado, o comportamento da função pode ser inesperado.</para>
        /// </remarks>
        double CalcularPremio(double valorInicial, string tipoDoPremio, double? fatorDeMultiplicacao);

        /// <summary>
        /// Conta a quantidade de números primos até o número informado.
        /// </summary>
        /// <param name="numero">O número até o qual será contado os números primos.</param>
        /// <returns>A quantidade de números primos encontrados até o valor fornecido.</returns>
        /// <remarks>
        /// <list>
        ///     <item>O método verifica a primalidade de todos os números a partir de 2 até o número fornecido.</item>
        ///     <item>Se o número for menor do que 2, retorna 0.</item>
        ///     <item>Para cada número, ele verifica se é divisível por algum número entre 2 e sua raiz quadrada.</item>
        ///     <item>Se for divisível, o número não é primo. Caso contrário, o número é contado como primo.</item>
        /// </list>
        /// </remarks>
        int ContarNumerosPrimos(int numero);

        /// <summary>
        /// Conta o número de vogais no texto fornecido.
        /// </summary>
        /// <param name="texto">O texto no qual as vogais serão contadas.</param>
        /// <returns>O número total de vogais encontradas no texto.</returns>
        /// <remarks>
        /// O método converte o texto para minúsculas e, em seguida, verifica cada caractere para ver se é uma das vogais 
        /// ('a', 'e', 'i', 'o', 'u'). Para cada vogal encontrada, o contador é incrementado.
        /// </remarks>
        int CalcularVogais(string texto);

        /// <summary>
        /// Calcula o valor com o desconto aplicado e o retorna formatado como moeda.
        /// </summary>
        /// <param name="valor">O valor original, formatado como moeda (por exemplo, "R$ 100,00").</param>
        /// <param name="porcentagemDeDesconto">A porcentagem de desconto a ser aplicada (por exemplo, "10%").</param>
        /// <returns>O valor com o desconto aplicado, formatado como moeda (por exemplo, "R$ 90,00").</returns>
        /// <remarks>
        /// O método remove o símbolo de moeda e a porcentagem, converte os valores para números, calcula o desconto 
        /// e retorna o valor com o desconto aplicado, formatado de acordo com a cultura brasileira (pt-BR).
        /// </remarks>
        string CalcularValorComDescontoFormatado(string valor, string porcentagemDeDesconto);

        /// <summary>
        /// Calcula a diferença em dias entre duas datas fornecidas como strings.
        /// </summary>
        /// <param name="primeiraData">A primeira data no formato "ddMMyyyy" (por exemplo, "01012020").</param>
        /// <param name="segundaData">A segunda data no formato "ddMMyyyy" (por exemplo, "01022020").</param>
        /// <returns>O número de dias de diferença entre a segunda data e a primeira data.</returns>
        /// <remarks>
        /// O método recebe duas datas como strings no formato "ddMMyyyy", converte essas strings para objetos 
        /// DateTime e calcula a diferença entre as datas utilizando o método Subtract. O resultado é retornado
        /// como o número de dias de diferença.
        /// </remarks>
        int CalcularDiferencaData(string primeiraData, string segundaData);

        /// <summary>
        /// Obtém os elementos pares de um vetor de números inteiros.
        /// </summary>
        /// <param name="vetor">Um vetor de números inteiros no qual os elementos pares serão extraídos.</param>
        /// <returns>Um vetor contendo os elementos pares presentes no vetor de entrada.</returns>
        /// <remarks>
        /// O método percorre o vetor de entrada, verifica cada elemento e adiciona à lista os números
        /// que são divisíveis por 2 (números pares). Ao final, a lista é convertida para um vetor e retornada.
        /// </remarks>
        int[] ObterElementosPares(int[] vetor);

        /// <summary>
        /// Busca elementos em um vetor de strings que contêm um valor específico.
        /// </summary>
        /// <param name="vetor">Um vetor de strings onde será realizada a busca.</param>
        /// <param name="valor">O valor que será buscado nos elementos do vetor.</param>
        /// <returns>Um vetor contendo todos os elementos que contêm o valor especificado.</returns>
        /// <remarks>
        /// O método percorre o vetor de entrada e retorna um novo vetor contendo todos os elementos
        /// que contêm o valor fornecido como substring. 
        /// <para><b>ATENÇÃO:</b> A busca é sensível a maiúsculas e minúsculas.</para>
        /// </remarks>
        string[] BuscarPessoa(string[] vetor, string valor);

        /// <summary>
        /// Transforma uma string de números separados por vírgula em uma matriz de inteiros.
        /// </summary>
        /// <param name="numeros">Uma string contendo números inteiros separados por vírgula.</param>
        /// <returns>Uma matriz de inteiros, onde cada linha contém até dois números da string fornecida.</returns>
        /// <remarks>
        /// O método divide a string de entrada, convertendo-a em uma lista de números inteiros. Em seguida,
        /// agrupa os números em sublistas de no máximo dois elementos por sublista. Caso o número de elementos
        /// na lista original seja ímpar, a última sublista pode conter apenas um número. Caso a string de
        /// entrada esteja vazia, a lista conterá uma única sublista vazia.
        /// </remarks>
        int[][] TransformarEmMatriz(string numeros);

        /// <summary>
        /// Obtém os elementos que estão em um dos vetores, mas não no outro.
        /// </summary>
        /// <param name="vetor1">O primeiro vetor de inteiros.</param>
        /// <param name="vetor2">O segundo vetor de inteiros.</param>
        /// <returns>Um vetor de inteiros contendo os elementos que estão em vetor1 mas não em vetor2, e os que estão em vetor2 mas não em vetor1.</returns>
        /// <remarks>
        /// O método compara dois vetores e retorna os elementos que são exclusivos de cada um, ou seja,
        /// os elementos que estão presentes em vetor1 mas não em vetor2, e os elementos que estão em vetor2
        /// mas não em vetor1. A ordem dos elementos na saída não é garantida.
        /// </remarks>
        int[] ObterElementosFaltantes(int[] vetor1, int[] vetor2);
    }
}
