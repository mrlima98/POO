using System;

class Program{



public static void Intervalo(double x, out int inicio, out int fim){
    inicio = (int)x;
    fim = inicio+1;
  }

  
  public static void Main( string [] args){
    double x;
    int y,z;
    x= double.Parse(Console.ReadLine());
    Intervalo(x, out y,out z);
      Console.WriteLine($"Entre {y} e {z}");
      
  }
}