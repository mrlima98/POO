using System;

class Program{

  public static void Main (string [] args){
    
    PlayList x = new PlayList("POP", "Descrica do album");
  
    Musica m1 = new Musica ("Michael","BAD","BAD", DateTime.Parse("01/01/2011"));
    
    Musica m2 = new Musica ("TDG","PAIN","BAD",DateTime.Parse("02/02/2022"));
    
    Musica m3 = new Musica ("Skillet","Hero","BAD",DateTime.Parse("03/03/2033"));
    
    x.Inserir(m1);
    x.Inserir(m2);
    x.Inserir(m3);
    
    Console.WriteLine(x.ToString());
    Console.WriteLine();

    foreach (Musica t in x.Listar())
      Console.WriteLine(t);
    
    
    
   
  }
}

class PlayList{
  
  private string nome, descricao;
  private Musica [] m;  //atributo da class
  private int k = 0;
  
  public PlayList (string nome, string descricao){
    this.nome = nome;
    this.descricao = descricao;
    m = new Musica[3]; //atributo da classe
  }
  public void Inserir(Musica mus){  //recebe a referencia da musica
    m [k] = mus;
    k++;
  }

  public Musica [] Listar(){
    
    return m;
  }

  public override string ToString(){
   
    return $"Album: {nome} descricao:{descricao}";
  }
}


//////////////////////////////////////////////////////////
class Musica{
  private string titulo;
  private string artista, album;
  private DateTime dataInclusao;
  

  public Musica(string titulo, string artista, string album, DateTime dataInclusao){
    this.titulo = titulo;
    this.artista = artista;
    this.album = album;
    this.dataInclusao = dataInclusao;
  }

  public override string ToString(){
    return $"Artista: {titulo} \n Album:{artista}\n Album: {album}\n data de inclusao {dataInclusao}";
  }
}