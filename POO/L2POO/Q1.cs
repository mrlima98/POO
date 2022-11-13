using System;


class Program{
public static void Main (string [] args){
    Circulo x = new Circulo();

  x.SetRaio(3);

  Console.WriteLine(x.CalcArea());
  Console.WriteLine(x.CalcCircuferencia());
  
}
}

class Circulo{
  private double raio;

  public void SetRaio(double v){
    if(v>0) raio = v;
  }

  public double GetRaio(){
    return raio;
  }

  public double CalcArea(){
  double area = Math.Pow(raio,2)*3.14;
    return area;
  }

  public double CalcCircuferencia(){
    double cir = 3.14*raio*2;
    return cir;
  }
  
}