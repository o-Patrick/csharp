using System;

namespace Aula18
{
  class Program
  {
    static void Main()
    {
      // [linha, coluna]
      int[,] matriz = new int[2, 2];

      matriz[0, 0] = 1;
      matriz[0, 1] = 2;
      matriz[1, 0] = 3;
      matriz[1, 1] = 4;

      Console.WriteLine(matriz[0, 0]);
      Console.WriteLine(matriz[0, 1]);
      Console.WriteLine(matriz[1, 0]);
      Console.WriteLine(matriz[1, 1]);
    }
  }
}
