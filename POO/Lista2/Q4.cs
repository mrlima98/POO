using System; 

public class Program {

  public static void Main(string[] args) {
    double b, a, h, p, d;
    
    Console.WriteLine("Digite a base: ");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura: ");
    h = double.Parse(Console.ReadLine());
    a = b * h;
    p = (2*b)+(2*h);
    d = 2*(b+h);
    Console.WriteLine($"Area: {a:0.00}");
    Console.WriteLine($"Perimetro: {p:0.00}");
    Console.WriteLine($"Diagonal: {d:0.00}");
    
  }
}