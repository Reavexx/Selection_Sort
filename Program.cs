using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe03
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      int size = 10;
      int[] array = new int[10];

      for (int i = 0; i < 10; ++i)
        array[i] = random.Next(1, 100);

      Console.WriteLine("Unsorted: ");
      for (int i = 0; i < size; i++)
      {
        Console.Write(array[i]); Console.Write(" ");
      }
      int tmp, min;

      for (int i = 0; i < size - 1; i++)
      {
        min = i;

        for (int k = i + 1; k < size; k++)
        {
          if (array[k] < array[min])
          {
            min = k;
          }
        }

        tmp = array[min];
        array[min] = array[i];
        array[i] = tmp;
      }

      Console.WriteLine("\n-------------------------------\nSelection Sort: ");

      Unterprogramme();
      for (int i = 0; i < 10; i++)
      {
        Console.Write(array[i]); Console.Write(" ");
      }
      Console.ReadLine();
    }
  }
}
