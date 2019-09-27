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
      BOrderPrice = ((BOrderAmount * LoafPrice) - ((BOrderAmount / 3) * LoafPrice));
      }
    }
  }
}
