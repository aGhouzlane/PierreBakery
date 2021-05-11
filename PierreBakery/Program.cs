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
      try
      {
        do
        {
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine("|          Welcome to Pierre's Bakery             |");
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine("|                 Price & Deals                   |");
          Console.WriteLine("| Single Loaf of Bread: $5 - Buy Two Get One Free |");
          Console.WriteLine("| Single Pastry: $2 - Buy Three for $5.           |");
          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine("         Enter 1 to add a bread order");
          Console.WriteLine("         Enter 2 to add a pastry order");
          Console.WriteLine("         Enter 3 to check the price");
          Console.WriteLine("         Enter 4 to checkout");
          Console.WriteLine("------------------------------------------------------------------");
          userInput = int.Parse(Console.ReadLine());
          int totalOrderPrice = 0;
          switch (userInput)
          {
            case 1:
              Console.Write("Bread loaves needed: ");
              int breadInput = int.Parse(Console.ReadLine());
              Bread bread = new Bread(breadInput);
              breadCounter = breadCounter + breadInput;
              priceList.Add(bread.FindBreadOrderPrice());
              break;
            case 2:
              Console.Write("Pastries quantity needed: ");
              int pastryInput = int.Parse(Console.ReadLine());
              Pastry pastry = new Pastry(pastryInput);
              pastryCounter = pastryCounter + pastryInput;
              priceList.Add(pastry.FindPastryOrderPrice());
              break;
            case 3:
              Pastry nPastry = new Pastry(pastryCounter);
              int discount = nPastry.GetDiscountPrice();
              foreach (int item in priceList)
              {
                totalOrderPrice = totalOrderPrice + item;
              }
              Console.WriteLine("Total Order Price: $" + (totalOrderPrice - discount));
              break;
            case 4:
              Bread newBread = new Bread(breadCounter);
              Pastry newPastry = new Pastry(pastryCounter);
              int temp = newPastry.GetDiscountPrice();
              Console.WriteLine("------------------------------------------------------------------");
              Console.WriteLine("|          Thank you for choosing Pierre's Bakery!               |");
              Console.WriteLine("------------------------------------------------------------------");
              foreach (int item in priceList)
              {
                totalOrderPrice = totalOrderPrice + item;
              }
              Console.WriteLine(" Bread Loaves Quantity: " + breadCounter +
              " + (" + newBread.GetFreeBread() + " Free Bread loaf(ves))            ");
              Console.WriteLine("------------------------------------------------------------------");
              Console.WriteLine(" Pastry Quantity: " + pastryCounter + "                           ");
              Console.WriteLine("------------------------------------------------------------------");
              Console.WriteLine(" Total Order Price: $" + (totalOrderPrice - temp) + " ($"
              + temp + " Discount was applied to Total Price) ");
              Console.WriteLine("------------------------------------------------------------------");
              break;
            default:
              Console.WriteLine("Input was not one of the menu entries.");
              break;
          }
        } while (userInput != 4);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}