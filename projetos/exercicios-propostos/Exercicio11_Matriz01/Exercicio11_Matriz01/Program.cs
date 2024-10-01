Console.WriteLine("Digite o número de linhas e colunas: ");
int a = int.Parse(Console.ReadLine());

int[,] matriz = new int[a, a];

for (int i = 0; i < a; i++) // responsavel por percorrer linhas
{
    string[] valores = Console.ReadLine().Split(' ');
    
    for (int j = 0; j < a; j++) // responsavel por percorrer colunas
    {
        matriz[i, j] = int.Parse(valores[j]);
    }
}

Console.WriteLine("Diagonal principal: ");
for (int i = 0; i < a; i++)
{
    Console.Write(matriz[i,i] + " ");
}

Console.WriteLine();

int count = 0;
for (int i = 0; i < a; i++) // estrutura básica para percorrer uma matriz inteira
{
    for (int j = 0; j < a; j++)
    {
        if (matriz[i,j] < 0)
        {
            count++;
        }
    }
}

Console.WriteLine("Numeros negativos: " + count);