namespace PierreBakery
{
  public class Bread
  {
    private const int breadCost = 2;
    public int BreadQuantity { get; set; }
    public Bread(int breadQuantity)
    {
      BreadQuantity = breadQuantity;
    }
    public int FindBreadOrderPrice()
    {
      return BreadQuantity * breadCost;
    }

  }
}