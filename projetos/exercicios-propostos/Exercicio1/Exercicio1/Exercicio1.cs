// EXERCICIO 1 - PROPOSTO POR NÉLIO ALVES
 Console.WriteLine("Escreva dois números: ");

 int numero1;
 int numero2;

 numero1 = int.Parse(Console.ReadLine());
 numero2 = int.Parse(Console.ReadLine());

 int soma = numero1 + numero2;

 Console.WriteLine("A soma é: "+ soma);


 
// EXERCICIO 2
 using System.Globalization;

 Console.WriteLine("Digete o valor do raio de uma círculo: ");
 double raio = double.Parse(Console.ReadLine());

 double resultado = Math.PI * Math.Pow(raio, 2);

 Console.WriteLine("Raio: " + resultado.ToString("F4", CultureInfo.InvariantCulture));



// EXERCICIO 3 - USANDO SPLIT
 Console.WriteLine("Digite os valores: ");
 string[] valores = Console.ReadLine().Split(' ');

 int a = int.Parse(valores[0]);
 int b = int.Parse(valores[1]);
 int c = int.Parse(valores[2]);
 int d = int.Parse(valores[3]);

 int resultado = (a * b) - (c * d);
 Console.WriteLine("Diferença: " + resultado);



// EXERCICIO 4 - USANDO SPLIT
using System.Globalization;

 Console.WriteLine("Digite os dados: ");
 string[] dados = Console.ReadLine().Split(' ');

 int numero = int.Parse(dados[0]);
 int horas = int.Parse(dados[1]);
 double salarioHora = double.Parse(dados[2]);

 double salarioTotal = salarioHora * horas;

 Console.WriteLine($"Numero: {numero} ");
 Console.WriteLine($"Salario: {salarioTotal.ToString("F2",CultureInfo.InvariantCulture)} ");



// EXERCICIO 5 
 using System.Globalization;

 Console.WriteLine("Digite o código, o número e o valor unitário da peça 1: ");
 string[] peca1 = Console.ReadLine().Split(' ');

 int codigo1 = int.Parse(peca1[0]);
 int qtdPeca1 = int.Parse(peca1[1]);
 double valor1 = double.Parse(peca1[2]);

 double valorPeca1 = qtdPeca1 * valor1;

 Console.WriteLine("Digite o código, o número e o valor unitário da peça 1: ");
 string[] peca2 = Console.ReadLine().Split(' ');

 int codigo2 = int.Parse(peca2[0]);
 int qtdPeca2 = int.Parse(peca2[1]);
 double valor2 = double.Parse(peca2[2]);

 double valorPeca2 = qtdPeca2 * valor2;

 double total = valorPeca1 + valorPeca2;

 Console.WriteLine("Valor a pagar: " + total.ToString("F2", CultureInfo.InvariantCulture));



// EXERCICIO 6
using System.Globalization;

Console.WriteLine("Digite três valores: ");
string[] valores = Console.ReadLine().Split(' ');

double a = double.Parse(valores[0]);
double b = double.Parse(valores[1]);
double c = double.Parse(valores[2]);

double triangulo = (a * c) / 2;
double circulo = (Math.Pow(c, 2)) * Math.PI;
double trapezio = ((a + b) * c) / 2;
double quadrado = Math.Pow(b, 2);
double retangulo = a * b;

Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));







