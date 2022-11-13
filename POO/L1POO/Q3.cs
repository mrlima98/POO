using System;

class Program{

  public static double Viagem(double d, double h, double m){
    double horas, velocidade;
    horas = h + (m/60);
    velocidade = d/horas;

    return velocidade;
    
  }
  

  public static void Main(string [] args){
  double d, h, m;
    Console.WriteLine("Digite a distancia");
    d = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidades de horas");
    h = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de minutos");
    m = double.Parse(Console.ReadLine());

    Console.WriteLine($"A velocidade media é: {Viagem(d,h,m):0.00} k/h");
    
  }
}