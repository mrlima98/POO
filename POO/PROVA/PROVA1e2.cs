using System;

class Program{

  public static void Main (string [] args){

    Pais x = new Pais("Brazil", 2000 );

    Console.WriteLine(x.ToString());

    Pais y = new Pais();

    y.SetNome("Argentina");
    y.SetPopulacao(5000);

    Console.WriteLine(y.GetNome());
    Console.WriteLine(y.GetPopulacao());
    Console.WriteLine(y.ToString());
    
  }
}


class Pais{
  private string nome;
  private int populacao;

  public Pais (){ }

  public Pais (string vn, int vp){
  if (vn != "") nome = vn;
    if (vp >0) populacao = vp;
  }

  public void SetNome(string vn){
    if (vn != "") nome = vn;
  }
  public void SetPopulacao(int vp){
    if (vp >0) populacao = vp;
  }

  public string GetNome(){
    return nome;
  }

  public int GetPopulacao(){
    return populacao;
  }

  public override string ToString(){
    return $"Pais:{nome}, Populaca: {populacao}";
  }
}