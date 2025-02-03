using Teste.Tecnico.Luby.POO.Models;

namespace Teste.Tecnico.Luby.POO.Data
{
    public static class BancoDeDadosMockado
    {
        private static EstoqueModel? _estoque;

        public static EstoqueModel ObterEstoqueMockado()
        {
            if (_estoque == null)
            {
                List<ProdutoModel> produtos = [
                new ProdutoModel("Refrigerante de Laranja", 10.99m, 6),
                new ProdutoModel("Energético", 18.50m, 7),
                new ProdutoModel("Suco de Maracujá", 15.75m, 9),
                new ProdutoModel("Café gelado", 25.50m, 0)
                ];

                _estoque = new EstoqueModel { Produtos = produtos };
            }

            return _estoque;
        }
    }
}
