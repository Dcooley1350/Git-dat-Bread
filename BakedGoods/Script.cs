using System;
using System.Collections.Generic;

namespace Pierre.BakedGoods
{
  public class Script
  {
    public static Bread BreadOrderScript()
    {
      //Script to get customer bread order and create instance: 
      Console.WriteLine("We know y'all are here trying to yeet that wheat... So hit us with it. Whatchall jabronies want?");
      Console.WriteLine("Enter the amount of bread you would like to order. (if you just want them tasty pastries, enter 0.");
      int userBread = int.Parse(Console.ReadLine());
      if (userBread == 0)
      {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Well that was stupid.");
        Bread newBread = new Bread(userBread);
        return newBread;
      }
      else if ((0 <userBread) && (userBread <= 50))
      {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Right on we will get that wheat together so you can yeet it asap.");
        Bread newBread = new Bread(userBread);
        newBread.CalculateBOrderPrice();
        Console.WriteLine("The price for that bread will be " + newBread.BOrderPrice + ".");
        return newBread;
      }
      else{
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Come on man how many do you really want? Be serious. We can't do an order over 50.");
        BreadOrderScript();
        Bread newBread = new Bread(userBread);
        return newBread;
      }
    }
    public static Pastry PastryOrderScript()
    {
      //Script to get customer Pastry order and create instance:
      Console.WriteLine("Enter the amount of pastries uou would like to order. (if you an idiot and don't want any pastries, enter 0.");
      int userPastry = int.Parse(Console.ReadLine());
      if (userPastry == 0)
      {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Well that was stupid.");
        Pastry newPastry = new Pastry(userPastry);
        return newPastry;
      }
      else if ((0 < userPastry) && (userPastry < 50))
      {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Right on we will get that wheat together so you can yeet it asap.");
        Pastry newPastry = new Pastry(userPastry);
        newPastry.CalculatePOrderPrice();
        Console.WriteLine("The price for those pastries will be " + newPastry.POrderPrice + ".");
        return newPastry;
      }
      else
      {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Come on man how many do you really want? Be serious. We can't do an order over 50.");
        PastryOrderScript();
        Pastry newPastry = new Pastry(userPastry);
        return newPastry;
      }
    }
  }
}