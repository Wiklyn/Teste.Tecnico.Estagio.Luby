using System.Globalization;

namespace Teste.Tecnico.Estagio.Luby.LogicaDeProgramacao
{
    public class LogicaDeProgramacaoExercicios
    {
        public int CalcularFatorial(int numero)
        {
            int fatorial = 1;

            for (int i = numero; i > 1; i--)
                fatorial *= i;

            return fatorial;
        }

        public double CalcularPremio(double valorInicial, string tipoDoPremio, double? fatorDeMultiplicacao)
        {
            double premioTotal = fatorDeMultiplicacao.HasValue && fatorDeMultiplicacao.Value > 0
                ? valorInicial * fatorDeMultiplicacao.Value
                : tipoDoPremio switch
                {
                    "basic" => valorInicial * 1,
                    "vip" => valorInicial * 1.2,
                    "premium" => valorInicial * 1.5,
                    "deluxe" => valorInicial * 1.8,
                    "special" => valorInicial * 2,
                    _ => valorInicial
                };

            return premioTotal;
        }


        public int ContarNumerosPrimos(int numero)
        {
            if (numero < 2)
                return 0;

            int contadorDeNumerosPrimos = 1;

            for (int i = 3; i <= numero; i++)
            {
                bool numeroPrimo = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        numeroPrimo = false;
                        break;
                    }
                }

                if (numeroPrimo)
                    contadorDeNumerosPrimos++;
            }

            return contadorDeNumerosPrimos;
        }

        public int CalcularVogais(string texto)
        {
            int numeroDeVogais = 0;

            foreach (char letra in texto.ToLower())
            {
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                    numeroDeVogais++;
            }

            return numeroDeVogais;
        }

        public string CalcularValorComDescontoFormatado(string valor, string porcentagemDeDesconto)
        {
            var culture = CultureInfo.CreateSpecificCulture("pt-BR");

            string valorLimpo = valor.Replace("R$", "").Trim();
            double valorNumerico = double.Parse(valorLimpo, culture);

            string descontoLimpo = porcentagemDeDesconto.Replace("%", "").Trim();
            double descontoNumerico = double.Parse(descontoLimpo, culture) / 100;

            var valorComDesconto = valorNumerico * (1 - descontoNumerico);

            return valorComDesconto.ToString("C2", culture);
        }

        public int CalcularDiferencaData(string primeiraData, string segundaData)
        {
            var formatoDasDatas = "ddMMyyyy";
            var culture = CultureInfo.CreateSpecificCulture("pt-BR");

            DateTime primeiraDataFormatada = DateTime.ParseExact(primeiraData, formatoDasDatas, culture);
            DateTime segundaDataFormatada = DateTime.ParseExact(segundaData, formatoDasDatas, culture);

            TimeSpan diferenca = segundaDataFormatada.Subtract(primeiraDataFormatada);

            return diferenca.Days;
        }

        public int[] ObterElementosPares(int[] vetor)
        {
            List<int> listaDeNumerosPares = [];

            foreach (var numero in vetor)
            {
                if (numero % 2 == 0)
                    listaDeNumerosPares.Add(numero);
            }

            return listaDeNumerosPares.Select(sublista => sublista).ToArray();
        }

        public string[] BuscarPessoa(string[] vetor, string valor)
        {
            return vetor.Where(valores => valores.Contains(valor)).ToArray();
        }

        public int[][] TransformarEmMatriz(string numeros)
        {
            if (string.IsNullOrEmpty(numeros))
            {
                List<List<int>> listaVazia = [[]];
                return listaVazia.Select(sublista => sublista.ToArray()).ToArray();
            }

            var arrayDeCaracteres = numeros.Split(',');
            List<int> listaDeNumeros = [];

            for (int i = 0; i < arrayDeCaracteres.Length; i++)
                listaDeNumeros.Add(int.Parse(arrayDeCaracteres[i]));

            int NumeroDeArraysInterno = listaDeNumeros.Count / 2;

            if (listaDeNumeros.Count % 2 != 0)
                NumeroDeArraysInterno++;

            List<List<int>> listaFinal = [];
            int index = 0;

            for (int i = 0; i < NumeroDeArraysInterno; i++)
            {
                listaFinal.Add([]);
                for (int j = index; j < listaDeNumeros.Count; j++)
                {
                    if (j < index + 2)
                        listaFinal[i].Add(listaDeNumeros[j]);
                    else
                    {
                        index += 2;
                        listaFinal[i].ToArray();
                        break;
                    }
                }
            }

            return listaFinal.Select(sublista => sublista.ToArray()).ToArray();
        }

        public int[] ObterElementosFaltantes(int[] vetor1, int[] vetor2)
        {
            var diferencaEntre1e2 = vetor1.Except(vetor2).ToArray();
            var diferencaEntre2e1 = vetor2.Except(vetor1).ToArray();

            return diferencaEntre1e2.Concat(diferencaEntre2e1).Select(sublista => sublista).ToArray();
        }
    }
}
