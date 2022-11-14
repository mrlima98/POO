using System;

class Program{


  public static void Main(string [] args){
    Conversor x = new Conversor(8);

    
    Console.WriteLine(x.GetNum());
    Console.WriteLine(x.Binario());
    Console.WriteLine(x.ToString());
  }
}

class Conversor{
  private int num;
  int dividendo;
    string valor;


  public Conversor(){}
  public Conversor(int vn){
    if (vn>0) num = vn;
  }
  public void SetNum(int vn){
    if (vn>0) num = vn;
  }

  public int GetNum(){
    return num;
  }

  public string Binario(){
    dividendo = Convert.ToInt32(num);
if (dividendo == 0 || dividendo == 1){
    return Convert.ToString(dividendo);
   }
 
else{
 
while (dividendo > 0){
 
valor += Convert.ToString(dividendo % 2);
dividendo = dividendo / 2;
}
 
return InverterString(valor);; 
}
}

public override string ToString(){
  return $"Decimal: {num}, Binario:{InverterString(valor)}";
}


  
  public static string InverterString(string str)
{
int tamanho = str.Length;
 
char[] caracteres = new char[tamanho];
 
for (int i = 0; i < tamanho; i++)
{
caracteres[i] = str[tamanho - 1 - i];
}
 
return new string(caracteres);
}



  }
  
