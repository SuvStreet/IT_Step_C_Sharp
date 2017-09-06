using System;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Int32[] arr = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = rnd.Next(-10, 10);
            }

            Console.WriteLine(String.Join(" ", arr));
            Console.WriteLine();

            int x = 1;
            int y = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (x < arr[i] * arr[j]) { x = arr[i] * arr[j]; };
                    }
                    else continue;
                }
            }
          
            for (int i = 0; i < arr.Length; i++)
            {
                if (y < arr[i] * x) { y = x * arr[i]; };
            }

            Console.WriteLine(y);
            Console.WriteLine();
            Array.Sort(arr);
            Console.WriteLine(String.Join(" ", arr));
            Console.WriteLine();
        }
    }
}
