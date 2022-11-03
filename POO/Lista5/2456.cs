using System;

public class Program{
  public static void Main(string [] args){
    string [] aposta = Console.ReadLine().Split(' ');
    string [] sorteado = Console.ReadLine().Split(' ');
    int i = 0;
    int y = 0;
    int cont = 0;
    for (i=0;i<6;i++){
      for(y=0;y<6;y++){
        if(aposta[i]==sorteado[y]){
          cont++;
        }
      }
    }
    if (cont==3){
      Console.WriteLine("terno");
    }
    else if (cont==4){
      Console.WriteLine("quadra");
    }
    else if (cont==5){
      Console.WriteLine("quina");
    }
    else if (cont==6){
      Console.WriteLine("sena");
    }
    else{
      Console.WriteLine("azar");
    }
    
  }
}