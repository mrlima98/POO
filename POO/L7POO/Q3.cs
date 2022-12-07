using System;

class Program{

  public static void Main (string [] args){
    Paciente Michel = new Paciente();
    Michel.Nome="Michel";
    Michel.CPF="12096953405";
    Michel.Telefone="84 9998120957";
    Michel.Nascimento=DateTime.Parse("12/14/1998");

    Console.WriteLine(Michel.Nome);
    Console.WriteLine(Michel.CPF);
    Console.WriteLine(Michel.Telefone);
    Console.WriteLine(Michel.Nascimento);
    Console.WriteLine(Michel.Idade);
  }
}



class Paciente{
  private string nome, cpf, telefone;
  private DateTime nascimento;
  string idade="oi";

  public string Nome{
    get{return nome;}
    set{nome = value;}
  }

  public string CPF{
    get{return cpf;}
    set{cpf = value;}
  }

  public string Telefone{
    get{return telefone;}
    set{telefone = value;}
  }

  public DateTime Nascimento{
    get{return nascimento;}
    set{nascimento = value;}
  }
  public TimeSpan Idade{

    get{return (DateTime.Today-nascimento).Years;}
  }
  }
  
