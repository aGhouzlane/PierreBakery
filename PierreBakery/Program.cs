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
      int userInput;
      int breadCounter = 0;
      int pastryCounter = 0;
      do
      {
        Console.WriteLine("Welcome to Pierre's Bakery");
        Console.WriteLine("Single Loaf of Bread: $5 - Buy Two Get One Free.");
        Console.WriteLine("Single Pastry: $2 - Buy Three for $5.");
        Console.WriteLine("Enter 1 to add a bread order.");
        Console.WriteLine("Enter 2 to add a pastry order.");
        Console.WriteLine("Enter 3 to check the price.");
        Console.WriteLine("Enter 4 to checkout.");
        userInput = int.Parse(Console.ReadLine());
        int totalOrderPrice = 0;
        switch (userInput)
        {
          case 1:
            int breadInput = int.Parse(Console.ReadLine());
            Bread bread = new Bread(breadInput);
            breadCounter = breadCounter + breadInput;
            priceList.Add(bread.FindBreadOrderPrice());
            break;
          case 2:
            int pastryInput = int.Parse(Console.ReadLine());
            Pastry pastry = new Pastry(pastryInput);
            pastryCounter = pastryCounter + pastryInput;
            priceList.Add(pastry.FindPastryOrderPrice());
            break;
          case 3:
            foreach (int item in priceList)
            {
              totalOrderPrice = totalOrderPrice + item;
            }
            Console.WriteLine("Total Order Price: $" + totalOrderPrice);
            break;
          case 4:
            Bread newBread = new Bread(breadCounter);
            Console.WriteLine("Thank you for choosing Pierre's Bakery!");
            foreach (int item in priceList)
            {
              totalOrderPrice = totalOrderPrice + item;
            }
            Console.WriteLine("Total Order Price: $" + totalOrderPrice);
            Console.WriteLine("Bread Loaves Quantity: " + breadCounter +
            " + " + newBread.GetFreeBread() + " Free Bread loaf(ves)");
            Console.WriteLine("Pastry Loaves Quantity: " + pastryCounter);
            break;
        }
      } while (userInput != 4);
    }
  }
}