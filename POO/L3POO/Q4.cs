using System;

class Program{

  public static void Main(string [] args){
    double a,b,c;
    double x1,x2;
    Equacao x = new Equacao(1,-5,6);
    x.GetABC(out a,out b,out c);
    Console.WriteLine($"valors sao : {a}, {b}, {c}");
    Console.WriteLine($"Delta eh {x.Delta()}");
    Console.WriteLine($"Tem raizes reais? {x.RaizesReais(out x1,out x2)}");
    Console.WriteLine($"As raizes sao : {x1}, {x2}");
    
  }
}


class Equacao{
  private double a,b,c;
  bool teste;
  double delta;

  public Equacao(){}
  public Equacao(double va, double vb, double vc){
    a=va;
    b=vb;
    c=vc;
    
  }

  public void SetABC(double va, double vb, double vc){
    a=va;
    b=vb;
    c=vc;
  }

  public void GetABC(out double va, out double vb, out double vc){
    va=a;
    vb=b;
    vc=c;
    
  }

  public bool RaizesReais(out double vx1, out double vx2){
      vx1 = (-(b)+Math.Sqrt(delta))/2*a;
      vx2 = (-(b)-Math.Sqrt(delta))/2*a;
    if(delta>0){
      
      teste = true; 
    }
    return teste;
  }

  public double Delta(){
    delta = Math.Pow(b,2)-4*a*c;
    return delta;
  }
}