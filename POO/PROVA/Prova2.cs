using System;

class Program{
  public static void Main (string [] args){
    PecaDomino x = new PecaDomino(0,3);
    PecaDomino y = new PecaDomino(2,0);
    Console.WriteLine(y.GetL2());

    Console.WriteLine($"As pecas combina? {PecaDomino.Comparar(x,y)} ");
  }
}

class PecaDomino{
  private int lado1, lado2;

  

  public PecaDomino(int v1, int v2){
    if(v1>0 && v1<=6) lado1 = v1;
    if(v2>0 && v2<=6) lado2 = v2;
  }

  public int GetL1(){
    return lado1;
  }

  public int GetL2(){
    return lado2;
  }

  public override string ToString(){

    return $"Lados da peca sao: {lado1} e: {lado2}";
  }

  public static bool Comparar(PecaDomino x, PecaDomino y){
    
    
    return x.GetL1() == y.GetL1() || x.GetL2()==y.GetL1() || x.GetL1()==y.GetL2() || x.GetL2()==y.GetL2();
    
    

  }
  
}