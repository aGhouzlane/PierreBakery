using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery;

namespace PierreBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreatePastryObj_PastryObject()
    {
      Pastry pastry = new Pastry(7);
      Assert.AreEqual(pastry, pastry);
    }

    [TestMethod]
    public void Pastry_InitializeQuantity_Quantity()
    {
      Pastry pastry = new Pastry(7);
      Assert.AreEqual(7, pastry.PastryQuantity);
    }

    [TestMethod]
    public void FindPastryOrderPrice_CostTimeQuantity_Double()
    {
      Pastry pastry = new Pastry(8);
      Assert.AreEqual(40, pastry.FindPastryOrderPrice());
    }
  }
}