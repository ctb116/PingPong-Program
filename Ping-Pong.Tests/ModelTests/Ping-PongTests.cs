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
      Assert.AreEqual(true, testPingPong.IsPingPong(3));
    }
  }
}
