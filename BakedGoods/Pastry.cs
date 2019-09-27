namespace Pierre.BakedGoods
{
  public class Pastry
  {
    public int  POrderAmount { get; set; }
    public int POrderPrice { get; set; }
    public int PastryPrice { get; set; }

    public Pastry(int pOrderAmount)
    {
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
        POrderPrice = (((POrderAmount - (POrderAmount % 3))/3)*5) + ((POrderAmount % 3) *2);
      }
    }
  }
}