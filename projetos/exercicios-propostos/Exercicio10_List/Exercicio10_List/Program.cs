using Exercicio10_List;

Console.WriteLine("Diigite quantas pessoas vai inserir: ");
int n = int.Parse(Console.ReadLine());

List<Funcionario> lista = new List<Funcionario>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Digite o ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite o salário: ");
    double salario = double.Parse(Console.ReadLine());
    
    bool teste = lista.Exists(x => x.Id == id);
    if (teste)  
    {
        Console.WriteLine("id duplicado");
        i--;
        continue;
    }
    
    lista.Add(new Funcionario(id, nome, salario));

}

foreach (Funcionario teste in lista)
    Console.WriteLine(teste);

Console.WriteLine("Entre com um id para aumentar o salário:  ");
int idFuncionario = int.Parse(Console.ReadLine());

Funcionario funcionario = lista.FirstOrDefault(funcionario => funcionario.Id == idFuncionario);

if (funcionario != null)
{
    Console.WriteLine("Entre com o percentual de aumento: ");
    double percentual = double.Parse(Console.ReadLine());
    funcionario.AumentarSalario(percentual);
} 
else
    Console.WriteLine("404");

foreach (Funcionario mostrar in lista)
{
    Console.WriteLine(mostrar);    
}

