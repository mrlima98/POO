using System;

class Program{

  public static void Main (string [] args){
    Retangulo a = new Retangulo();
    a.Base = 10;
    a.Altura = 5;
    Console.WriteLine(a.Base);
    Console.WriteLine(a.Altura);
    Console.WriteLine(a.Area);
    Console.WriteLine(a.Diagonal);
  }
}

class Retangulo{
  private double h, b;

  public double Base {
    get{return b;}
    set{if (value >0) b = value;}
  }

  public double Altura {
    get{return h;}
    set{if (value >0) h = value;}
  }

  public double Area{
    get{return h*b;}
  }

  public double Diagonal{
    get{ return Math.Sqrt(h*h+b*b);}
  }

  public override string ToString(){
    return $"base {b} e altura{h}";
  }
}