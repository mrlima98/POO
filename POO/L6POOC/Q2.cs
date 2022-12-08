using System;

class Program{

  public static void Main (string [] args){
    Bingo x = new Bingo();
    x.Iniciar(8);
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine(x.Proximo());
    Console.WriteLine();
    
    foreach(int t in x.Listar())
    Console.WriteLine(t);
    
  }
}

class Bingo{
  private int numBolas;
  int r;
  int [] sort;
  int k=0;
  
  public void Iniciar(int numBolas){
    if(numBolas>0){
      this.numBolas = numBolas;
      sort = new int [numBolas];
    }
  }
  
  public int Proximo (){
    
    Random randNum = new Random();
    r = randNum.Next(1,numBolas);
    if(k>=numBolas){
      return -1;
    }
    else{
      if (Array.IndexOf(sort,r) == -1){
      sort[k] = r;
      k++;
      return r;
      }
    }
    return 0;
  }

  public int [] Listar(){
    
    return sort;
  }
}