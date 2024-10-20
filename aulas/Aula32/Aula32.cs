using System;

namespace Aula32
{
  class Calculos
  {
    public int v1, v2;

    public Calculos(int v1, int v2)
    {
      this.v1 = v1;
      this.v2 = v2;
    }

    public int Soma()
    {
      return v1 + v2;
    }
  }

  class Program
  {
    static void Main()
    {
      Calculos Calculos = new Calculos(10, 2);

      Console.WriteLine(Calculos.Soma());
    }
  }
}
