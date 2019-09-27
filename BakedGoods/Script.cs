using System;
using System.Collections.Generic;

namespace Pierre.BakedGoods
{
  public class Script
  {
    public static Bread BreadOrderScript()
    {
      //Script to get customer bread order and create instance. 
      Console.WriteLine("We know y'all are here trying to yeet that wheat... So hit us with it. Whatchall jabronies want?");
      Console.WriteLine("Enter the amount of bread you would like to order. (if you just want them tasty pastries, enter 0.");
      userPastry = int.Parse(Console.ReadLine());
      if (userPastry = 0)
      {
        Console.WriteLine("Well that was stupid.");
        Pastry newPastry = new Pastry(userPastry);
        return newPastry;
      }
      else if (0 <userPastry< 50)
      {
        Console.WriteLine("Right on we will get that wheat together so you can yeet it asap.");
        Pastry newPastry = new Pastry(userPastry);
        pastryPrice = userPastry.CalculateBOrderPrice();
        Console.WriteLine("The Price for that bread will be " + pastryPrice + ".");
        return newPastry;
      }
      else{
        Console.WriteLine("Come on man how many do you really want? Be serious. We can't do an order over 50.");
        PastryOrderScript();
      }
    }
    public static Pastry PastryOrderScript()
    {
      //Script to get customer Pastry order and create instance. 
      Console.WriteLine("Enter the amount of pastries uou would like to order. (if you an idiot and don't want any pastries, enter 0.");
      userPastry = int.Parse(Console.ReadLine());
      if (userPastry = 0)
      {
        Console.WriteLine("Well that was stupid.");
        Bread newBread = new Bread(userPastry);
        return newBread;
      }
      else if (0 < userPastry < 50)
      {
        Console.WriteLine("Right on we will get that wheat together so you can yeet it asap.");
        Bread newBread = new Bread(userPastry);
        breadPrice = userPastry.CalculateBOrderPrice();
        Console.WriteLine("The Price for that bread will be " + breadPrice + ".");
        return newBread;
      }
      else
      {
        Console.WriteLine("Come on man how many do you really want? Be serious. We can't do an order over 50.");
        BreadOrderScript();
      }
    }
  }
}