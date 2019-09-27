namespace Pierre.BakedGoods
{
  namespace Pierre.BakedGoods
  {
    public class Bread
    {
      public string BOrderFor { get; set; }
      public int BOrderAmount { get; set; }
      public double BOrderPrice { get; set; }
      public double LoafPrice { get; set; }

      public Bread(string bOrderFor, int bOrderAmount)
      {
        BOrderFor = bOrderFor;
        BOrderAmount = bOrderAmount;
        BOrderPrice = 0;
        LoafPrice = 5;
      }
      public void CalculatePOrderPrice()
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
}