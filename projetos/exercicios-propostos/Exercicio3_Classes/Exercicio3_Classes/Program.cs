using Exercicio3_Classes;

Pessoa pessoa1, pessoa2;

pessoa1 = new Pessoa();
pessoa2 = new Pessoa();

Console.WriteLine("Digite o nome da primeira pessoa: ");
pessoa1.Nome = Console.ReadLine();

Console.WriteLine("Digite a idade da primeira pessoa: ");
pessoa1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("digite o nome da segunda pessoa: ");
pessoa2.Nome = Console.ReadLine();

Console.WriteLine("Digite a idade da segunda pessoa: ");
pessoa2.Idade = int.Parse(Console.ReadLine());


if (pessoa1.Idade > pessoa2.Idade)
{
    Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
}
else
{
    Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
}


