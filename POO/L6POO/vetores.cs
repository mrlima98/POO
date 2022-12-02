using System;

public class Program{

  public static void Main (string [] args){
    // adicionar numeros no vetor
    int [] vetor1 = {1,2,3,4,5,6};
    int [] vetor2 = new int [6]{1,2,3,4,5,6};
    int [] vetor3 = new int [6];
     for (int i=0; i<vetor2.Length; i++){
      Console.WriteLine(vetor2[i]);
    }
    
    Console.WriteLine();
    // percorrer o vetor
    foreach (int z in vetor1){
        Console.WriteLine(z);
      }
    //copiando a referencia de um vetor
    int [] v = vetor1;
    
      Console.WriteLine();
    // percorrendo um vetor
    for (int i=0; i<v.Length; i++){
      Console.WriteLine(vetor2[i]);
    }
    Console.WriteLine();
    //percorrendo um vetor
    foreach (int z in vetor3){
        Console.WriteLine(z);
      }

    Console.WriteLine();
    //Copiando 6 elementos no vetor 3 do vetor 2
    Array.Copy(vetor3, vetor2,6);
    foreach (int z in vetor3){
        Console.WriteLine(z);
      }
    Console.WriteLine();


    //Invertendo um vetor
    Array.Reverse(vetor1);
    Console.WriteLine();
   
     foreach (int i in vetor1)
       Console.WriteLine(i);
    
    
  }
}