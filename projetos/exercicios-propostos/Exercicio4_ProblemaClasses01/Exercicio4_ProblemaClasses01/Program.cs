using Exercicio4_ProblemaClasses01;

Console.WriteLine("Digite o nome do produto: ");
string nome = Console.ReadLine();
Console.WriteLine("Digite o preço do produto: ");
double preco = double.Parse(Console.ReadLine());

Produto produto = new Produto(nome, preco);

Produto produto2 = new Produto();

Produto produto3 = new Produto // instanciando e inicializando o objeto (funciona sem construtores)
{
    Nome = "TV",
    Preco = 500.00, 
    Quantidade = 20
};

Console.WriteLine("Dados do produto: " + produto);

Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
produto.AdicionarProduto(int.Parse(Console.ReadLine()));
Console.WriteLine("Dados do produto: " + produto);

Console.Write("Digite o número de produtos a ser removido do estoque: ");
produto.RemoverProduto(int.Parse(Console.ReadLine()));
Console.WriteLine("Dados do produto: " + produto);




