using System;

public class Program{

  public static void Main(string [] args){
   string [] vetor = Console.ReadLine().Split(' ');
   double a = double.Parse(vetor[0]);
    double b = double.Parse(vetor[1]);
    double c = double.Parse(vetor[2]);
    double r = ((a*c)/2);
    Console.WriteLine($"TRIANGULO: {r:0.000}");
    r = 3.14159*(Math.Pow(c,2));
    Console.WriteLine($"CIRCULO: {r:0.000}");
    r = ((a+b)*c)/2;
    Console.WriteLine($"TRAPEZIO: {r:0.000}");
    r = b*b;
    Console.WriteLine($"QUADRADO: {r:0.000}");
    r = a*b;
    Console.WriteLine($"RETANGULO: {r:0.000}");
  }

}