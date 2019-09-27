using System;
using System.Collections.Generic;

namespace Pierre.BakedGoods
{
  public class Script
  {
    public static void BreadOrderScript(Bread newBread)
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

          
        }
        else
        {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Right on we will get that wheat together so you can yeet it asap.");;
          newBread.CalculateBOrderPrice();
          Console.WriteLine("The price for all that bread will be $" + newBread.BOrderPrice + ".");
          Console.WriteLine("-------------------------------");
          Console.ReadLine();
          
        }
      }
      else
      {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Come on man how many do you really want? Be serious. We can't do an order over 50.");
        Console.WriteLine("-------------------------------");
        BreadOrderScript(newBread); 
        }

    }
    public static void PastryOrderScript(Pastry newPastry)
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

        }
        else
        {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Right on we will get that wheat together so you can yeet it asap.");

          newPastry.CalculatePOrderPrice();
          Console.WriteLine("The price for all those pastries will be $" + newPastry.POrderPrice + ".");
          Console.WriteLine("-------------------------------");
          Console.ReadLine();
        }
      }
      else
      {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Come on man how many do you really want? Be serious. We can't do an order over 50.");
        Console.WriteLine("-------------------------------");
        PastryOrderScript(newPastry);
      }
    }

    public static void RestartScript(Pastry newPastry, Bread newBread)
    {
      Console.WriteLine("Are we done here or is there something I can add to your order?(Yes or No)");
      string userAnswer = Console.ReadLine();
      if (userAnswer == "Yes")
      {
        Console.WriteLine("What the hell do you want now?!(Pastries or Bread)");
        string whatToOrder = Console.ReadLine();
        if (whatToOrder == "Pastries")
        {
          Script.PastryOrderScript(newPastry);
        }
        else if (whatToOrder == "Bread")
        {
          Script.BreadOrderScript(newBread);
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