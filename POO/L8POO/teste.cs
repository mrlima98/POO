using System;
using System.Collections;
class Program{

  public static void Main (string [] args){
    Aluno a = new Aluno ("C", DateTime.Parse("01/01/2001"));
    Aluno b = new Aluno ("B", DateTime.Parse("02/01/2001"));
    Aluno c = new Aluno ("A", DateTime.Parse("03/01/2001"));
    Aluno [] v = {a,b,c};

    //ORDENAR POR NOME
   // Array.Sort(v);
   // foreach(Aluno q in v)
   // Console.WriteLine(q);

    
   //ORDENAR POR DATA
    AlunoNascCom x = new AlunoNascCom();
    Array.Sort(v,x);
    foreach (Aluno i in v)
      Console.WriteLine(i);
    
  }
}


class AlunoNascCom : IComparer {
  public int Compare(object x, object y){
    Aluno a = (Aluno) x;
    Aluno b = (Aluno) y;
    return a.GetNascimento().CompareTo(b.GetNascimento());
  }
}


class Aluno : IComparable {

  private string nome;
  private DateTime nasc;
  public Aluno (string n, DateTime d){
    this.nome = n;
    this.nasc = d;
  }
  
  public string Nome{
    get{return nome;}
  }

  public DateTime GetNascimento(){
    return nasc;
  }
  
  public int CompareTo(object obj){
    // a.CompareTo(b)
    //Comparacao entre objetos this e obj
  /* Aluno x = this;
    Aluno y = (Aluno) obj;
    if (x.nome == y.nome) return 0;
    if (x.nome.CompareTo(y.nome)==-1) return -1;
    if (x.nome.CompareTo(y.nome) == 1) return 1;
    return 0; */
   // return nome.CompareTo(((Aluno)obj).nome);
    Aluno x = (Aluno) obj;
    
    return this.Nome.CompareTo(x.Nome);
  }

  public override string ToString(){
    return $"{nome} {nasc}";
  }
}

