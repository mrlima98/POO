using System;

public class Program{
  public static void Main (string [] args){
  int a,b,c,r1,r2;
    string [] valores = Console.ReadLine().Split(' ');
    a = int.Parse(valores[0]);
    b = int.Parse(valores[1]);
    c = int.Parse(valores[2]);
    r1 = (a+b+Math.Abs(b-a))/2;
    r2 = (r1+c+Math.Abs(r1-c))/2;
      
    Console.WriteLine(r2+" eh o maior");
  }
}