using System;

public class Program{

  public static void Main (string [] args){
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double r = (a*b)/12;
    Console.WriteLine($"{r:0.000}");
    
  }
}