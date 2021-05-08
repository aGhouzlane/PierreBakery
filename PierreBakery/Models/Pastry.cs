namespace PierreBakery
{
  public class Pastry
  {
    private const int pastryCost = 2;
    public int PastryQuantity { get; set; }

    public Pastry(int pastryQuantity)
    {
      PastryQuantity = pastryQuantity;
    }

    public int FindPastryOrderPrice()
    {
      return PastryQuantity * pastryCost;
    }

    public int GetDiscountPrice()
    {
      int counter = 0;
      while (PastryQuantity >= 3)
      {
        counter++;
        PastryQuantity -= 3;
      }
      return counter;
    }

  }
}