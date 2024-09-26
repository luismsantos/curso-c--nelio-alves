List<string> lista = new List<string>(); // criando e instanciado a lista

// Adicionando elementos sequenciais
lista.Add("Alex");
lista.Add("Bob");
lista.Add("Charlie");
lista.Add("Ariel");
lista.Add("Edica");
lista.Add("Felix");

// Adicionando elementos por indice
lista.Insert(2, "Marcos");

foreach (string mostrar in lista) {
    Console.WriteLine(mostrar);
}

// Mostra a contagem de elementos dentro da lista
Console.WriteLine("Numero de elementos dentro da lista: " + lista.Count);

// Mostra o primeiro elemento que começa com a letra A
string s1 = lista.Find(x => x[0] == 'A');
Console.WriteLine("Primeiro: " + s1);

// Mostra o ultimo elemento que começa com a letra A
string s2 = lista.FindLast(x => x[0] == 'A');
Console.WriteLine("Segundo: " + s2);

// Mostra a posição do primeiro elemento que começa com A
int pos1 = lista.FindIndex(x => x[0] == 'A');
Console.WriteLine("Primeira posição de quem começa com A: " + pos1);

// Mostra a posição do primeiro elemento que termina com A
int pos2 = lista.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Primeira posição de quem termina com A: " + pos2);

Console.WriteLine("REMOVENDO ALEX ------------------------------");
lista.Remove("Alex");
foreach (string mostrar in lista)
{
    Console.WriteLine(mostrar);
}

Console.WriteLine("REMOVENDO QUEM COMEÇA COM A ---------------");
lista.RemoveAll(x => x[0] == 'A');
foreach (string mostrar in lista)
    Console.WriteLine(mostrar);

Console.WriteLine("REMOVENDO 2 ELEMENTOS A PARTIR DO INDICE 2 --------------");
lista.RemoveRange(2, 2);
foreach (string mostrar in lista)
    Console.WriteLine(mostrar);



// Filtrando a lista, criando uma nova lista que contenha apenas nomes de quem 5 caracteres
List<string> lista2 = lista.FindAll(x => x.Length == 5);
Console.WriteLine("---------------------------------");

foreach (string mostrar in lista2)
{
    Console.WriteLine(mostrar);
}
{
    
}