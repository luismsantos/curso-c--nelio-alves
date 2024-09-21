using System.Globalization;
using Exercicio05_ClassesMetodos01;

Retangulo retangulo = new Retangulo();

Console.WriteLine("Entre com a largura e altura do retângulo: ");
retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine(retangulo);