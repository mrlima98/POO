using System;

public class Program {
  public static void Main (string [] args){
    
    double x1,x2,y1,y2,r;
   
    string [] p1 = Console.ReadLine().Split(' ');
    String [] p2 = Console.ReadLine().Split(' ');

    x1 = double.Parse(p1[0]);
    y1 = double.Parse(p1[1]);
    x2 = double.Parse(p2[0]);
    y2 = double.Parse(p2[1]);
  
    r = Math.Sqrt(Math.Pow(2,x2-x1)+Math.Pow(2,y2-y1));
    Console.WriteLine($"{r:0.0000}");
    
  }
}