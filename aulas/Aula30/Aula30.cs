using System;

namespace Aula30
{

  public class Jogador
  {
    public int energia;
    public bool vivo;
    public string nome;

    // Construtores
    public Jogador()
    {
      energia = 100;
      vivo = true;
      nome = "Jogador";
    }
    public Jogador(string n)
    {
      energia = 100;
      vivo = true;
      nome = n;
    }
    public Jogador(string n, int e)
    {
      energia = e;
      vivo = true;
      nome = n;
    }
    public Jogador(string n, int e, bool v)
    {
      energia = e;
      vivo = v;
      nome = n;
    }

    public void Info()
    {
      Console.WriteLine("Nome jogador: {0}", nome);
      Console.WriteLine("Energia: {0}", energia);
      Console.WriteLine("Estado: {0}", vivo);
      Console.WriteLine("-------------------------");
    }
  } // class Jogador

  class Program
  {
    static void Main()
    {
      Jogador j1 = new Jogador();
      Jogador j2 = new Jogador("Theo");
      Jogador j3 = new Jogador("Júlia", 100);
      Jogador j4 = new Jogador("Stephany", 0, false);

      j1.energia -= 50;

      j1.Info();
      j2.Info();
      j3.Info();
      j4.Info();
    }
  }
}
