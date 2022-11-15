using System;

class Program{
  public static void Main (string [] args){

    CartaBaralho x = new CartaBaralho(5, "ouro");
      CartaBaralho y = new CartaBaralho(5, "paus");
    Console.WriteLine(x.ToString());
    Console.WriteLine(y.ToString());
    
    Console.WriteLine(Comparar(5, "paus"));
  }
}

class CartaBaralho{
  private int carta;
  private string naipe;
  bool validacao;

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

  public bool Comparar(int vc, string vn){
    if (GetCarta()==vc && GetNaipe()==vn){
      validacao = true;
    }

    return validacao;
  }
  
}