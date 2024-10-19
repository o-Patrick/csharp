using System;

namespace Aula17
{
  class Program
  {
    static void Main()
    {
      int[] nums = new int[5];
      int[] nums2 = new int[3]{1, 2, 3};
      int[] nums3 = {1, 2, 3};

      nums[0] = 0;
      nums[1] = 1;
      nums[2] = 2;
      nums[3] = 3;
      nums[4] = 4;

      Console.WriteLine(nums[0]);
      Console.WriteLine(nums2[0]);
      Console.WriteLine(nums3[0]);
    }
  }
}
