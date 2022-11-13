using System;

class Program{

  public static void Main(string [] args){
    Disciplina x = new Disciplina();
    x.SetNome("MateMatica");
    x.SetNota1(70);
    x.SetNota2(70);
    x.SetNota3(70);
    x.SetNota4(70);
    x.SetNota4(80);
    x.SetNotaFinal(80);
    Console.WriteLine(x.GetNome());
    Console.WriteLine(x.CalMediaParcial());
    Console.WriteLine(x.GetNotaFinal());
  }
  
}

class Disciplina{
  private int nota1,nota2,nota3,nota4, notalFinal;
  private string nome;

  public void SetNome(string s){
    nome = s;
  }
  public void SetNota1(int n){
    if(nota1>=0 && nota1<=100)nota1 = n;
  }
  public void SetNota2(int n){
    if(nota2>=0 && nota2<=100)nota2 = n;
  }
  public void SetNota3(int n){
    if(nota3>=0 && nota3<=100)nota3 = n;
  }
  public void SetNota4(int n){
    if(nota4>=0 && nota4<=100)nota4 = n;
  }

  public void SetNotaFinal(int n){
    if(notalFinal>=0 && notalFinal<=100)notalFinal = n;
  }

  
  public string GetNome(){
    return nome;
  }
  public int GetNota1(){
    return nota1;
  }
  public int GetNota2(){
    return nota2;
  }
  public int GetNota3(){
    return nota3;
  }
  public int GetNota4(){
    return nota4;
  }
  public int GetNotaFinal(){
    return notalFinal;
  }

  
  public int CalMediaParcial(){
    int mediaParcial = (nota1*2+nota2*2+nota3*3+nota4*3)/10;
    return mediaParcial;
  }

  public int CalMediaFinal(){
    int mediaParcial = (nota1*2+nota2*2+nota3*3+nota4*3+notalFinal)/10;
    return mediaParcial;
  }
}