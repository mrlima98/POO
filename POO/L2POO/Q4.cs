using System;

class Program{

  public static void Main (string [] args){
    Banco x = new Banco();
      x.SetSaldo(200);
      x.SetNome("Michel");
      x.SetConta(120);
    Console.WriteLine(x.GetNome());
    Console.WriteLine(x.GetConta());
    Console.WriteLine(x.GetSaldo());
    x.Saque(40);
    Console.WriteLine(x.GetSaldo());
    x.Deposito(20);
    Console.WriteLine(x.GetSaldo());
    
  }
  
}

class Banco{

  private string nome;
  private int conta;
  private double saldo;
  private double saque;
  

  public void SetNome(string v){
    nome = v;
  }
  public void SetConta(int v){
    if(v>0) conta = v;
  }
  public void SetSaldo(double v){
    if(v>0) saldo = v;
  }
  
  
  public string GetNome(){
    return nome;
  }
  public int GetConta(){
    return conta;
  }

  
  public double GetSaldo(){
    return saldo;
  }
  

  public double Deposito(double v){
    saldo = saldo+v;
    return saldo;
  }

  public double Saque(double v){
    saldo = saldo-v;
    return saldo;
  }
}
