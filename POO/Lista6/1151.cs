using System;

public class Program{
  public static void Main (string [] args){
    
    int n_anterior = 0;
    int n_atual = 1;
    int i = 0;
    int n = int.Parse(Console.ReadLine());
    Console.Write(n_anterior+" ");
    Console.Write(n_atual+" ");
    for (i=0;i<n-3;i++){
      int num = n_anterior+n_atual;
      Console.Write(num+" ");
      n_anterior = n_atual;
      n_atual= num;
    }
    Console.WriteLine(n_anterior+n_atual);
    
  }
}