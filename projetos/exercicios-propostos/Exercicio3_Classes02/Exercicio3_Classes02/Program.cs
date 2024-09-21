using Exercicio3_Classes02;

Funcionario funcionario = new Funcionario();

var funcionario1 = funcionario;
var funcionario2 = funcionario;

Console.WriteLine("Digite o nome do primeiro funcionário: ");
funcionario1.Nome = Console.ReadLine();
Console.WriteLine("Digite o salário do primeiro funcionário: ");
funcionario1.Salario = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome do segundo funcionário: ");
funcionario2.Nome = Console.ReadLine();
Console.WriteLine("Digite o salário do segundo funcionario: ");
funcionario2.Salario = double.Parse(Console.ReadLine());

double media = (funcionario1.Salario + funcionario2.Salario) / 2;
Console.WriteLine("Salário médio: " + media);
