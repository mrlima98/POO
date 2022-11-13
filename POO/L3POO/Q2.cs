using System;

class Program{
  public static void Main (string [] args){
   Frete x = new Frete(5,120);

    Console.WriteLine(x.GetDistancia());
    Console.WriteLine(x.CalcFrete());
    Console.WriteLine(x.ToString());
  }
}


class Frete{
  private double d,p;
  
  public Frete() { }
  public Frete(double vd,double vp){
    if(vd>0)d=vd;
    if(vp>0)p=vp;
  }

  public void SetDistancia(double vd){
    if(vd>0)d=vd;
  }
  public void SetPeso(double vp){
    if(vp>0)p=vp;
  }


  public double GetDistancia(){
    return d;
  }

  public double GetPeso(){
    return p;
  }

  public double CalcFrete(){
    return (p/100)*d;
  }

  public override string ToString(){
    return $"peso: {p} kg, Distancia: {d} km";
  }
}