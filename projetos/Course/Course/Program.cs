using System;
using System.Globalization;

namespace Course {
    
    class Program {
        
        static void Main(string[] args)
        {

            bool completo = false; // não é boolean
            char genero = 'F';
            byte n1 = 126;
            int n2 = 100;
            int n3 = 233123131;
            long n4 = 4243432423434L;
            float n5 = 4.5323f; // com float, precisamos de colocar o f na frente 
            double n6 = 4.5;
            string nome = "Maria Green"; // não precisa do S maisculo 
            object obj1 = "Alex Green";
            object obj2 = 4.53f;
            
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n5.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}

