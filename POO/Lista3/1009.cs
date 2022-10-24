using System;


public class Program{

  public static void Main (string[] args){
  string nome;
  double s_fixo,t_vendas, total;
  double com = 0.15;

  nome = Console.ReadLine();
  s_fixo = double.Parse(Console.ReadLine());
  t_vendas = double.Parse(Console.ReadLine());

  total = (t_vendas*com)+s_fixo;
  Console.WriteLine($"{total:0.00}");
  }
}