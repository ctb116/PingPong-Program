using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongGeneratorTest
  {
    [TestMethod]
    public void IsPingPong_NumberDivisibleByThree_True()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("ping", testPingPong.IsPingPong(9));
    }
    [TestMethod]
    public void IsPingPong_NumberDivisibleByFive_True()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("pong", testPingPong.IsPingPong(10));
    }
    [TestMethod]
    public void IsPingPong_NumberDivisibleByThreeAndFive_True()
    {
      PingPongGenerator testPingPong = new PingPongGenerator();
      Assert.AreEqual("ping-pong", testPingPong.IsPingPong(15));
    }
  }
}
