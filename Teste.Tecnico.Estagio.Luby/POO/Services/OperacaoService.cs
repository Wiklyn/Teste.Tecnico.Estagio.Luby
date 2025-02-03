using Teste.Tecnico.Luby.POO.Contracts;

namespace Teste.Tecnico.Luby.POO.Services
{
    public class OperacaoService : IOperacaoService
    {
        public void ApresentarMenuDaMaquina()
        {
            Console.WriteLine("1. Consultar o estoque.");
            Console.WriteLine("2. Realizar uma compra.");
            Console.WriteLine("3. Consultar o total de vendas realizadas.");
            Console.WriteLine();
        }

        public int RequisitarOpcaoDeExecucao()
        {
            Console.Write("Insira o número da opção que deseja executar: ");

            int opcaoEscolhida = -1;

            bool opcaoValida = false;

            while (!opcaoValida)
            {
                if (int.TryParse(Console.ReadLine(), out opcaoEscolhida))
                {
                    if (opcaoEscolhida == 1 || opcaoEscolhida == 2 || opcaoEscolhida == 3)
                        opcaoValida = true;
                    else
                        Console.Write("Opção inválida. Por favor, informe o número de alguma das opções apresentadas acima: ");
                }
                else
                    Console.Write("Entrada inválida. Por favor, informe um número inteiro para a opção: ");
            }

            return opcaoEscolhida;
        }

        public char EscolherOutraOpcao()
        {
            char escolherOutraOpcao = ' ';

            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("\nDeseja executar outra opcao? (S/N): ");

                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && input.Length == 1)
                {
                    escolherOutraOpcao = char.ToUpper(input[0]);

                    if (escolherOutraOpcao == 'S' || escolherOutraOpcao == 'N')
                        entradaValida = true;

                    else
                        Console.Write("Opção inválida! Por favor, digite apenas 'S' para escolher outra opcao do Menu ou 'N' para encerrar o programa: "); ;
                }
                else
                    Console.Write("Entrada inválida! Por favor, digite apenas um caractere 'S' ou 'N': ");
            }

            return escolherOutraOpcao;
        }

        public char PerguntarSeDesejaContinuarComprando()
        {
            char comprarMais = ' ';

            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("\nDeseja comprar mais algum produto? (S/N): ");

                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && input.Length == 1)
                {
                    comprarMais = char.ToUpper(input[0]);

                    if (comprarMais == 'S' || comprarMais == 'N')
                        entradaValida = true;
                    else
                        Console.Write("Opção inválida! Por favor, digite apenas 'S' para comprar mais um produto ou 'N' para encerrar a lista de compras: ");
                }
                else
                    Console.Write("Entrada inválida! Por favor, digite apenas um caracteres 'S' ou 'N': ");
            }

            return comprarMais;
        }
    }
}
