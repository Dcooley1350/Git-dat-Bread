namespace Pierre.BakedGoods
{
  public class Bread
  {
    public int BOrderAmount { get; set; }
    public int BOrderPrice { get; set; }
    public int LoafPrice { get; set; }

    public Bread(int bOrderAmount)
    {
      BOrderAmount = bOrderAmount;
      BOrderPrice = 0;
      LoafPrice = 5;
    }
    public void CalculateBOrderPrice()
    {
          BOrderPrice = BOrderAmount * LoafPrice;
          BuyTwoGetOne();
    }
    public void BuyTwoGetOne()
    {
      if (BOrderAmount >= 3)
      {
      BOrderPrice = (((BOrderAmount-(BOrderAmount % 3))/3)*(2*LoafPrice) +((BOrderAmount % 3)*5));
      }
    }
  }
}
