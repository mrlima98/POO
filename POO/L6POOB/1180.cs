using System;

class Program{

  public static void Main(string [] args){
    
    int n = int.Parse(Console.ReadLine());
    int [] vetor = new int [n];
    for(int i=0 ; i<vetor.Length ; i++){
      vetor [i] = int.Parse(Console.ReadLine());
    }

    int p = 0;
    int v = vetor[0];
    
    for(int i=0 ; i<vetor.Length-1 ; i++){
      if(vetor[i]>vetor[i+1]){
       p =  i+1;
       v = vetor[i+1];
      }
    }
    Console.WriteLine($"Menor valor: {v}");
    Console.WriteLine($"Posicao: {p}");
  }
}