using Teste.Tecnico.Luby.POO.Models;

namespace Teste.Tecnico.Luby.POO.Services
{
    public class ProdutoService
    {
        public ProdutoModel RequisitarProdutoDesejado(EstoqueModel estoque, List<int> idsValidos, VendaModel venda)
        {
            if (venda.ItensVendidos.Count == 0)
                Console.Write("\nO que deseja comprar? Por favor, informe o ID do produto: ");
            else
                Console.Write("\nO que mais deseja comprar? Por favor, informe o ID do produto: ");

            int idProduto = -1;
            bool idValido = false;

            while (!idValido)
            {
                if (int.TryParse(Console.ReadLine(), out idProduto))
                {
                    if (idsValidos.Contains(idProduto))
                        idValido = true;
                    else
                        Console.Write("ID inválido. Por favor, informe o ID de algum dos produtos apresentados acima: ");
                }
                else
                    Console.Write("Entrada inválida. Por favor, informe um número inteiro para o ID: ");
            }

            return estoque.Produtos.Where(produto => produto.Id == idProduto).FirstOrDefault(); ;
        }

        public int RequisitarQuantidadeDesejada(ProdutoModel produto)
        {
            Console.Write($"\nQual a quantidade de {produto.Nome} você deseja comprar? ");

            bool quantidadeValida = false;
            int quantidadeProduto = -1;

            while (!quantidadeValida)
            {
                if (int.TryParse(Console.ReadLine(), out quantidadeProduto))
                {
                    if (quantidadeProduto < 0)
                        Console.Write("Por favor, insira um número maior do que zero igual ou inferior à nossa quantidade em estoque: ");
                    if (quantidadeProduto <= produto.Quantidade)
                    {
                        produto.Quantidade -= quantidadeProduto;
                        quantidadeValida = true;
                    }
                    else
                        Console.WriteLine($"\nInfelizmente o nosso estoque não possui a quantidade informada. Possuímos {produto.Quantidade} unidades disponíveis.");
                }
                else
                    Console.Write("Entrada inválida. Por favor, informe um número inteiro para a quantidade: ");
            }

            return quantidadeProduto;
        }
    }
}
