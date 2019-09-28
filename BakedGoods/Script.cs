using System;
using System.Collections.Generic;

namespace Pierre.BakedGoods
{
  public class Script
  {
    public static void WelcomeScript(Bread newBread, Pastry newPastry)
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
      Script.BreadOrderScript(newBread, newPastry);
    }

    public static void BreadOrderScript(Bread newBread, Pastry newPastry)
    {
      //Script to get customer bread order and create instance: 
      Console.WriteLine("Enter the amount of bread you would like to add order. (if you just want them tasty pastries, enter 0.");
      string userBread = Console.ReadLine();
      
      if (Script.CreateCheckList().Contains(userBread))
      {
        int userInt = int.Parse(userBread);
        newBread.BOrderAmount += userInt;
        if (newBread.BOrderAmount == 0)
        {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Well that was stupid.");
          Console.WriteLine("-------------------------------");
          Script.PastryOrderScript(newBread, newPastry);
        }
        else
        {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Right on we will get that wheat together so you can yeet it asap.");;
          newBread.CalculateBOrderPrice();
          Console.WriteLine("The price for all that bread will be $" + newBread.BOrderPrice + ".");
          Console.WriteLine("-------------------------------");
          Console.ReadLine();
          Script.PastryOrderScript(newBread, newPastry);
        }
      }
      else
      {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Come on man how many do you really want? Be serious. We can't do an order over 50.");
        Console.WriteLine("-------------------------------");
        BreadOrderScript(newBread, newPastry); 
        }

    }
    public static void PastryOrderScript(Bread newBread, Pastry newPastry)
    {
      //Script to get customer Pastry order and create instance:
      Console.WriteLine("Enter the amount of pastries you would like to add to your order. (if you an idiot and don't want any pastries, enter 0.");
      string userPastry = Console.ReadLine();
      if (Script.CreateCheckList().Contains(userPastry))
      {
        int userInt = int.Parse(userPastry);
        newPastry.POrderAmount += userInt;

        if (newPastry.POrderAmount == 0)
        {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Well that was stupid.");
          Script.RestartScript(newPastry, newBread);
        }
        else
        {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Right on we will get that wheat together so you can yeet it asap.");

          newPastry.CalculatePOrderPrice();
          Console.WriteLine("The price for all those pastries will be $" + newPastry.POrderPrice + ".");
          Console.WriteLine("-------------------------------");
          Console.ReadLine();
          Script.RestartScript(newPastry, newBread);
        }
      }
      else
      {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Come on man how many do you really want? Be serious. We can't do an order over 50.");
        Console.WriteLine("-------------------------------");
        PastryOrderScript(newBread, newPastry);
      }
    }

    public static void RestartScript(Pastry newPastry, Bread newBread)
    {
      Console.WriteLine("Well thanks for your order, chief.");
      //Calculate total order cost:
      int totalOrderCost = (newPastry.POrderPrice + newBread.BOrderPrice);
      Console.ReadLine();
      Console.WriteLine("The total for that order is going to be $" + totalOrderCost + ".00.");
      Console.ReadLine();
      Console.WriteLine("Are we done here or is there something I can add to your order?(Yes or No)");
      string userAnswer = Console.ReadLine();
      if (userAnswer == "Yes")
      {
        Console.WriteLine("What the hell do you want now?!(Pastries or Bread)");
        string whatToOrder = Console.ReadLine();
        if (whatToOrder == "Pastries")
        {
          Script.BreadOrderScript(newBread, newPastry);
        }
        else if (whatToOrder == "Bread")
        {
          Script.BreadOrderScript(newBread, newPastry);
        }
        else
        {
          Console.WriteLine("I only have Pastries or Bread. This isn't Betty Crocker's kitchen.");
          Script.RestartScript(newPastry, newBread);
        }
      }
      else if (userAnswer == "No")
      {
        Console.WriteLine("Get the hell out of here I have other customers to get yeeted.");
      }
      else
      {
        Console.WriteLine("Come on man, it's a yes or no question.");
        RestartScript(newPastry, newBread);
      }
    }

    static List<string> CreateCheckList()
    {
      List<string> checkList = new List<string> {};
      for (int i = 0; i <= 50 ; i++)
      {       
        checkList.Add(i.ToString());
      }
      return checkList;
    }
  }
}