using Teste.Tecnico.Estagio.Luby.LogicaDeProgramacao;

namespace Teste.Tecnico.Luby.LogicaDeProgramacao
{
    public static class LogicaDeProgramacaoTestes
    {
        /// <summary>
        /// Executa testes no console. Para usar o método, basta descomentá-lo
        /// no arquivo `Program.cs`.
        /// </summary>
        /// <remarks>
        /// <list>
        ///     <item>Utilizei somente testes que resultam em `True`.</item>
        ///     <item>Utilizei a sintaxe de criação de arrays apresentada no documento PDF que me foi enviado, mas sei que a sintaxe pode ser simplificada.</item>
        ///     <item>As comparações dos valores nos arrays foram feitas com o método `SequenceEqual()`, pois o uso de `==` compara o endereço de memória.</item>
        /// </list>
        /// </remarks>
        public static void ExecutarTestes()
        {
            var exercicios = new LogicaDeProgramacaoExercicios();

            // CalcularFatorial ----------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(
                $"CalcularFatorial(0) == 1 ?" +
                $" {exercicios.CalcularFatorial(0) == 1}");

            Console.WriteLine(
                $"CalcularFatorial(1) == 1 ?" +
                $" {exercicios.CalcularFatorial(1) == 1}");

            Console.WriteLine(
                $"CalcularFatorial(2) == 2 ?" +
                $" {exercicios.CalcularFatorial(2) == 2}");

            Console.WriteLine(
                $"CalcularFatorial(5) == 120 ?" +
                $" {exercicios.CalcularFatorial(5) == 120}");

            Console.WriteLine();

            // CalcularPremio ------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(
                $"CalcularPremio(100, \"vip\", null) == 120.00 ?" +
                $" {exercicios.CalcularPremio(100, "vip", null) == 120.00}");

            Console.WriteLine(
                $"CalcularPremio(100, \"vip\", 3) == 300.00 ?" +
                $" {exercicios.CalcularPremio(100, "vip", 3) == 300.00}");

            Console.WriteLine(
                $"CalcularPremio(100, \"basic\", null) == 100.00 ?" +
                $" {exercicios.CalcularPremio(100, "basic", null) == 100.00}");

            Console.WriteLine(
                $"CalcularPremio(100, \"premium\", null) == 150.00 ?" +
                $" {exercicios.CalcularPremio(100, "premium", null) == 150.00}");

            Console.WriteLine(
                $"CalcularPremio(100, \"deluxe\", null) == 180.00 ?" +
                $" {exercicios.CalcularPremio(100, "deluxe", null) == 180.00}");

            Console.WriteLine(
                $"CalcularPremio(100, \"special\", null) == 200.00 ?" +
                $" {exercicios.CalcularPremio(100, "special", null) == 200}");

            Console.WriteLine();

            // ContarNumerosPrimos -------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(
                $"ContarNumerosPrimos(1) == 0 ?" +
                $" {exercicios.ContarNumerosPrimos(1) == 0}");

            Console.WriteLine(
                $"ContarNumerosPrimos(2) == 1 ?" +
                $" {exercicios.ContarNumerosPrimos(2) == 1}");

            Console.WriteLine(
                $"ContarNumerosPrimos(3) == 2 ?" +
                $" {exercicios.ContarNumerosPrimos(3) == 2}");

            Console.WriteLine(
                $"ContarNumerosPrimos(5) == 3 ?" +
                $" {exercicios.ContarNumerosPrimos(5) == 3}");

            Console.WriteLine(
                $"ContarNumerosPrimos(7) == 4 ?" +
                $" {exercicios.ContarNumerosPrimos(7) == 4}");

            Console.WriteLine(
                $"ContarNumerosPrimos(10) == 4 ?" +
                $" {exercicios.ContarNumerosPrimos(10) == 4}");

            Console.WriteLine();

            // CalcularVogais -------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(
                $"CalcularVogais(\"Luby Software\") == 4 ?" +
                $" {exercicios.CalcularVogais("Luby Software") == 4}");

            Console.WriteLine(
                $"CalcularVogais(\"Luby\") == 1 ?" +
                $" {exercicios.CalcularVogais("Luby") == 1}");

            Console.WriteLine(
                $"CalcularVogais(\"Software\") == 3 ?" +
                $" {exercicios.CalcularVogais("Software") == 3}");

            Console.WriteLine(
                $"CalcularVogais(\"Vogal\") == 2 ?" +
                $" {exercicios.CalcularVogais("Vogal") == 2}");

            Console.WriteLine(
                $"CalcularVogais(\"Sm Vgl\") == 0 ?" +
                $" {exercicios.CalcularVogais("Sm Vgl") == 0}");

            Console.WriteLine();

            // CalcularValorComDescontoFormatado ----------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(
                $"CalcularValorComDescontoFormatado(\"R$ 6.800,00\", \"30%\") == \"R$ 4.760,00\" ?" +
                $" {exercicios.CalcularValorComDescontoFormatado("R$ 6.800,00", "30%") == "R$ 4.760,00"}");

            Console.WriteLine(
                $"CalcularValorComDescontoFormatado(\"R$ 1.000,00\", \"0.05%\") == \"R$ 950,00\" ?" +
                $" {exercicios.CalcularValorComDescontoFormatado("R$ 1.000,00", "0.05%") == "R$ 950,00"}");

            Console.WriteLine(
                $"CalcularValorComDescontoFormatado(\"R$ 1.000,00\", \"0%\") == \"R$ 1.000,00\" ?" +
                $" {exercicios.CalcularValorComDescontoFormatado("R$ 1.000,00", "0%") == "R$ 1.000,00"}");

            Console.WriteLine(
                $"CalcularValorComDescontoFormatado(\"R$ 1.000,00\", \"100%\") == \"R$ 0,00\" ?" +
                $" {exercicios.CalcularValorComDescontoFormatado("R$ 1.000,00", "100%") == "R$ 0,00"}");

            Console.WriteLine();

            // CalcularDiferencaData ------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(
                $"CalcularDiferencaData(\"10122020\", \"10122020\") == 0 ?" +
                $" {exercicios.CalcularDiferencaData("10122020", "10122020") == 0}");

            Console.WriteLine(
                $"CalcularDiferencaData(\"10122020\", \"25122020\") == 15 ? " +
                $"{exercicios.CalcularDiferencaData("10122020", "25122020") == 15}");

            Console.WriteLine(
                $"CalcularDiferencaData(\"25122020\", \"10122020\") == -15 ? " +
                $"{exercicios.CalcularDiferencaData("25122020", "10122020") == -15}");

            Console.WriteLine();

            // ObterElementosPares -------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(
                $"ObterElementosPares(new int[] {{ 1, 2, 3, 4, 5 }}) == [2, 4] ? " +
                $"{exercicios.ObterElementosPares(new int[] { 1, 2, 3, 4, 5 }).SequenceEqual([2, 4])}");

            Console.WriteLine(
                $"ObterElementosPares(new int[] {{ }}) == [ ] ? " +
                $"{exercicios.ObterElementosPares(new int[] { }).SequenceEqual([])}");

            Console.WriteLine(
                $"ObterElementosPares(new int[] {{ 1, 3, 5, 7, 9 }}) == [ ] ? " +
                $"{exercicios.ObterElementosPares(new int[] { 1, 3, 5, 7, 9 }).SequenceEqual([])}");

            Console.WriteLine(
                $"ObterElementosPares(new int[] {{ 2, 4, 6, 8, 10 }}) == [ 2, 4, 6, 8, 10 ] ? " +
                $"{exercicios.ObterElementosPares(new int[] { 2, 4, 6, 8, 10 }).SequenceEqual([2, 4, 6, 8, 10])}");

            Console.WriteLine();

            // BuscarPessoa --------------------------------------------------------------------------------------------------------------------------------------------
            string[] vetor = new string[] { "John Doe", "Jane Doe", "Alice Jones", "Bobby Louis", "Lisa Romero" };

            Console.WriteLine($"string[] vetor = new string[] {{ \"John Doe\", \"Jane Doe\", \"Alice Jones\", \"Bobby Louis\", \"Lisa Romero\" }}");

            Console.WriteLine(
                $"BuscarPessoa(vetor, \"Doe\") == new string[] {{ \"John Doe\", \"Jane Doe\" }} ? " +
                $"{exercicios.BuscarPessoa(vetor, "Doe").SequenceEqual(new string[] { "John Doe", "Jane Doe" })}");

            Console.WriteLine(
                $"BuscarPessoa(vetor, \"Alice\") == new string[] {{ \"Alice Jones\" }} ? " +
                $"{exercicios.BuscarPessoa(vetor, "Alice").SequenceEqual(new string[] { "Alice Jones" })}");

            Console.WriteLine(
                $"BuscarPessoa(vetor, \"James\") == new string[] {{  }} ? " +
                $"{exercicios.BuscarPessoa(vetor, "James").SequenceEqual(new string[] { })}");

            Console.WriteLine();

            // TransformarEmMatriz --------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(
                $"TransformarEmMatriz(\"1,2,3,4,5,6\") == new int[][] {{ new int[] {{ 1, 2 }}, new int[] {{ 3, 4 }}, new int[] {{ 5, 6 }} }} ? " +
                $"{exercicios.TransformarEmMatriz("1,2,3,4,5,6").Zip(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } }, (a, b) => a.SequenceEqual(b)).All(x => x)}");

            Console.WriteLine(
                $"TransformarEmMatriz(\"1,2,3,4,5,6\") == new int[][] {{ new int[] {{ 1, 2 }}, new int[] {{ 3, 4 }}, new int[] {{ 5 }} }} ? " +
                $"{exercicios.TransformarEmMatriz("1,2,3,4,5").Zip(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5 } }, (a, b) => a.SequenceEqual(b)).All(x => x)}");

            Console.WriteLine(
                $"TransformarEmMatriz(\"1,2,3,4,5,6\") == new int[][] {{ new int[] {{ 1 }} }} ? " +
                $"{exercicios.TransformarEmMatriz("1").Zip(new int[][] { new int[] { 1 } }, (a, b) => a.SequenceEqual(b)).All(x => x)}");

            Console.WriteLine(
                $"TransformarEmMatriz(\"\") == new int[][] {{ new int[] {{ }} }} ? " +
                $"{exercicios.TransformarEmMatriz("").Zip(new int[][] { new int[] { } }, (a, b) => a.SequenceEqual(b)).All(x => x)}");

            Console.WriteLine();

            // ObterElementosFaltantes --------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(
                $"ObterElementosFaltantes(new int[] {{ 1, 2, 3, 4, 5 }}, new int[] {{ 1, 2, 5 }}) == new int[] {{ 3, 4 }} ? " +
                $"{exercicios.ObterElementosFaltantes(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 5 }).SequenceEqual([3, 4])}");

            Console.WriteLine(
                $"ObterElementosFaltantes(new int[] {{ 1, 4, 5 }}, new int[] {{ 1, 2, 3, 4, 5 }}) == new int[] {{ 2, 3 }} ? " +
                $"{exercicios.ObterElementosFaltantes(new int[] { 1, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }).SequenceEqual([2, 3])}");

            Console.WriteLine(
                $"ObterElementosFaltantes(new int[] {{ 1, 2, 3, 4 }}, new int[] {{ 2, 3, 4, 5 }}) == new int[] {{ 1, 5 }} ?" +
                $" {exercicios.ObterElementosFaltantes(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4, 5 }).SequenceEqual([1, 5])}");

            Console.WriteLine(
                $"ObterElementosFaltantes(new int[] {{ 1, 3, 4, 5 }}, new int[] {{ 1, 3, 4, 5 }}) == new int[] {{ }} ? " +
                $"{exercicios.ObterElementosFaltantes(new int[] { 1, 3, 4, 5 }, new int[] { 1, 3, 4, 5 }).SequenceEqual([])}");

            Console.WriteLine(
                $"ObterElementosFaltantes(new int[] {{ }}, new int[] {{ }}) == new int[] {{ }} ? " +
                $"{exercicios.ObterElementosFaltantes(new int[] { }, new int[] { }).SequenceEqual([])}");
        }
    }
}
