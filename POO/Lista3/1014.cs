using System;

public class Program{
  public static void Main (string [] args){
  double a,b,r;
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());
    r = a/b;

    Console.WriteLine($"{r:0.000} km/l");

    
    
  }
}