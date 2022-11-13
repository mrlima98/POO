using System;

class Program{

  public static double Banco(string nome, int n_conta, double saldo){
    string operacao;
    double saque;
    double deposito;
    
    Console.WriteLine($"Ola,{nome}");

    do{
    Console.WriteLine("Escolah sua operação: Saque(S) ou deposito(D)");
    operacao = Console.ReadLine();
      
    }while(operacao!="s" && operacao!="d");

    if(operacao=="s"){
      Console.WriteLine("Valor de saque:");
      saque = double.Parse(Console.ReadLine());
      saldo = saldo - saque;
    }
    else if(operacao=="d"){
      Console.WriteLine("Valor de deposito:");
      deposito = double.Parse(Console.ReadLine());
      saldo = saldo + deposito;
    }
    
    Console.WriteLine("Dados da conta:");
    Console.WriteLine($"Nome,{nome}");
    Console.WriteLine($"Numero da conta,{n_conta}");
      return saldo;
  }

  public static void Main (string [] args){

    Console.WriteLine("Digite o nome do titular da conta");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite o numero da conta");
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o saldo da conta");
    double saldo = double.Parse(Console.ReadLine());

    Console.WriteLine($"O valor que ficou em conta foi: {Banco(nome,numero, saldo)}");
  }
}