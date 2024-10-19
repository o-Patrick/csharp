using System;

namespace Aula08
{
  class Program
  {
    static void Main()
    {
      int v1, v2, soma;
      string nome;

      Console.Write("Digite o primeiro valor: ");
      v1 = int.Parse(Console.ReadLine());

      Console.Write("Digite o segundo valor: ");
      v2 = Convert.ToInt32(Console.ReadLine());

      soma = v1 + v2;

      Console.WriteLine("A soma entre {0} e {1} é igual a {2}", v1, v2, soma);
    }
  }
}