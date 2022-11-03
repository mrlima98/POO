using System;

public class Program{
public static void Main (string [] args){
  string s1 = Console.ReadLine();
  string [] a = s1.Split(' ');
  int cont = a.Length;
  Console.WriteLine(cont);

  for (int i=0;i<cont;i++){
    Console.WriteLine(cont);
  }
  
  String v = s1.Substring(2, 2);
  Console.WriteLine(v);
  
}
}