namespace Pierre.BakedGoods
{
  public class Pastry
  {
    public string POrderFor { get; set; }
    public int  POrderAmount { get; set; }
    public double POrderPrice { get; set; }
    public double PastryPrice { get; set; }

    public Pastry(string pOrderFor, int pOrderAmount)
    {
      POrderFor = pOrderFor;
      POrderAmount = pOrderAmount;
      POrderPrice = 0;
      PastryPrice = 2;
    }

    public void  CalculatePOrderPrice()
    {
      POrderPrice = POrderAmount * PastryPrice;
      ThreeForFive();
    }

    public void ThreeForFive()
    {
      if (POrderAmount >= 3)
      {
        POrderPrice = (((POrderAmount/3)*5)+((POrderAmount % 3)*2));
      }
    }
  }
}