using System.Globalization;
using Exercicio06;

Funcionario funcionario = new Funcionario();

Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();
Console.Write("Salário bruto: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine(funcionario);

Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine(funcionario);