using System;

class Program{

  public static void Main (string [] args){

    //Iniciado um vetor
    int [,] matriz1 = {{1,2,3,0},{4,5,6,0},{7,8,9,0}};
    int [,] matriz2 = new int [3,4]{{1,1,1,1},{2,2,2,2},{3,3,3,3}};
    //percorrer vetor 1 e 2
    for (int i=0;i<3;i++){
      for(int j=0; j<4;j++){
        Console.Write(matriz1[i,j]);
        Console.Write(" ");
      }
      Console.WriteLine();
    }

    for (int i=0;i<3;i++){
      for(int j=0; j<4;j++){
        Console.Write(matriz2[i,j]);
        Console.Write(" ");
      }
      Console.WriteLine();
    }
  }
}