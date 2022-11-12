using System;

class Program{

public static double Circulo (double raio){
  double area;
  area = (Math.Pow(raio,2))*3.14;
  
  return area;
}
  

public static void Main (string [] args){
  double x = double.Parse(Console.ReadLine());
  Console.WriteLine($"area é {Circulo(x):0.00}");
}

  
}