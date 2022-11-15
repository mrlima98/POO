using System;

class Program {

  public static void Main(string[] args) {
    CartaBaralho c1 = new CartaBaralho("Copas", 1);
    CartaBaralho c2;
    
    try {
      c2 = new CartaBaralho("Pauss", 3);    
    } catch(ArgumentException e) {
      Console.WriteLine(e.Message);
    }
    
    try {
      c2 = new CartaBaralho("Espadas", 15);
    } catch(ArgumentException e) {
      Console.WriteLine(e.Message);
    }

    c2 = new CartaBaralho("CoPAs", 2);
    if(c1.isEqual(c2)) {
      Console.WriteLine("As cartas são iguais!");
    } else {
      Console.WriteLine("As cartas são diferentes!");
    }

    CartaBaralho c3 = new CartaBaralho("Copas", 2);

    if(CartaBaralho.compare(c3, c2)) {
      Console.WriteLine("As cartas são iguais!");
    } else {
      Console.WriteLine("As cartas são diferentes!");
    }
  }
  
}

class CartaBaralho {
  private string naipe;
  private int valor;

  public CartaBaralho(string naipe, int valor) {
    this.naipe = naipe;
    this.valor = valor;
    this.validate();
  }

  public void validate() {
    bool naipeValido = (naipe.ToLower() == "copas") ||
                       (naipe.ToLower() == "espadas") ||
                       (naipe.ToLower() == "paus") ||
                       (naipe.ToLower() == "ouros");

    if(!naipeValido)
      throw new ArgumentException("O naipe informado ("+this.naipe+") não é válido!");

    if(this.valor < 1 || this.valor > 13)
      throw new ArgumentException("O valor informado ("+this.valor+") não é válido!");
  }

  public void setNaipe(string naipe) {
    this.naipe = naipe;
  }

  public void setValor(int valor) {
    this.valor = valor;
  }

  public string getNaipe() {
    return this.naipe;
  }
  
  public int getValor() {
    return this.valor;
  }

  /*
  * Neste método uma carta avalia se é igual a outra carta dada.
  */
  public bool isEqual(CartaBaralho c) {
    return c.getNaipe().ToLower() == this.naipe.ToLower() && c.getValor() == this.getValor();
  }

  /*
  * Neste método a classe compara se duas cartas dadas são iguais.
  */
  public static bool compare(CartaBaralho c1, CartaBaralho c2) {
    return c1.getNaipe().ToLower() == c1.getNaipe().ToLower() && c1.getValor() == c2.getValor();
  }

  public override string ToString() {
    return "Naipe: " + this.naipe + ", Valor: " + this.valor;
  }

}