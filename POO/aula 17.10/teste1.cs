using System; 

public class Program {

  public static void Main(string[] args) {
    double x = 15.1;
    Console.WriteLine(x);

    string y = x.ToString("0.00000");
    Console.WriteLine(y);
  }
}