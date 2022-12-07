using System;

class Program{

  public static void Main (string [] args){
    Loja play = new Loja();
    play.Nome="PLay store";
    
    Aplicativo a = new Aplicativo();
    a.Nome="Facebook";
    a.Categoria= "Teste";
    a.Preco=10;
    a.Curtir();

     Aplicativo b = new Aplicativo();
    a.Nome="Instagram";
    b.Categoria= "Rede social";
    b.Preco=20;
    b.Curtir();

    play.Inserir(a);
    play.Inserir(b);
    Console.WriteLine(play.Qtd);
     foreach( Aplicativo t in play.Listar())
       Console.WriteLine(t);
    

  }
}

class Loja{
  private Aplicativo [] apps = new Aplicativo[5];
  private int k=0;
  public string Nome{get;set;}
  
  public int Qtd{
    get{return k;}
  }
  public void Inserir (Aplicativo app){
    apps[k] = app;
    k++;
  }

  public Aplicativo []  Listar(){
    return apps;
  }
}

////////////////////////////////////////////
class Aplicativo{
  private int curtidas;

    public string Nome{get;set;}
    public string Categoria{get;set;}
    public double Preco {get;set;}
    public int Curtidas {
      get{return curtidas;}
    }
    public void Curtir(){
      curtidas ++;
    }

  public override string ToString(){

    return $"Dados: {Nome} {Categoria} {Preco}";
  }
}