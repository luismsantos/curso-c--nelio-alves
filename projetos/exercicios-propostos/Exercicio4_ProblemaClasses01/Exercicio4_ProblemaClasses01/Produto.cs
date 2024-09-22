using System.Globalization;

namespace Exercicio4_ProblemaClasses01;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;


    public Produto() // construtor padrão (aceita a instanciar o objeto sem os parametros)
    {
        
    }
    
    public Produto(string nome, double preco, int quantidade) // construtor (só aceita instanciar o objeto com os parametros)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public Produto(string nome, double preco) // (sobrecarga - aceita entrar com nome e preco)
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