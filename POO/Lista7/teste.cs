using System;

class teste {
  public static void metodo(ref int a, ref int b){
    int c = a;
    a = b;
    b = c;
  }
  
  public static void Main() {
    int x = 10;
    int y = 20;
    metodo(ref x,ref y);
    Console.WriteLine($"{x} e {y}");
  }
}