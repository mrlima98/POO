using System;

class MainClass {
public static void Main() {
Triangulo x = new Triangulo(10, 20, "Azul"); // Linha 1
Triangulo y = x;
Triangulo z;
double bx, rx;
string cx;
y.GetBHC(out bx, out rx, out cx); // Linha 6
Console.WriteLine($"{bx} {rx} {cx}");

Console.WriteLine("Variaveis na memoris Stack do Metodo Main:");
  Console.WriteLine($"{}");
}
}



class Triangulo {
private double b, h;
private string c;
public Triangulo(double b, double h, string c) {
this.b = b;
this.h = h;
this.c = c;
}
public void GetBHC(out double b, out double h, out string c) {
b = this.b;
h = this.h;
c = this.c;
}
}