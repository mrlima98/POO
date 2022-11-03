using System;

public class Program{
  public static void Main (string [] args){
    
    double nota1 = 0;
    double nota2 = 0;
    
      do{
      nota1 = double.Parse(Console.ReadLine());
        if(nota1<0 || nota1>10.00){
          Console.WriteLine("nota invalida");
        }
        }while (nota1<0 || nota1>10.00);
    

    do{
      nota2 = double.Parse(Console.ReadLine());
        if(nota2<0 || nota2>10.00){
          Console.WriteLine("nota invalida");
        }
        }while (nota2<0 || nota2>10.00);
    Console.WriteLine($"media = {(nota1+nota2)/2:0.00}");
    
  }
}