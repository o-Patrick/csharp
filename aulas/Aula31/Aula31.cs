using System;

namespace Aula30
{
  public class Jogador
  {
    static public int Energia;
    static public bool Vivo;
    static public string Nome;

    // Construtores
    static public void Iniciar(string N)
    {
      Energia = 100;
      Vivo = true;
      Nome = N;
    }

    static public void Info()
    {
      Console.WriteLine("Nome jogador: {0}", Nome);
      Console.WriteLine("Energia: {0}", Energia);
      Console.WriteLine("Estado: {0}", Vivo);
      Console.WriteLine("-------------------------");
    }
  } // class Jogador

  public class Inimigo
  {
    static public bool Alerta;
    public string Nome;
    public Inimigo(string N)
    {
      Alerta = false;
      Nome = N;
    }

    public void Info()
    {
      Console.WriteLine(Nome);
      Console.WriteLine(Alerta);
      Console.WriteLine("-------------------------");
    }
  }

  class Program
  {
    static void Main()
    {
      Jogador.Iniciar("Bruno");
      Jogador.Info();

      Inimigo I1 = new Inimigo("Doido");
      Inimigo I2 = new Inimigo("Maluco");
      Inimigo I3 = new Inimigo("Pirado");

      Inimigo.Alerta = true;

      I1.Info();
      I2.Info();
      I3.Info();
    } // method Main
  } // class Program
} // namespace
