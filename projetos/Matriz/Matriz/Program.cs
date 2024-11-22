double [,] matriz = new double[2,3]; // instanciando a matriz na memoria

Console.WriteLine(matriz.Length); // mostra a quantidade de elementos dentro da matriz

Console.WriteLine(matriz.Rank); // mostra o numero de linhas

Console.WriteLine(matriz.GetLength(0)); // imprime a dimensão 1 (numero de linhas) 

Console.WriteLine(matriz.GetLength(1)); // imprime a dimensão 2 (numeros de colunas)