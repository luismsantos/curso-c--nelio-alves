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
    
    lista.Add(new Funcionario(id, nome, salario)); 
}

Console.WriteLine("Entre com um id para aumentar o salário:  ");
int x = int.Parse(Console.ReadLine());


List<Funcionario> listaFiltro = lista<Funcionario>(x => lista[0] == x);


foreach (Funcionario mostrar in listaFiltro)
{
    Console.WriteLine(mostrar);
}
