using Teste.Tecnico.Luby.POO.Contracts;
using Teste.Tecnico.Luby.POO.Models;

namespace Teste.Tecnico.Luby.POO.Services
{
    public class VendaService : IVendaService
    {
        private static List<VendaModel> _vendas = [];

        public void AdicionarItem(ProdutoModel produto, int quantidade, VendaModel venda)
        {
            var itemExistente = venda.ItensVendidos.FirstOrDefault(item => item.Produto.Id == produto.Id);

            if (itemExistente != null)
            {
                itemExistente.Quantidade += quantidade;
                itemExistente.ValorTotal = itemExistente.Produto.Valor * itemExistente.Quantidade;
            }
            else
            {
                var item = new ItemVendaModel(produto, quantidade);
                venda.ItensVendidos.Add(item);
            }
        }


        public void RegistrarVenda(VendaModel venda)
        {
            _vendas.Add(venda);
        }

        public List<VendaModel> ObterTodasVendas()
        {
            return _vendas;
        }

        public void ExibirDadosDaVenda(VendaModel venda)
        {
            Console.WriteLine();
            Console.WriteLine("A sua lista de compras é:");

            foreach (var produto in venda.ItensVendidos)
                Console.WriteLine($"- Produto: {produto.Produto.Nome}, Quantidade: {produto.Quantidade}, Valor: {produto.ValorTotal,5:C}.");

            Console.WriteLine($"\nO valor total da compra é {venda.ValorTotal,5:C}.");
        }

        public void RequisitarPagamento(VendaModel venda)
        {
            decimal valorTotal = venda.ValorTotal;
            Console.Write("Digite o valor do pagamento: ");

            bool quantidadeSuficiente = false;

            while (!quantidadeSuficiente)
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal valorPago))
                {
                    if (valorPago <= 0)
                        Console.Write("Valor inválido! Por favor, insira um valor maior que zero: ");

                    else if (valorPago < valorTotal)
                    {
                        valorTotal -= valorPago;
                        Console.Write($"O valor pago não cubriu o valor total da compra. Por favor, insira o valor restante ({valorTotal,5:C}): ");
                    }

                    else if (valorPago == valorTotal)
                        quantidadeSuficiente = true;

                    else
                    {
                        Console.WriteLine($"\nAqui está o seu troco: {valorPago - valorTotal,5:C}");
                        quantidadeSuficiente = true;
                    }

                }
                else
                    Console.Write("Entrada inválida! Por favor, insira um valor numérico: ");
            }
        }
    }
}
