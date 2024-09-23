// Faça um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor
// Em seguida, mostrar a altura médicas dessas pessoas.

using System.Globalization;

int n = int.Parse(Console.ReadLine());

double[] vetor = new double[n];

for (int i = 0; i < n; i++)
{
    vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double soma = 0;

for (int i = 0; i < n; i++)
{
    soma += vetor[i];
}

double media = vetor.Average();
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));