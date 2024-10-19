using System;

namespace Aula10
{
  class Program
  {
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    static void Main()
    {
      DiasSemana ds = DiasSemana.Domingo;
      // É preciso converter o valor, porque 3 é int e não corresponde ao tipo DiasSemana
      DiasSemana ds2 = (DiasSemana)3;
      int ds3 = (int)DiasSemana.Sexta;
      int ds4 = Convert.ToInt32(DiasSemana.Segunda);

      Console.WriteLine("ds: {0}", ds);
      Console.WriteLine("ds2: {0}", ds2);
      Console.WriteLine("ds3: {0}", ds3);
      Console.WriteLine("ds4: {0}", ds4);
    }
  }
}
