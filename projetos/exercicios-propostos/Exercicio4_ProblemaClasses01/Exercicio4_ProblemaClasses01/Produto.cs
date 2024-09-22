using System.Globalization;

namespace Exercicio4_ProblemaClasses01;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarProduto(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void RemoverProduto(int quantidade)
    {
        Quantidade -= quantidade;
    }

    public override string ToString()
    {
        return Nome
               + ", $ "
               + Preco.ToString("F2", CultureInfo.InvariantCulture)
               + ", "
               + Quantidade
               + " unidades, Total: $ "
               + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}