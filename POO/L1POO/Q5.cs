using System;

class Program{


  public static double Cinema (string dia, int horario){
    double ingresso;
    string meia;
    if (dia=="segunda" || dia=="terca"|| dia=="quarta"){
      Console.WriteLine("Meia entrada? S ou N");
      meia = Console.ReadLine();
      if(meia=="S"){
        ingresso = 16/2;
        if(horario>=17){
          ingresso = ingresso+(ingresso*0.50);
        }
      }
      else{
        ingresso = 16;
        if(horario>=17 ){
          ingresso = ingresso+(ingresso*0.50);
        }
      }
      
    }
    
    else if(dia=="sexta" || dia=="sabado"|| dia=="domingo"){
      Console.WriteLine("Meia entrada? S ou N");
      meia = Console.ReadLine();
      if(meia=="S"){
        ingresso = 20/2;
        if(horario>=17){
          ingresso = ingresso+(ingresso*0.50);
        }
      }
      else{
        ingresso = 20;
        if(horario>=17){
          ingresso = ingresso+(ingresso*0.50);
        }
      }
      
    }
    else{
      ingresso = 8;
    }
    

    return ingresso;
  }


  public static void Main (string [] args){

    Console.WriteLine("Digite o dia da semana");
    string data = Console.ReadLine();
    Console.WriteLine("Digite o horario");
    int h = int.Parse(Console.ReadLine());

    Console.WriteLine($"O valor da entrada é: {Cinema(data, h):0.00} R$");
    
  }
}