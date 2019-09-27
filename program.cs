using System;
using System.Collections.Generic;
using Pierre.BakedGoods;


namespace Pierre 
{
  public class Program
  {
    public static void Main()
    {
      //Scipt to welcome customers and present menu:
      Console.WriteLine("Welcome to Get Dat Bread Bakery");
      // Console.ReadKey();
      Console.WriteLine("Menu:");
      Console.WriteLine("-------------------------------");
      Console.WriteLine("Loaf: $5; Buy two get one free.");
      Console.WriteLine("Pastry: $2; Three for $5");
      Console.WriteLine("-------------------------------");
      // Console.ReadKey();

      Bread breadItem = Script.BreadOrderScript();

      Pastry pastryItem = Script.PastryOrderScript();
      //Calculate total order cost:
       int totalOrderCost = (pastryItem.POrderPrice + breadItem.BOrderPrice);

      Console.WriteLine("Well thanks for your order, chief.");
      Console.WriteLine("The total for that order is going to be");
      Console.WriteLine("Now get the hell out of here I have other customers to get yeeted.");
    }
  }
}