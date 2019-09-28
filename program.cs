using System;
using System.Collections.Generic;
using Pierre.BakedGoods;


namespace Pierre 
{
  public class Program
  {
    public static void Main()
    {
      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();
      Script.WelcomeScript(newBread, newPastry);

    }
  }
}