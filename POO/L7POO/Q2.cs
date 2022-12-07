using System;

class Program{

  public static void Main(string [] args){
   
    Frete a = new Frete();
    a.Distancia=10;
    a.Peso=20;
    Console.WriteLine(a.Distancia);
    Console.WriteLine(a.Peso);
    Console.WriteLine(a.ValorFrete);
    Console.WriteLine(a.ToString());
    
  }
}


class Frete{
private double distancia, peso;


 public double Distancia{
   get{ return distancia; }
   set{if(value>0) distancia=value;}
 }

public double Peso{
  get{ return peso;}
   set{if(value>0) peso=value;}
}

  public double ValorFrete{
    get{return ((0.01*peso)*distancia)/100;}
  }
  public override string ToString(){

    return $"Peso:{peso} e distancia {distancia}";
  }
}