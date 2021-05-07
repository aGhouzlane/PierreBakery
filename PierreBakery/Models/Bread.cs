namespace PierreBakery
{
  public class Bread
  {
    private const int breadCost = 5;
    public int BreadQuantity { get; set; }
    public Bread(int breadQuantity)
    {
      BreadQuantity = breadQuantity;
    }
    public int FindBreadOrderPrice()
    {
      return BreadQuantity * breadCost;
    }

    public int GetFreeBread()
    {
      int counter = 0;
      while (BreadQuantity > 1)
      {
        counter++;
        BreadQuantity -= 2;
      }
      return counter;
    }
  }
}