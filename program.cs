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
      Console.WriteLine("-------------------------------");
      Console.WriteLine("Welcome to Get Dat Bread Bakery");
      Console.WriteLine("-------------------------------");
      Console.ReadLine();

      Console.WriteLine("Menu:");
      Console.WriteLine("-------------------------------");
      Console.WriteLine("Loaf: $5; Buy two get one free.");
      Console.WriteLine("Pastry: $2; Three for $5");
      Console.WriteLine("-------------------------------");
      Console.ReadLine();
      Console.WriteLine("We know y'all are here trying to yeet that wheat... So hit us with it. Whatchall jabronies want?");

      Bread breadItem = Script.BreadOrderScript();
      Pastry pastryItem = Script.PastryOrderScript();

      Console.WriteLine("Well thanks for your order, chief.");
      //Calculate total order cost:
      int totalOrderCost = (pastryItem.POrderPrice + breadItem.BOrderPrice);
      Console.ReadLine();
      Console.WriteLine("The total for that order is going to be $" + totalOrderCost + ".00.");
      Console.ReadLine();
      Console.WriteLine("Now get the hell out of here I have other customers to get yeeted.");
    }
  }
}