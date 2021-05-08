using System;
using System.Collections.Generic;

namespace PierreBakery
{
  public class Program
  {
    public static void Main(string[] arg)
    {
      Display();
    }

    public static void Display()
    {
      List<int> priceList = new List<int>();
      int totalOrderPrice = 0;

      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Single Loaf of Bread: $5 - Buy Two Get One Free.");
      Console.WriteLine("Single Pastry: $2 - Buy Three for $5.");
      int breadInput = int.Parse(Console.ReadLine());
      int pastryInput = int.Parse(Console.ReadLine());
      Bread bread = new Bread(breadInput);
      Pastry pastry = new Pastry(pastryInput);

      priceList.Add(bread.FindBreadOrderPrice());
      priceList.Add(pastry.FindPastryOrderPrice());

      foreach (int item in priceList)
      {
        totalOrderPrice += item;
      }
      Console.WriteLine("Total Order Price: " + totalOrderPrice);
    }
  }
}