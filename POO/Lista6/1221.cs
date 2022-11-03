using System;

public class Program{
public static void Main (string [] args){
  int validacao = 0;
int n = int.Parse(Console.ReadLine());
  
  for(int i=0;i<n;i++){
    int valor = int.Parse(Console.ReadLine());
    
    if (valor%2==0){
      if(valor==2){
        Console.WriteLine("Prime");
      }
      else{
      Console.WriteLine("Not Prime");
      }
    }
    else{
      for (int y=1;y<=valor;y++){
        
        if(valor%y==0){
          validacao+=1;
        }
        if(validacao>=3){
          Console.WriteLine("Not Prime");
          break;
        }
          
        }
      if (validacao<=2){
        Console.WriteLine("Prime");
      }
      validacao = 0;
      }
    }
  }
  
}