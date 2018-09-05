using System;
using System.Collections.Generic;
using System.Linq;

// namespace PingPong
// {
  public class PingPongGenerator
  {
    public int n;
    public string IsPingPong(int n)
    {
      if (n % 3 == 0 && n % 5 == 0)
      {
        return "ping-pong";
      }
      else if (n % 5 == 0)
      {
        return "pong";
      }
      else if (n % 3 == 0)
      {
        return "ping";
      }
      else
      {
        return n.ToString();
      }
    }
  }
// }

class Program
{
  public static void Main()
  {
    Console.WriteLine("Please enter a number");
    int input = int.Parse(Console.ReadLine());
    Console.WriteLine("Here are the results! Ping-Pong!");

    IEnumerable<int> inputRange = Enumerable.Range(1, input);
    foreach (int n in inputRange)
    {
      PingPongGenerator checkPingPong = new PingPongGenerator();
      Console.WriteLine(checkPingPong.IsPingPong(n));
    }
  }
}
