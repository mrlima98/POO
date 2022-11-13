using System;

class Program{

  public static void Main (string [] args){
    Cinema x = new Cinema();

    x.SetDia("quarta");
    x.SetHora(14);
    x.SetMeia("N");
    Console.WriteLine(x.GetDia());
    Console.WriteLine(x.GetHora());
    Console.WriteLine(x.Entrada());
  }
}


class Cinema{
  private string dia, meia;
  private int hora;
  double ingresso;
  
  public void SetDia(string v){
    dia = v;
  }

   public void SetHora(int v){
    if(v>0) hora = v;
  }

  public void SetMeia(string v){
    if(v=="S" || v=="N") meia=v;
  }

  public string GetDia(){
    return dia;
  }

  public int GetHora(){
    return hora;
  }

  public string GetMeia(){
    return meia;
  }

  public double Entrada(){ 
    if (dia=="segunda" || dia=="terca"|| dia=="quinta"){
      
      if(meia=="S"){
        ingresso = 16/2;
        if(hora>=17){
          ingresso = ingresso+(ingresso*0.50);
        }
      }
      else{
        ingresso = 16;
        if(hora>=17 ){
          ingresso = ingresso+(ingresso*0.50);
        }
      }
      
    }
    
    else if(dia=="sexta" || dia=="sabado"|| dia=="domingo"){
      
      if(meia=="S"){
        ingresso = 20/2;
        if(hora>=17){
          ingresso = ingresso+(ingresso*0.50);
        }
      }
      else{
        ingresso = 20;
        if(hora>=17){
          ingresso = ingresso+(ingresso*0.50);
        }
      }
      
    }
    else{
      ingresso = 8;
    }
    

    return ingresso;
  }
}