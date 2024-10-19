using System;

namespace Aula23
{
  class Program
  {
    static void Main()
    {
      int[] vetor1 = new int[5];
      int[] vetor2 = new int[5];
      int[] vetor3 = new int[5];
      int[,] matriz = new int[2, 5]{{11, 22, 00, 44, 55}, {66, 77, 88, 99, 00}};

      // Povoando vetor1 com valores randômicos
      Random random = new Random();
      for (int i = 0; i < vetor1.Length; i++)
      {
        vetor1[i] = random.Next(50);
      }

      // Lendo os valores de vetor1
      Console.Write("Elementos de vetor1: ");
      foreach (int n in vetor1)
      {
        Console.Write(n + " ");
      }

      // Buscando o índice de um valor
      // public static int BinarySearch(array, valor);
      Console.WriteLine("\n\nBinarySearch");
      int procurado = 33;
      int pos = Array.BinarySearch(vetor1, procurado);
      Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
      Console.WriteLine("---------------------------------------------");

      // Copiando um vetor para outro
      // public static void Copy(vetor_origem, vetor_destino, qtde_elementos)
      Console.WriteLine("Copy");
      Array.Copy(vetor1, vetor2, vetor1.Length);
      foreach(int n in vetor2)
      {
        Console.Write(n + " ");
      }
      Console.WriteLine("\n---------------------------------------------");

      // Copiando um vetor para outro
      // public void CopyTo(vetor_destino, a_partir_desta_posicao)
      Console.WriteLine("CopyTo");
      vetor1.CopyTo(vetor3, 0);
      foreach(int n in vetor3)
      {
        Console.Write(n + " ");
      }
      Console.WriteLine("\n---------------------------------------------");

      // Retorna o comprimento de um vetor
      // public long GetLongLength(dimensao); em dimensao, se é um vetor, usa-se 0; se é uma matriz, isso pode ser alterado de acordo com a dimensão desejada
      Console.WriteLine("GetLongLength");
      long lengthVetor1 = vetor1.GetLongLength(0);
      Console.WriteLine("Quantidade de elementos: {0}", lengthVetor1);
      Console.WriteLine("---------------------------------------------");

      // Retorna o menor índice de um vetor
      // public int GetLowerBound(dimensao)
      Console.WriteLine("GetLowerBound");
      int MenorIndiceVetor1 = vetor1.GetLowerBound(0);
      int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
      Console.WriteLine("Menor índice do vetor1: {0}", MenorIndiceVetor1);
      Console.WriteLine("Menor índice do vetor2 da matriz: {0}", MenorIndiceMatriz_D1);
      Console.WriteLine("---------------------------------------------");

      // Retorna o maior índice de um vetor
      // public int GetUpperBound(dimensao)
      Console.WriteLine("GetUpperBound");
      int MaiorIndiceVetor1 = vetor1.GetUpperBound(0);
      int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
      Console.WriteLine("Maior índice do vetor1: {0}", MaiorIndiceVetor1);
      Console.WriteLine("Maior índice do vetor2 da matriz: {0}", MaiorIndiceMatriz_D1);
      Console.WriteLine("---------------------------------------------");

      // Retorna o valor de um elemento dado o índice
      // public object GetValue(long indice)
      int valor0 = Convert.ToInt32(vetor1.GetValue(3));
      int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
      Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
      Console.WriteLine("Valor da posição (1, 3) da matriz: {0}", valor1);
      Console.WriteLine("---------------------------------------------");

      // Retorna o índice do primeiro elemento igual ao valor
      // public static int IndexOf(array, valor)
      Console.WriteLine("IndexOf");
      int indice1 = Array.IndexOf(vetor1, 3);
      Console.WriteLine("Índice do primeiro valor 3: {0}", indice1);
      Console.WriteLine("---------------------------------------------");

      // Retorna o índice do último elemento igual ao valor
      // public static int LastIndexOf(array, valor)
      Console.WriteLine("LastIndexOf");
      int indice2 = Array.LastIndexOf(vetor1, 3);
      Console.WriteLine("Índice do primeiro valor 3: {0}", indice1);
      Console.WriteLine("---------------------------------------------");

      // Reverte a ordem dos elementos de um vetor
      // public static void Reverse(vetor)
      Console.WriteLine("Reverse");
      Array.Reverse(vetor1);
      foreach (int n in vetor1)
      {
        Console.Write(n + " ");
      }
      Console.WriteLine("\n---------------------------------------------");

      // Define valor de um elemento
      // public void SetValue(object valor, long pos)
      vetor2.SetValue(99, 0);
      for (int i = 0; i < vetor2.Length; i++)
      {
        vetor2.SetValue(99, i);
      }
      Console.Write("SetValue vetor2: ");
      foreach (int n in vetor2)
      {
        Console.Write(n + " ");
      }
      Console.WriteLine("\n---------------------------------------------");

      // Ordenação crescente de um vetor
      // public static void Sort(vetor)
      Console.WriteLine("Sort:");
      Array.Sort(vetor1);
      Array.Sort(vetor2);
      Array.Sort(vetor3);
      Console.Write("vetor1: ");
      foreach (int n in vetor1)
      {
        Console.Write(n + " ");
      }
      Console.Write("\nvetor2: ");
      foreach (int n in vetor2)
      {
        Console.Write(n + " ");
      }
      Console.Write("\nvetor3: ");
      foreach (int n in vetor3)
      {
        Console.Write(n + " ");
      }
      Console.WriteLine("\n---------------------------------------------");
    } // Main
  } // class Program
} // namespace
