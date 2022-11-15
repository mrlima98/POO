using System;

class Program{
  public static void Main (string [] args){

    CartaBaralho x = new CartaBaralho(5, "ouro");
      CartaBaralho y = new CartaBaralho(6, "paus");
    Console.WriteLine(x.ToString());
    Console.WriteLine(y.ToString());
    Console.WriteLine(CartaBaralho.Comparar(x,y));
    
  }
}

class CartaBaralho{
  private int carta;
  private string naipe;
  

  public CartaBaralho(int vc, string vn){
    if(vc>0 && vc<13) carta = vc;
    if (vn=="ouro"||vn=="copas"||vn=="espada"||vn=="paus") naipe = vn;
  }

  public int GetCarta(){
    return carta;
  }

  public string GetNaipe(){
    return naipe;
  }

  public override string ToString(){

    return $"Carta {carta}, Naipe: {naipe}";
  }

  public static bool Comparar(CartaBaralho x, CartaBaralho y){
    
    
    return x.GetCarta() == y.GetCarta();
    
    

  }
  
}