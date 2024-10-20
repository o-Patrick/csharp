using System;

namespace Aula28
{

  public class Jogador
  {
    public int energia;
    public bool vivo;
    public string nome;

    // Construtor
    public  Jogador(string n)
    {
      energia = 100;
      vivo = true;
      nome = n;
    }

    // Destrutor
    ~Jogador()
    {
      Console.WriteLine("Jogador {0} foi destruído", nome);
    }
  }

  class Program
  {
    static void Main()
    {
      Jogador j1 = new Jogador("Bruno");
      Jogador j2 = new Jogador("Theo");

      j1.energia -= 50;

      Console.WriteLine("Nome J1: {0}", j1.nome);
      Console.WriteLine("Nome J2: {0}", j2.nome);
    }
  }
}
