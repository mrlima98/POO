using System;

class Program{
  public static void Main (string [] args){
    Compromisso a = new Compromisso();
    
   a.Nome = "Michel";
   a.Local = "Natal";
   a.Data = DateTime.Parse("12/14/1998");
    Console.WriteLine(a.Nome);
    Console.WriteLine(a.Local);
    Console.WriteLine(a.Data);
    Console.WriteLine(a.ToString());
  }
}




class Agenda{
  private Compromisso [] comps = new Compromisso[3];
  private int k=0;
  
  public void Inserir(Comprmisso c){
    comps[k] = c;
    k++;
  }
}
///////////////////////////////
class Compromisso{
  public string Nome{get; set;}
  public string Local{get; set;}
  public DateTime Data{get; set;}

  public override string ToString(){

    return $"{Nome} {Local} {Data}";
  }
}