# Teste Técnico

Esta é a minha resolução do teste técnico para a vaga de Estágio em
Desenvolvimento da empresa Luby Software.

## Índice

- [Estrutura do projeto](#estrutura-do-projeto)
  - [Lógica de Programação](#lógica-de-programação)
  - [SQL](#sql)
  - [Desafio em Orientação a Objetos](#desafio-em-orientação-a-objetos)
- [Funcionamento do projeto](#funcionamento-do-projeto)
  - [Testes para a seção de Lógica de Programação](#testes-para-a-seção-de-lógica-de-programação)
  - [Fluxo do Desafio em Orientação a Objetos](#fluxo-do-desafio-em-orientação-a-objetos)
    - [Validações](#validações)
    - [Consultar o estoque](#consultar-o-estoque)
    - [Realizar uma compra](#realizar-uma-compra)
    - [Consultar o total de vendas realizadas](#consultar-o-total-de-vendas-realizadas)

## Estrutura do projeto

Dividi o projeto em diretórios referentes às seções do teste.

```terminal
.
├── README.md                   # Documentação
├── LogicaDeProgramacao         # Primeira seção do teste
├── POO                         # Terceira seção do teste
├── SQL                         # Segunda seção do teste
└── Program.cs                  # Arquivo com o método `Main`
```

### Lógica de Programação

Dividi a primeira seção em três arquivos:

```terminal
├── LogicaDeProgramacao
│   ├── ILogicaDeProgramacaoExercicios.cs
│   ├── LogicaDeProgramacaoExercicios.cs
│   └── LogicaDeProgramacaoTestes.cs
```

- `ILogicaDeProgramacaoExercicios.cs` possui a interface dos métodos propostos.
Decidi fazer assim para poder escrever _XML Documentation Comments_ sem poluir,
de forma desnecessária, o arquivo de implementação.
- `LogicaDeProgramacaoExercicios.cs` possui a implementação dos métodos
propostos.
- `LogicaDeProgramacaoTestes.cs` possui o mais próximo que consegui pensar de
"testes" unitários sem o uso de nenhuma biblioteca. Este arquivo é composto por
um único método, `ExecutarTestes()`, bem longo, com os testes de todos os
métodos.

### SQL

Dividi esta seção em dois arquivos:

```terminal
├── SQL
│   ├── ExerciciosSQL.sql
│   └── TabelasSQL.sql
```

- `ExerciciosSQL.sql` possui o script para resolver os exercícios propostos.
- `TabelasSQL.sql` possui um script que cria e popula as tabelas, de acordo com
o meu entendimento da referência fornecida no arquivo PDF que me foi enviado.

### Desafio em Orientação a Objetos

Estruturei esta seção do teste de forma mais "rebuscada":

```terminal
├── POO
│   ├── Contracts
│   │   ├── IEstoqueService.cs
│   │   ├── IMenuService.cs
│   │   ├── IOperacaoService.cs
│   │   ├── IProdutoService.cs
│   │   └── IVendaService.cs
│   ├── Data
│   │   ├── BancoDeDadosMockado.cs
│   ├── Models
│   │   ├── EstoqueModel.cs
│   │   ├── ItemVendaModel.cs
│   │   ├── ProdutoModel.cs
│   │   └── VendaModel.cs
│   └── Services
│       ├── EstoqueService.cs
│       ├── MenuService.cs
│       ├── OperacaoService.cs
│       └── VendaService.cs
```

- O subdiretório `Contracts` possui interfaces para os serviços implementados.
- O subdiretório `Data` possui um banco de dados mockado e bem simples.
- O subdiretório `Models` possui modelos para representar possíveis tabelas em
um banco de dados real.
- O subdiretório `Services` possui a implementação dos métodos declarados nas
interfaces.

## Funcionamento do projeto

### Testes para a seção de Lógica de Programação

Logo no início do método `Main`, encontrado no arquivo `Program.cs`, você verá
um aviso sobre o uso dos testes feitos para os desafios de Lógica de
Programação:

```cs
static void Main(string[] args)
{
    // LÓGICA DE PROGRAMAÇÃO ------------------------------------------

    // "Simulando" testes unitários dos exercícios de lógica de
    // programação.
    // Para visualizar as comparações feitas, é recomendado descomentar
    // a linha 18 e comentar todas as outras linhas de código abaixo
    // dela.

    // LogicaDeProgramacaoTestes.ExecutarTestes();
    
    // o método continua ...
}
```

Após descomentar a linha 17 e comentar o restante das linhas de código do método
`Main`, basta executar o projeto. Você verá, no terminal, as comparações usadas
como testes.

```terminal
CalcularFatorial(0) == 1 ? True
CalcularFatorial(1) == 1 ? True
CalcularFatorial(2) == 2 ? True
CalcularFatorial(5) == 120 ? True

CalcularPremio(100, "vip", null) == 120.00 ? True
CalcularPremio(100, "vip", 3) == 300.00 ? True
CalcularPremio(100, "basic", null) == 100.00 ? True
CalcularPremio(100, "premium", null) == 150.00 ? True
CalcularPremio(100, "deluxe", null) == 180.00 ? True
CalcularPremio(100, "special", null) == 200.00 ? True

...
```

### Fluxo do Desafio em Orientação a Objetos

Ao executar o projeto com o código descomentado da linhas 25 em diante, do
método `Main`, Você irá ver a seguinte mensagem no terminal:

```terminal
Bem-vindo à Vending Machine. O que deseja fazer?

1. Consultar o estoque.
2. Realizar uma compra.
3. Consultar o total de vendas realizadas.

Insira o número da opção que deseja executar:
```

#### Validações

Caso você insira um valor não numérico

```terminal
Insira o número da opção que deseja executar: l   # Caractere 'l' inserido
```

você receberá a mensagem:

```terminal
Entrada inválida. Por favor, informe um número inteiro para a opção:
```

Caso você insira um valor numérico, mas que não representa uma das opções
apresentadas

```terminal
Entrada inválida. Por favor, informe um número inteiro para a opção: 5   # Número 5 inserido
```

você receberá a mensagem:

```terminal
Opção inválida. Por favor, informe o número de alguma das opções apresentadas acima:
```

Essas verificações irão acontecer até um valor válido ser inserido.

**OBS: Essas validações acontecem em todos os momentos em que é necessária a
inserção de algum valor pelo usuário.**

#### Consultar o estoque

Quando a opção **1** é selecionada, o estoque é exibido seguido pela
possibilidade de selecionar outra opção, ou encerrar o programa.

```terminal
-------------------------------------------------------------
| ID  | Produto                     | Preço/u  | Quantidade |
-------------------------------------------------------------
| 1   | Refrigerante de Laranja     | R$ 10,99 |          6 |
| 2   | Energético                  | R$ 18,50 |          7 |
| 3   | Suco de Maracujá            | R$ 15,75 |          9 |
| 4   | Café gelado                 | R$ 25,50 |          0 |
-------------------------------------------------------------

Deseja executar outra opcao? (S/N):
```

Caso você digite `'S'`, ou `'s'` (estas validações são _case insensitive_), o
menu de opções irá aparecer novamente para você. Se optar por encerrar o
programa, digitando `'N'` ou `'n'`, você reberá a mensagem:

```terminal
Deseja executar outra opcao? (S/N): n   # Caractere 'n' inserido

Agradecemos a sua presença. Volte sempre!
```

#### Realizar uma compra

Quando a opção **2** é selecionada, o estoque é exibido seguido pela seguinte
pergunta:

```terminal
-------------------------------------------------------------
| ID  | Produto                     | Preço/u  | Quantidade |
-------------------------------------------------------------
| 1   | Refrigerante de Laranja     | R$ 10,99 |          6 |
| 2   | Energético                  | R$ 18,50 |          7 |
| 3   | Suco de Maracujá            | R$ 15,75 |          9 |
| 4   | Café gelado                 | R$ 25,50 |          0 |
-------------------------------------------------------------

O que deseja comprar? Por favor, informe o ID do produto:
```

Digamos que você opte por comprar "Refrigerante de Laranja":

```terminal
-------------------------------------------------------------
| ID  | Produto                     | Preço/u  | Quantidade |
-------------------------------------------------------------
| 1   | Refrigerante de Laranja     | R$ 10,99 |          6 |
| 2   | Energético                  | R$ 18,50 |          7 |
| 3   | Suco de Maracujá            | R$ 15,75 |          9 |
| 4   | Café gelado                 | R$ 25,50 |          0 |
-------------------------------------------------------------

O que deseja comprar? Por favor, informe o ID do produto: 1   # Número 1 inserido

Qual a quantidade de Refrigerante de Laranja você deseja comprar?
```

Agora você precisa inserir a quantidade que deseja comprar. Essa quantidade deve
ser maior que zero e menor ou igual à quantidade disponível no estoque. Caso use
valores fora destas condições, o programa lhe informará e pedirá que você insira
um valor válido.

Quando você inserir um valor válido, como 2, por exemplo

```terminal
Qual a quantidade de Refrigerante de Laranja você deseja comprar? 2   # Número 2 inserido
```

o programa lhe dará a opção de adicionar
mais itens à sua compra atual:

```terminal
Deseja comprar mais algum produto? (S/N):
```

Caso você opte por adicionar mais itens

```terminal
Deseja comprar mais algum produto? (S/N): s   # Caractere 's' inserido
```

você poderá escolher ver o estoque atualizado:

```terminal
Deseja ver o estoque atualizado? (S/N):
```

Inserindo o valor `'s'`, temos:

```terminal
-------------------------------------------------------------
| ID  | Produto                     | Preço/u  | Quantidade |
-------------------------------------------------------------
| 1   | Refrigerante de Laranja     | R$ 10,99 |          4 |   # A quantidade anterior era 6
| 2   | Energético                  | R$ 18,50 |          7 |
| 3   | Suco de Maracujá            | R$ 15,75 |          9 |
| 4   | Café gelado                 | R$ 25,50 |          0 |
-------------------------------------------------------------

O que mais deseja comprar? Por favor, informe o ID do produto:
```

Note que a quantidade de "Refrigerante de Laranja" disponível diminuiu por conta
das duas unidades que estão na sua compra.

Daqui em diante o processo se repete até que você opte por não comprar nenhum
outro produto. Digamos que você tenha adicionado outra unidade de "Refrigerante
de Laranja" à sua compra. Quando você digitar `'n'` na pergunta

```terminal
Deseja comprar mais algum produto? (S/N): n   # Caractere 'n' inserido
```

você reberá a mensagem:

```terminal
A sua lista de compras é:
- Produto: Refrigerante de Laranja, Quantidade: 3, Valor: R$ 32,97.

O valor total da compra é R$ 32,97.
Digite o valor do pagamento:
```

Caso você digite um valor inferior ao valor total da compra

```terminal
Digite o valor do pagamento: 30   # Número 30 inserido
```

você receberá uma mensagem informando o quanto falta para o valor total:

```terminal
O valor pago não cubriu o valor total da compra. Por favor, insira o valor restante (R$ 2,97):
```

E caso você digite um valor superior ao valor que (ainda) está devendo

```terminal
O valor pago não cubriu o valor total da compra. Por favor, insira o valor restante (R$ 2,97): 5   # Número 5 inserido
```

você receberá uma mensagem informando o seu troco:

```terminal
Aqui está o seu troco: R$ 2,03

Deseja executar outra opcao? (S/N):
```

Suponhamos que você deseja executar outra opção. Por tanto, você digita `'s'` e
escolhe, novamente, realizar uma compra. Nesta compra, você decidiu comprar uma
unidade de "Suco de Maracujá":

```terminal
-------------------------------------------------------------
| ID  | Produto                     | Preço/u  | Quantidade |
-------------------------------------------------------------
| 1   | Refrigerante de Laranja     | R$ 10,99 |          3 |
| 2   | Energético                  | R$ 18,50 |          7 |
| 3   | Suco de Maracujá            | R$ 15,75 |          9 |
| 4   | Café gelado                 | R$ 25,50 |          0 |
-------------------------------------------------------------

O que deseja comprar? Por favor, informe o ID do produto: 3   # Número 3 inserido

Qual a quantidade de Suco de Maracujá você deseja comprar? 1   # Número 1 inserido

Deseja comprar mais algum produto? (S/N):
```

E só isso. Portanto, você digita `'n'` para a pergunta acima.

```terminal
Deseja comprar mais algum produto? (S/N): n   # Caractere 'n' inserido

A sua lista de compras é:
- Produto: Suco de Maracujá, Quantidade: 1, Valor: R$ 15,75.

O valor total da compra é R$ 15,75.
Digite o valor do pagamento:
```

Dessa vez, você coloca o dinheiro exato para pagar a conta

```terminal
A sua lista de compras é:
- Produto: Suco de Maracujá, Quantidade: 1, Valor: R$ 15,75.

O valor total da compra é R$ 15,75.
Digite o valor do pagamento: 15,75   # Número 15,75 inserido

Deseja executar outra opcao? (S/N):
```

e decide que quer executar a opção de "Consultar o total de vendas realizadas".

#### Consultar o total de vendas realizadas

Quando você escolhe esta opção, você recebe uma mensagem informando o valor de
cada venda e o valor total de todas as vendas realizadas:

```terminal
O que deseja fazer?

1. Consultar o estoque.
2. Realizar uma compra.
3. Consultar o total de vendas realizadas.

Insira o número da opção que deseja executar: 3   # Número 3 inserido

ID: 1, Valor: 32,97   # Identificador e valor da primeira venda realizada
ID: 2, Valor: 15,75   # Identificador e valor da segunda venda realizada
Quantidade total de vendas: 2, Valor total de vendas: R$ 48,72

Deseja executar outra opcao? (S/N):
```

Quando o programa é encerrado, todas as alterações são perdidas.
