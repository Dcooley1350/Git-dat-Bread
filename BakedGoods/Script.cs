using System;
using System.Collections.Generic;

namespace Pierre.BakedGoods
{
  public class Script
  {
    public static Bread BreadOrderScript()
    {
      //Script to get customer bread order and create instance: 
      Console.WriteLine("Enter the amount of bread you would like to order. (if you just want them tasty pastries, enter 0.");
      string userBread = Console.ReadLine();
      
      if (Script.CreateCheckList().Contains(userBread))
      {
        int userInt = int.Parse(userBread);
        if (userInt == 0)
        {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Well that was stupid.");
          Console.WriteLine("-------------------------------");
          Bread newBread = new Bread(userInt);
          return newBread;
        }
        else
        {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Right on we will get that wheat together so you can yeet it asap.");
          Bread newBread = new Bread(userInt);
          newBread.CalculateBOrderPrice();
          Console.WriteLine("The price for that bread will be $" + newBread.BOrderPrice + ".");
          Console.WriteLine("-------------------------------");
          Console.ReadLine();
          return newBread;
        }
      }
      else{
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Come on man how many do you really want? Be serious. We can't do an order over 50.");
        Console.WriteLine("-------------------------------");
        BreadOrderScript();
        int phonyInt = 2;
        Bread newBread = new Bread(phonyInt);
        return newBread;
        }

    }
    public static Pastry PastryOrderScript()
    {
      //Script to get customer Pastry order and create instance:
      Console.WriteLine("Enter the amount of pastries you would like to order. (if you an idiot and don't want any pastries, enter 0.");
      string userPastry = Console.ReadLine();
      if (Script.CreateCheckList().Contains(userPastry))
      {
        int userInt = int.Parse(userPastry);

        if (userInt == 0)
        {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Well that was stupid.");
          Pastry newPastry = new Pastry(userInt);
          return newPastry;
        }
        else
        {
          Console.WriteLine("-------------------------------");
          Console.WriteLine("Right on we will get that wheat together so you can yeet it asap.");
          Pastry newPastry = new Pastry(userInt);
          newPastry.CalculatePOrderPrice();
          Console.WriteLine("The price for those pastries will be $" + newPastry.POrderPrice + ".");
          Console.WriteLine("-------------------------------");
          Console.ReadLine();
          return newPastry;
        }
      }
      else
      {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Come on man how many do you really want? Be serious. We can't do an order over 50.");
        Console.WriteLine("-------------------------------");
        PastryOrderScript();
        int phonyInt = 3;
        Pastry newPastry = new Pastry(phonyInt);
        return newPastry;
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