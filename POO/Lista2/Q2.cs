using System; 

public class Program {

  public static void Main(string[] args) {
    
    Console.WriteLine("Digite seu nome: ");
    string [] nome = Console.ReadLine().Split(' ');
    Console.WriteLine($"bem vindo: {nome[0]}");
    
  }
}