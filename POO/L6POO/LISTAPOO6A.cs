using System;
using System.Collections;
class Program{

  public static void Main (string [] args){
    // declara o vetor por referencia e ler todas os elementos
    int[] v1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    for (int i = 0; i < v1.Length; i++)
    Console.WriteLine(v1[i]);
    Console.ReadKey();
    Console.WriteLine();

    //declara o vetor por referencia e imprime apenas os indices pares (nao eh elementos, apenas os indices pares)
    int[] v2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    for (int i = 0; i < v2.Length; i++)
    if (i % 2 == 0) Console.WriteLine(v2[i]);
    Console.ReadKey();

    Console.WriteLine();

    //declara o vetor por referencia e imprime elementos pares
    int[] v3= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    foreach (int i in v3)
    if (i % 2 == 0) Console.WriteLine(i);
    Console.ReadKey();


    Console.WriteLine();

    
    //Usando IENUMEROTR para percorrer o vetor
    int[] v4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    IEnumerator x = v4.GetEnumerator();
    while (x.MoveNext())
    Console.WriteLine(x.Current);
    Console.ReadKey();

    Console.WriteLine();

    //Criado dois vetores. V5 inicia no primeiro elemento e w comeca no ultimo. Tem um laco que vai somar o primeiro elemnto com o ultimo fazendo com que some ate os elementos se colidirem
    int[] v5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] w5 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
    for (int i = 0; i < v5.Length; i++)
    Console.WriteLine(v5[i] + w5[w5.Length-1-i]);
    Console.ReadKey();

    Console.WriteLine();


    //Cariado o vetor v6 e  instanciado o vetor w1
    //w6 vai receber uma copia de 5 elementos (inicia do primeir) do vetor v6
    int[] v6 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] w6 = new int[10];
    Array.Copy(v6, w6, 5);
    foreach (int i in w6)
    Console.WriteLine(i);
    Console.ReadKey();

     Console.WriteLine();
   //Criado vetor v7 e feito a ordenção com o metodo Sort
    int[] v7 = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9 };
    Array.Sort(v7);
    foreach (int i in v7)
    Console.WriteLine(i);
    Console.ReadKey();

   Console.WriteLine();

    //Criado vetor 8 e inverteu todo os elementos com metodo Reverse
    int[] v8 = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9 };
    Array.Reverse(v8);
    foreach (int i in v8)
    Console.WriteLine(i);
    Console.ReadKey();
  
  Console.WriteLine();

  //Criado vetor 9 e p1,p2 e p3 recebe qual incide esta o elemento que foi indicado. Caso nao tenha o elemento, retornar -1
  int[] v9 = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9 };
  int p1 = Array.IndexOf(v9, 5);
  int p2 = Array.IndexOf(v9, 10);
  int p3 = Array.IndexOf(v9, 15);
  Console.WriteLine(p1);
  Console.WriteLine(p2);
  Console.WriteLine(p3);
  Console.ReadKey();

  Console.WriteLine();
    //Criado vetor e vai percorrer o vetor atraves do Array.ForEach e depois multiplica o mesmo elemento
    int[] v10 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Array.ForEach(v10, i => Console.WriteLine(i*i));
    Console.ReadKey();

   Console.WriteLine();

    //Criado uma matriz 3x4, retornar o numero de elementos total na matriz, retornar o numero de elementos em cada dimensap (0=linhas, 1=colunas)
    int[,] m11 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },
                       { 9, 10, 11, 12 } };
    Console.WriteLine(m11.Length);
    Console.WriteLine(m11.GetLength(0));
    Console.WriteLine(m11.GetLength(1));
    Console.ReadKey();

    Console.WriteLine();
  //Cria matriz 4x4 e imprime todo so elementos dela em forma de matriz
    int[,] m12 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },
    { 9, 10, 11, 12 }, {13, 14, 15, 16 } };
    for (int i = 0; i < m12.GetLength(0); i++)
   {
    for (int j = 0; j < m12.GetLength(1); j++)
    Console.Write("{0,3}", m12[i, j]); //{0,3} eh espaco entre os elementos
    Console.WriteLine();
}
    Console.ReadKey();

   //Criado matriz 4x4 e imprime cada em cada linha um elemento
    int[,] m13 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },
    { 9, 10, 11, 12 }, {13, 14, 15, 16 } };
    foreach (int i in m13)
    Console.WriteLine(i);
    Console.ReadKey();


    // criado matriz 4x4 e realizado a soma quando o indice da linhae da coluna for igual
   int[,] m14 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },
   { 9, 10, 11, 12 }, {13, 14, 15, 16 } };
    int q = 0;
    for (int i = 0; i < m14.GetLength(0); i++)
    for (int j = 0; j < m14.GetLength(1); j++)
    if (i == j) q += m14[i, j];
    Console.WriteLine(q);
    Console.ReadKey();

   //Criado matriz 4x4 e realizado a soma quando o indice da linhae da coluna for igual
    int[,] m15 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },
   { 9, 10, 11, 12 }, {13, 14, 15, 16 } };
   int a = 0;
   for (int i = 0; i < m15.GetLength(0); i++)
   a += m15[i, i];
   Console.WriteLine(a);
    Console.ReadKey();
    
}
}