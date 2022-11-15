using System;

class Program {

  public static void Main (string [] args){
    Data x = new Data(14,12,1998);

    Console.WriteLine(x.GetDia());
    Console.WriteLine(x.GetMes());
    Console.WriteLine(x.GetAno());

    Data y = new Data();
    y.SetData(14,12,1998);
    Console.WriteLine(y.GetDia());
    Console.WriteLine(y.GetMes());
    Console.WriteLine(y.GetAno());

    Data z = new Data("13/12/1999");
    Console.WriteLine(z.GetDia());
    Console.WriteLine(z.GetMes());
    Console.WriteLine(z.GetAno());

    Console.WriteLine(z.ToString());
  }
}

class Data{
  private int dia, mes, ano;
  

  public Data(){ }
  public Data(int vd,int vm, int va){
    if (vd>0 && vd <30) dia = vd;
    if (vm>0 && vm <=12) mes = vm;
    if (va>0) ano = va;
  }
  public Data(string data){
    string [] vdata = data.Split("/");
    dia = int.Parse(vdata[0]);
    mes = int.Parse(vdata[1]);
    ano = int.Parse(vdata[2]);
  }

  public void SetData(int vd,int vm, int va){
    if (vd>0 && vd <30) dia = vd;
    if (vm>0 && vm <=12) mes = vm;
    if (va>0) ano = va;
  }

  public int GetDia(){
    return dia;
  }
  public int GetMes(){
    return mes;
  }
  public int GetAno(){
    return ano;
  }

  public override string ToString(){
    
    return $"{dia}/{mes}/{ano}";
  }
}