// using System;

namespace PingPong
{
  public class PingPongGenerator
  {
    // public int input;
    public string IsPingPong(int input)
    {
      if (input % 3 == 0 && input % 5 == 0)
      {
        return "ping-pong";
      }
      else if (input % 5 == 0)
      {
        return "pong";
      }
      else if (input % 3 == 0)
      {
        return "ping";
      }
      else
      {
        return "the number";
      }
    }
  }
}

// class Program
// {
//   public static void Main()
//   {
//     Console.WriteLine("Please enter a number");
//     int input = int.Parse(Console.ReadLine());
//
//     PingPongGenerator checkPingPong = new PingPongGenerator();
//
//     Console.WriteLine(checkPingPong.IsPingPong(input));
//   }
// }
