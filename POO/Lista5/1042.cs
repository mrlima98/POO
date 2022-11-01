using System;

public class Program{
  public static void Main (string [] args){
    string [] vetor =   Console.ReadLine().Split(' ');
    int a = int.Parse(vetor[0]);
    int b = int.Parse(vetor[1]);
    int c = int.Parse(vetor[2]);
    
    if(a>b && a>c){
      if(b>c){
      Console.WriteLine(c);
      Console.WriteLine(b);
      Console.WriteLine(a);
      Console.WriteLine("\n");
      Console.WriteLine(a);
      Console.WriteLine(b);
      Console.WriteLine(c);
      }
    
    else{
      Console.WriteLine(b);
      Console.WriteLine(c);
      Console.WriteLine(a);
      Console.WriteLine("\n");
      Console.WriteLine(a);
      Console.WriteLine(b);
      Console.WriteLine(c);
    }
    }

    else if(b>a && b>c){
      if(a>c){
      Console.WriteLine(c);
      Console.WriteLine(a);
      Console.WriteLine(b);
      Console.WriteLine("\n");
      Console.WriteLine(a);
      Console.WriteLine(b);
      Console.WriteLine(c);
      }
    
    else{
      Console.WriteLine(a);
      Console.WriteLine(c);
      Console.WriteLine(b);
      Console.WriteLine("\n");
      Console.WriteLine(a);
      Console.WriteLine(b);
      Console.WriteLine(c);
    }
    }
   else if(c>a && c>b){
     if(b>a){
     Console.WriteLine(a);
     Console.WriteLine(b);
     Console.WriteLine(c);
     Console.WriteLine("\n");
     Console.WriteLine(a);
     Console.WriteLine(b);
     Console.WriteLine(c);
     }
   

    else{
      Console.WriteLine(b);
      Console.WriteLine(a);
      Console.WriteLine(c);
      Console.WriteLine("\n");
      Console.WriteLine(a);
      Console.WriteLine(b);
      Console.WriteLine(c);
    }
   }
  }
}