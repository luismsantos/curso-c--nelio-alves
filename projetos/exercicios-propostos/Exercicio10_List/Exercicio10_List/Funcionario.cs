namespace Exercicio10_List;

public class Funcionario
{
    public int Id {get;}
    public string Nome { get; set; }
    public double Salario { get; private set; }

    public Funcionario(int id, string nome, double salario)
    {
        Id = id;
        Nome = nome;
        Salario = salario;
    }

    public void AumentarSalario(double percentual)
    {
        Salario += Salario * (percentual / 100);
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}, Salario: {Salario}";
    }
    
}