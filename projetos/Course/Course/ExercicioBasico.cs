// utilizando uma classe sem main (n primaria), apenas para treino

using System.Globalization;

namespace Course;

public class ExercicioBasico
{
    string produto1 = "Computador";
    string produto2 = "Mesa de escritório";

    byte idade = 30;
    int codigo = 100;
    char genero = 'M';
    
    double preco1 = 2100.00;
    double preco2 = 650.50;
    double medida = 53.234567;
    
    Console.WriteLine("Produtos");
    Console.WriteLine("{0}, cujo preco é ${1}", produto1, preco1);
    Console.WriteLine("{0}, cujo preco é ${1}", produto2, preco2);
        
    Console.Write("Registro:")
    Console.WriteLine("{0} anos de idade, código {1} e gênero: {2}, idade, codigo, genero"); 
    
    Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
    Console.WriteLine("Arredondado com tres casas: {0:F3}", medida);
    Console.WriteLine("Separador decimal invariant culture: ", medida.ToString("F3", CultureInfo.InvariantCulture);
    

}