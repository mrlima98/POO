using System;

class Program{

  public static int MMC (int num1, int num2){
    int resto,a,b;

    do{
      resto = a%b;
      a = b;
      b = resto;
    }while(resto !=0);
    return (num1*num2)/a;
  }


  
  public static void Main (string [] args){
    int num1, num2,r;
    num1 = int.Parse(Console.ReadLine());
    num2 = int.Parse(Console.ReadLine());
    r = MMC(num1,num2);
    Console.WriteLine(r);
  }
}