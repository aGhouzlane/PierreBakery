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
      Assert.AreEqual(bread, bread);
    }
    [TestMethod]
    public void Bread_InitializeQuantity_Quantity()
    {
      Bread bread = new Bread(7);
      Assert.AreEqual(7, bread.Quantity);
    }
    [TestMethod]
    public void findOrderPrice_CostTimeQuantiy_double()
    {
      Bread bread = new Bread(7);
      Assert.AreEqual(13.93, bread.findOrderPrice());
    }



  }
}