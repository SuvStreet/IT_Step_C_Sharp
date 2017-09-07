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

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10);
            }

            Array.Sort(arr);

            Console.WriteLine(String.Join(" ", arr));
            Console.WriteLine();

            int multiplication_1 = arr[0] * arr[1] * arr[arr.Length - 1];
            int multiplication_2 = arr[arr.Length - 3] * arr[arr.Length - 2] *arr[arr.Length - 1];

            int multiplication_3 = (multiplication_1 > multiplication_2) ? multiplication_1 : multiplication_2;

            Console.WriteLine(multiplication_3);
  
        }
    }
}
