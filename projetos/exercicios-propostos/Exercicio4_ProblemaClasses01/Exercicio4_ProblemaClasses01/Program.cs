using System.Threading.Channels;
using Exercicio4_ProblemaClasses01;

Produto produto = new Produto();

Console.WriteLine("Digite o nome do produto: ");
produto.Nome = Console.ReadLine();
Console.WriteLine("Digite o preço do produto: ");
produto.Preco = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade no estoque: ");
produto.Quantidade = int.Parse(Console.ReadLine());
Console.WriteLine("Dados do produto: " + produto);

Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
produto.AdicionarProduto(int.Parse(Console.ReadLine()));
Console.WriteLine("Dados do produto: " + produto);

Console.Write("Digite o número de produtos a ser removido do estoque: ");
produto.RemoverProduto(int.Parse(Console.ReadLine()));
Console.WriteLine("Dados do produto: " + produto);




