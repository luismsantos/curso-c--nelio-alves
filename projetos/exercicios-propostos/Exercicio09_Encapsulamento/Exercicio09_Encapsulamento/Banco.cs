using System.Globalization;

namespace Exercicio09_Encapsulamento;

public class Banco
{
    public string Nome { get; set; }
    public int Conta { get; }
    public double Saldo { get; private set; } = 0;

    public Banco(int conta, string nome)
    {
        Nome = nome;
        Conta = conta;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor) //cobra 5 reais de taxa
    {
        Saldo -= valor + 5.0;
    }

    public override string ToString()
    {
        return "Dados da conta: " + "\nConta: " +  Conta + " \nTitular: " + Nome + " \nSaldo: R$"+ Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }
}

