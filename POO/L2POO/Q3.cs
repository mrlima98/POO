using System;

class Program{

  public static void Main (string [] args){
    Viagem x = new Viagem();
      x.SetDistancia(20);
      x.SetTempo(10);

      Console.WriteLine($"Velocidade media é {x.VelocidadeMedia()} km/h ");
    
  }
}


class Viagem{
  private double distancia, tempo;

  public void SetDistancia(double n){
    if(n>0) distancia = n;
  }
  public void SetTempo(double n){
    if(n>0) tempo = n; 
  }

  public double GetDistancia(){
    return distancia;
  }

   public double GetTempo(){
    return tempo;
  }

  public double VelocidadeMedia(){
    double velocidade = distancia/tempo;
    return velocidade;
  }
}