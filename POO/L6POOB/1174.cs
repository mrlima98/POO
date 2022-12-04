using System;

class Program{


  public static void Main (string [] args){
    int [] m1 = new int [10];
     for (int i =0 ; i<m1.Length; i++){
       m1[i] = int.Parse(Console.ReadLine());
     }
    for(int i =0 ; i<m1.Length; i++){
      if(m1[i]<=10){
        Console.WriteLine($"M1[{i}] = {m1[i]}");
      }
    }

    
  }
}