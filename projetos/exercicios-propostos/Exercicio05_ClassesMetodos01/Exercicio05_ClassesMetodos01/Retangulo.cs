using System.Globalization;

namespace Exercicio05_ClassesMetodos01;

public class Retangulo
{
    public double Largura;
    public double Altura;

    public double Area()
    {
        return Largura * Altura;
    }

    public double Perimetro()
    {
        return (Largura + Altura) * 2;
    }
    
    public double Diagonal()
    {
        return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
    }

    public override string ToString()
    {
        return "Area: " + Area().ToString("F2", CultureInfo.InvariantCulture) 
              + " Diagonal: "
              + Diagonal().ToString("F2", CultureInfo.InvariantCulture)
              + " Perimetro: "
              +  Perimetro().ToString("F2", CultureInfo.InvariantCulture);
    }
}