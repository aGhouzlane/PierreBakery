using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreateBreadObj_BreadObject()
    {
      Bread bread = new Bread(7);
      Assert.AreEqual(9, bread.Quantity);
    }
  }
}