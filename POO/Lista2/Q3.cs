using System; 

public class Program {

  public static void Main(string[] args) {
  int n1;
    int n2;
    Console.WriteLine("Digite primeira nota: ");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite segunda nota: ");
    n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Media parcial, "+(((n1*2)+(n2*3))/5));
    
  }
}