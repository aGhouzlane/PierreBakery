namespace PierreBakery
{
  public class Bread
  {
    private double cost = 1.99;
    public int Quantity { get; set; }
    public Bread(int quantity)
    {
      Quantity = quantity;
    }
    public double findOrderPrice()
    {
      return Quantity * cost;
    }

  }
}