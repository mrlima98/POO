using System;

class Program{

  public static void FormatarTexto(ref string text){
   text = text.Replace(" ","");
    
  }


  
  public static void Main (string [] args){
    
    string texto = Console.ReadLine();
    FormatarTexto(ref texto);
    Console.WriteLine(texto);
  }
}
