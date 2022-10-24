using System; 

public class Program {

  public static void Main(string[] args) {
  int h,m,s,v,r1;
    Console.WriteLine("Digite a hora em HH:MM:SS");
    string [] hora = Console.ReadLine().Split(':');
    h = int.Parse(hora[0]);
    m = int.Parse(hora[1]);
    s = int.Parse(hora[2]);
    r1 = ((m*60)+((h*60)*60)+s)*3000;
Console.WriteLine(r1);
    v = ((((h*60)*60)+(m*60)+s)*3000);
    Console.WriteLine(v);
}
}