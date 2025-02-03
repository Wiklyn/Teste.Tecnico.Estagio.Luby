using Teste.Tecnico.Luby.LogicaDeProgramacao;
using Teste.Tecnico.Luby.POO.Services;

namespace Teste.Tecnico.Estagio.Luby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LÓGICA DE PROGRAMAÇÃO ------------------------------------------

            // "Simulando" testes unitários dos exercícios de lógica de
            // programação.
            // Para visualizar as comparações feitas, é recomendado descomentar
            // a linha 18 e comentar todas as outras linhas de código abaixo
            // dela.

            // LogicaDeProgramacaoTestes.ExecutarTestes();


            // DESAFIO EM ORIENTAÇÃO A OBJETOS --------------------------------

            // "Simulando" um Container de Injeção de Dependência manualmente,
            // criando as instâncias dos serviços e passando suas dependências.
            var estoqueService = new EstoqueService();
            var produtoService = new ProdutoService();
            var vendaService = new VendaService();
            var operacoesService = new OperacaoService();
            var menuService = new MenuService(
                estoqueService, produtoService, vendaService, operacoesService);

            Console.WriteLine("Bem-vindo à Vending Machine. O que deseja fazer?\n");

            bool continuar = true;

            while (continuar)
            {
                operacoesService.ApresentarMenuDaMaquina();

                int opcao = operacoesService.RequisitarOpcaoDeExecucao();

                if (opcao == 1)
                    menuService.ConsultarEstoque();

                else if (opcao == 2)
                    menuService.RealizarCompra();

                else if (opcao == 3)
                    menuService.ConsultarVendas();

                char escolherOutraOpcao = operacoesService.EscolherOutraOpcao();

                if (escolherOutraOpcao == 'S')
                {
                    Console.WriteLine("\nO que deseja fazer?\n");
                    continuar = true;
                }
                else
                    continuar = false;
            }

            Console.WriteLine($"\nAgradecemos a sua presença. Volte sempre!");
        }
    }
}
