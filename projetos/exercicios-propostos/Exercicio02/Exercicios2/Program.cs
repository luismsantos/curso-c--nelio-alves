// EXERCICIO 1 - Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
int numero = int.Parse(Console.ReadLine());

if (numero >= 0)
{
    Console.WriteLine("NÃO NEGATIVO");
} else {
    Console.WriteLine("NEGATIVO");
}



// EXERCICIO 2 - Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("PAR");
}
else
{
    Console.WriteLine("IMPAR");
}



// EXERCICIO 3 - Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
ordem crescente ou decrescente
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a % b == 0 || b % a == 0)
{
    Console.WriteLine("MULTIPLOS");
}
else
{
    Console.WriteLine("NÃO MULTIPLOS");
}



// EXERCICIO 4 - Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas
int horaInicio = int.Parse(Console.ReadLine());
int horaFim = int.Parse(Console.ReadLine());

int duracao;

if (horaInicio < horaFim) {
    duracao = horaFim - horaInicio;
}
else {
    duracao = 24 - horaInicio + horaFim;
}

Console.WriteLine("O JOGO DUROU: " + duracao + " HORA(S)");
