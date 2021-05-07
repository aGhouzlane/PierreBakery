namespace PierreBakery
{
  public class Pastry
  {
    private const int pastryCost = 2;
    public int PastryQuantity { get; }
    public Pastry(int pastryQuantity)
    {
      PastryQuantity = pastryQuantity;
    }

    public int FindPastryOrderPrice()
    {
      return PastryQuantity * pastryCost;
    }

  }
}