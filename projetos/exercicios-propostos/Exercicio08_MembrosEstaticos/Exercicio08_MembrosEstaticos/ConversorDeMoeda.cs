namespace Exercicio08_MembrosEstaticos;

public class ConversorDeMoeda
{

    public static double IOF = 0.06;
    
    public static double ConverterValor(double dolar, double quantidade)
    {
        double total = quantidade * dolar;
        return total + total * IOF;
    }
}