﻿using System.Globalization;
using ClasseTriangulo;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X: ");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triangulo Y: ");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.AreaTrianguo();
double areaY = y.AreaTrianguo();

Console.WriteLine("Area X = " + areaX.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Area Y = " + areaY.ToString("F2", CultureInfo.InvariantCulture));
    
    
