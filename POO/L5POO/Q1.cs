using System;

class Program{

  public static void Main (string [] args){
    Paciente x = new Paciente("Michel", "12096953405", "84998120957","2000-10-12" );
    
    
   Console.WriteLine(x.Idade());
    DateTime dt = DateTime.Today;
    DateTime dt1 = DateTime.Parse("2000-10-12");
    Console.WriteLine(DateTime.Year(dt-dt1));
  }
}

class Paciente{
  private string nome, cpf, telefone; 
  private DateTime nascimento;
  DateTime nas;
  public Paciente(string vn, string vc, string vt, string vdn){
    if(vn != "") nome = vn;
    if(vc != "") cpf = vc;
    if(vt != "") telefone = vt;
    nascimento = DateTime.Parse(vdn);
  }


  public string Idade(){
    
    return ToString();
  }

  public override string ToString(){
    
    return $"Idade eh";
  }
  
}