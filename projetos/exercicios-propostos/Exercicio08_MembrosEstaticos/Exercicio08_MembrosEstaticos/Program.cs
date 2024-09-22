using System.Globalization;
using Exercicio08_MembrosEstaticos;

Console.WriteLine("Qual é a cotação do dolar? ");
double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Quantos dolares você vai comprar? ");
double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.ConverterValor(dolar, quantidade).ToString("F2", CultureInfo.InvariantCulture));

