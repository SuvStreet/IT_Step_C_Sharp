using System.Threading;

namespace Delay
{
  class Program
  {
    static void Main(string[] args)
    {
      for(i = 0; i < 10; i++)
      {
        Thread.Sleep(200);
        Console.WriteLine("Delay 200 milliseconds!");
      }
    }
  }
}
