namespace Pierre.BakedGoods
{
  public class Script
  {
    public static Bread BreadOrderScript()
    {
      //Script to get customer bread order and create instance. 
      Console.WriteLine("We know y'all are here trying to yeet that wheat... So hit us with it. Whatchall jabronies want?");
      Console.WriteLine("Enter the amount of bread you would like to order. (if you just want them tasty pastries, enter 0.");
      userBread = Console.ReadLine();
      if (userBread = 0)
        Bread newBread = new Bread(userBread);
        return newBread;
    }
    public static Pastry PastryOrderScript()
    {
      //Script to get customer Pastry order and create instance. 
      Console.WriteLine("Enter the amount of pastries uou would like to order. (if you an idiot and don't want any pastries, enter 0.");
      userPastry = int.Parse(Console.ReadLine());
      Pastry newPastry = new Pastry(userPastry);
    }
  }
}