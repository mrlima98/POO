using System;

class Program{

  public static void Main (string [] args){
    
    //atribuir 10 objetos em Pais

    Pais []paises = new Pais[3];
    for(int i=0; i<3; i++){
    Console.WriteLine($"Nome do Pais {i}: ");
    string nome = Console.ReadLine();
    Console.WriteLine($"População do Pais {i}: ");
    int populacao = int.Parse(Console.ReadLine());
    Console.WriteLine($"Area do Pais {i}: ");
    double area = double.Parse(Console.ReadLine());
    paises [i] = new Pais(nome, populacao,area);
      }
    
    //Validar qual tem a maior densidade
    int maior=0; // varivel para guardar indice do maior decidade
    for (int i=0;i<4;i++){
      for (int z=0;z<4;z++){
        if (paises[i].Densidade()>=paises[z].Densidade()){
          maior = i;
        }
      }
    }
    Console.WriteLine("A maior densidade eh: \n");
    Console.WriteLine(paises[maior].GetNome());
    Console.WriteLine($"Densidade: {paises[maior].Densidade()} hab/km");
    
  }
}



class Pais{
  private string nome;
  private int populacao;
  private double area;

  public Pais (){ }

  public Pais (string vn, int vp, double va){
    if (vn != "") nome = vn;
    if (vp >0) populacao = vp;
    if (va >0) area = va;
  }

  public void SetNome(string vn){
    if (vn != "") nome = vn;
  }
  public void SetPopulacao(int vp){
    if (vp >0) populacao = vp;
  }
  public void SetArea(int va){
    if (va >0) area = va;
  }

  public string GetNome(){
    return nome;
  }

  public int GetPopulacao(){
    return populacao;
  }

  public double GetArea(){
    return area;
  }
  public double Densidade(){

    return populacao/area;
  }

  public override string ToString(){
    return $"Pais:{nome}, Populaca: {populacao}, Densidade democrafica: {populacao/area}";
  }
}