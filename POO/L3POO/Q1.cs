using System;

class Program{

  public static void Main (string [] args){
    Retangulo x = new Retangulo(50,50);
    
    
    Console.WriteLine($"Valo da area: {x.CalcArea()}");
    Console.WriteLine($"Valo da diagonal: {x.CalcDiagonal()}");
    Console.WriteLine(x.ToString());
    x.SetBase(10);
    Console.WriteLine($"Valo da area: {x.CalcArea()}");
    Console.WriteLine($"Valo da diagonal: {x.CalcDiagonal()}");
    Console.WriteLine(x.ToString());
   
  }
}

class Retangulo{
  private double b,h;

  public Retangulo(double vb, double vh){
    if(vb>0) b=vb;
    if(vh>0) h=vh;
  }

  public void SetBase(double v){
    if(v>0) b=v;
  }
  public void SetAltura(double v){
    if(v>0) h=v;
  }


  public double GetBase(){
    return b;
  }

  public double GetAltura(){
    return h;
  }

  public double CalcArea(){
   
    return b*h;
  }
  
  public double CalcDiagonal(){
    double diagonal = (2*b)+(2*h);
    return diagonal;
  }

  public override string ToString(){
    return $"Base = {b}, Altura = {h}";
  }
}