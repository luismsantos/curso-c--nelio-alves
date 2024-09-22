using System.Globalization;
using Exercicio09_Encapsulamento;

Console.Write("Entre o número da conta: ");
int conta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();

Console.WriteLine("Haverá deposito inicial? (S/N)");
char c = char.Parse(Console.ReadLine().ToUpper());

Banco banco = new Banco(conta,titular);

double deposito;
double saque;

if (c == 'S')
{
    Console.WriteLine("Entre o valor do deposito inicial: ");
    deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    banco.Depositar(deposito);
    Console.WriteLine(banco);

    Console.WriteLine("Entre um valor de depósito: ");
    deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    banco.Depositar(deposito);
    Console.WriteLine(banco);

    Console.WriteLine("Entre um valor de saque: ");
    saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    banco.Sacar(saque);
    Console.WriteLine(banco);
}

if (c == 'N')
{
    Console.WriteLine(banco);

    Console.WriteLine("Entre um valor de depósito: ");
    deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    banco.Depositar(deposito);
    Console.WriteLine(banco);

    Console.WriteLine("Entre um valor de saque: ");
    saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    banco.Sacar(saque);
    Console.WriteLine(banco);
}





