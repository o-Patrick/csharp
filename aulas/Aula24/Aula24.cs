using System;

namespace Aula24
{
  class Program
  {
    static void Main()
    {
      int n1, n2;
      Console.Write("Digite o primeiro número: ");
      n1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Digite o segundo número: ");
      n2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("{0} + {1} = {2}", n1, n2, Soma(n1, n2));
    }

    static int Soma(int n1, int n2)
    {
      int soma = n1 + n2;
      return soma;
    }
  }
}
