using System;

public class Program{
  public static void Main (string [] args){
    string [] vetor = Console.ReadLine().Split(' ');
    int a = int.Parse(vetor[0]);
    int b = int.Parse(vetor[1]);
    int c = int.Parse(vetor[2]);
    int d = int.Parse(vetor[3]);
    if(b>c && d>a && c+d>a+b && c>=0 && d>=0 && a%2==0){
      Console.WriteLine("Valores aceito");
    }
      else{
        Console.WriteLine("Valores nao aceito");
      }
    
  }
}