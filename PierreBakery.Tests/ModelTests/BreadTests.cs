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
    public void Bread_InitializeQuantity_Int()
    {
      Bread bread = new Bread(7);
      Assert.AreEqual(7, bread.BreadQuantity);
    }

    [TestMethod]
    public void FindBreadOrderPrice_CostTimeQuantiy_Int()
    {
      Bread bread = new Bread(7);
      Assert.AreEqual(35, bread.FindBreadOrderPrice());
    }

    [TestMethod]
    public void GetFreeBread_FreeBreadCount_Int()
    {
      Bread bread = new Bread(13);
      Assert.AreEqual(6, bread.GetFreeBread());
    }
  }
}