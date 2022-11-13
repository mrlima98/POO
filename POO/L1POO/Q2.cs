using System;

class Program{

   public static double Disciplica (string d, double n1, double n2,double n3, double n4){
    double media;
    String materia = d;
     media = (n1*2+n2*2+n3*3+n4*3)/10;
       
    if(media<60){
      Console.WriteLine("Prova final");
      if(n1<n2 && n1<n3 && n1<n4){
       Console.WriteLine("Digite a nota da prova final (n1)"); 
        n1= int.Parse(Console.ReadLine());
        media = (n1*2+n2*2+n3*3+n4*3)/10;
      }
      else if(n2<n1 && n2<n3 && n2<n4){
       Console.WriteLine("Digite a nota da prova final(n2)"); 
        n1= int.Parse(Console.ReadLine());
        media = (n1*2+n2*2+n3*3+n4*3)/10;
      }
      else if(n3<n1 && n3<n2 && n3<n4){
       Console.WriteLine("Digite a nota da prova final(n3)"); 
        n1= int.Parse(Console.ReadLine());
        media = (n1*2+n2*2+n3*3+n4*3)/10;
      }
      else if(n4<n1 && n4<n2 && n4<n3){
       Console.WriteLine("Digite a nota da prova final(n4)"); 
        n1= int.Parse(Console.ReadLine());
        media = (n1*2+n2*2+n3*3+n4*3)/10;
      }
      
    }
     return media;
   }
  

  public static void Main (string [] args){
      
    Console.WriteLine("Digite a disciplica");
    String dis = Console.ReadLine();
    Console.WriteLine("Digite a Nota 1");
    double n1= int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a Nota 2");
    double n2= int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a Nota 3");
    double n3= int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a Nota 4");
    double n4 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Sua media é {Disciplica(dis,n1,n2,n3,n4):0.00}");
    
  }
}