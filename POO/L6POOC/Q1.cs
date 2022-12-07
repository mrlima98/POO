using System;
using System.Collections;
class Program{

  public static void Main (string [] args){

    
    Colecao x = new Colecao(5);
    x.Inserir(3);
    x.Inserir(9);
    x.Inserir("oi");
    x.Inserir(DateTime.Now);
    
    Console.WriteLine(x.NumItens());
    
    object teste = x.Listar();
    foreach (object z in teste){
      Console.WriteLine(z);
    }
  }
}

class Colecao{
  private int max;
  private object [] itens;
  int k;

  public Colecao(int vm){
    if (vm>0) max = vm;
    itens = new object [max];
  }

  public void Inserir (object item){
    itens [k] = item;
    k++;
  }
  
  public object [] Listar(){
  return itens;
      
  }

  public int NumItens(){
    return k;
  }

}