Console.WriteLine("Digite o numero de linha: ");
int numLinha = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero de coluna: ");
int numColuna = int.Parse(Console.ReadLine());

int[,] matriz = new int[numLinha, numColuna];

for (int i = 0; i < numLinha; i++)
{
    string[] valor = Console.ReadLine().Split(' ');
    
    for (int j = 0; j < numColuna; j++)
    {
        matriz[i, j] = int.Parse(valor[j]);
    }
}

Console.WriteLine("Digite o valor desejado: ");
int valorDesejado = int.Parse(Console.ReadLine());

for (int i = 0; i < numLinha; i++)
{
    for (int j = 0; j < numColuna; j++)
    {
        if (matriz[i, j] == valorDesejado)
        { 
            Console.WriteLine("Posição: " + i + ", " + j + ":");
            if (j > 0)
                Console.WriteLine("Esquerda: " + matriz[i, j - 1]);

            if (i > 0)
                Console.WriteLine("Cima: " + matriz[i - 1, j]);
            
            if (j < numColuna - 1)
                Console.WriteLine("Direita: " + matriz[i, j + 1]);

            if (i < numColuna - 1)
                Console.WriteLine("Baixo: " + matriz[i + 1, j]);
        }
    }
}