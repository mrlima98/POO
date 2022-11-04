using System;

class Program{
  public static void Ordenar(ref int x, ref int y, ref int z){
    if(z<y){
      int c = y;
      y=z;
      z=c;
    }
    else if(y<x && y<z){
      int c = y;
      if(x<z){
        y = x;
        x = c;
      }
      else{
        y = z;
        z=x;
        x =c;
      }
    }

    
  }


  public static void Main(string [] args){
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    Ordenar(ref a,ref b,ref c);
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
  }
}