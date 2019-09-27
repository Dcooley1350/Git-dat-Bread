namespace Pierre.BakedGoods
{
  public class Pastry
  {
    public string POrderFor { get; set; }
    public int  POrderAmount { get; set; }
    public double POrderPrice { get; set; }

    public Pastry(string pOrderFor, int pOrderAmount)
    {
      POrderFor = pOrderFor;
      POrderAmount = pOrderAmount;
      POrderPrice = 0;
    }
  }
}