namespace Pierre.BakedGoods
{
  namespace Pierre.BakedGoods
  {
    public class Bread
    {
      public string BOrderFor { get; set; }
      public int BOrderAmount { get; set; }
      public double BOrderPrice { get; set; }

      public Pastry(string bOrderFor, int bOrderAmount)
      {
        BOrderFor = bOrderFor;
        BOrderAmount = bOrderAmount;
        BOrderPrice = 0;
      }
    }
  }
}