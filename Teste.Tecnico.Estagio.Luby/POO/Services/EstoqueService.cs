using Teste.Tecnico.Luby.POO.Contracts;
using Teste.Tecnico.Luby.POO.Models;

namespace Teste.Tecnico.Luby.POO.Services
{
    public class EstoqueService : IEstoqueService
    {
        public void ExibirEstoque(EstoqueModel estoque)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("| ID  | Produto                     | Preço/u  | Quantidade |");
            Console.WriteLine("-------------------------------------------------------------");

            ProdutoModel.ReiniciarContadorId();

            foreach (ProdutoModel produto in estoque.Produtos)
            {
                Console.WriteLine($"| {produto.Id,-3} | {produto.Nome,-27} | {produto.Valor,7:C} | {produto.Quantidade,10} |");
            }

            Console.WriteLine("-------------------------------------------------------------");
        }

        public char PerguntarSeDesejaVerOEstoqueAtualizado()
        {
            char comprarMais = ' ';

            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("\nDeseja ver o estoque atualizado? (S/N): ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && input.Length == 1)
                {
                    comprarMais = char.ToUpper(input[0]);

                    if (comprarMais == 'S' || comprarMais == 'N')
                        entradaValida = true;
                    else
                        Console.WriteLine("Opção inválida! Por favor, digite apenas 'S' para ver o estoque atualizado ou 'N' para encerrar a lista de compras.");
                }
                else
                    Console.WriteLine("Entrada inválida! Por favor, digite apenas um caractere 'S' ou 'N'.");
            }

            return comprarMais;
        }
    }
}
