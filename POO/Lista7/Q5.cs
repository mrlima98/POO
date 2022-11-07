using System;

class Program{

  public static string FormatarTexto(string text){
   string texto1 = text.Replace(" ","");
    return texto1;
  }


  
  public static void Main (string [] args){
    
    string texto = Console.ReadLine();
    Console.WriteLine(FormatarTexto(texto));
  }
}
