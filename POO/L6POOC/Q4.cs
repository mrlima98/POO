using System;

class Program{

  public static void Main (string [] args){
    Agenda agenda = new Agenda();
    Contato a = new Contato ("Michel", "084998120957", DateTime.Parse("12/14/1998"));
    
    Contato b = new Contato ("Michel", "084998120957", DateTime.Parse("12/14/2000"));

    agenda.Inserir(a);
    agenda.Inserir(b);

   foreach (Contato x in agenda.Listar())
     Console.WriteLine(x);
    
    
  }
}


class Agenda{
  private Contato [] contatos = new Contato [3];
  int k = 0;
  int mes = 1;
  
  public void Inserir(Contato c){
   contatos [k] = c;
    k++;
  }

    public Contato [] Listar(){
      
    Contato [] lista = new Contato[k];
    Array.Copy(contatos,lista,k);

    return lista;
  }

  
}


//////////////////////////////////////////////////

class Contato{
  private string nome, telefone;
  private DateTime nascimento;


  public Contato (string nome, string telefone, DateTime nascimento){
    this.nome= nome;
    this.telefone=telefone;
    this.nascimento=nascimento;
  }

  public override string ToString(){

    return $"Nome: {nome} \n Telefone {telefone} \n Nascimento {nascimento}";
  }
}