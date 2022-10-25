using System;

public class Program {
public static void Main (string [] args){
  int r, cem, cinquenta, vinte, dez, cinco, dois, um;
  r = int.Parse(Console.ReadLine());
  cem = r/100;
  cinquenta = (r%100)/50;
  vinte = ((r%100)%50)/20;
  dez = (((r%100)%50)%20)/10;
  cinco = ((((r%100)%50)%20)%10)/5;
  dois = (((((r%100)%50)%20)%10)%5)/2;
  um = ((((((r%100)%50)%20)%10)%5)%2)/1;

  Console.WriteLine(cem+" nota (s) de R$ 100,00");
  Console.WriteLine(cinquenta+" nota (s) de R$ 50,00");
  Console.WriteLine(vinte+" nota (s) de R$ 20,00");
  Console.WriteLine(cinco+" nota (s) de R$ 5,00");
  Console.WriteLine(dois+" nota (s) de R$ 2,00");
  Console.WriteLine(vinte+" nota (s) de R$ 20,00");
  Console.WriteLine(um+" nota (s) de R$ 1,00");
    
}
}