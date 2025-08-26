namespace Core;

public class Sock
{
    public int Id { get; set; }
    public string SerialNumber { get; set; }
    public double PricePerPair { get; set; }
    public int QuantityPerSack { get; set; }
    public int SackQuantity { get; set; }
    public double OverallPrice { get; set; }
    public DateTime dateTime { get; set; }

    public Sock(string SerialNumber, double PricePerPair, int QuantityPerSack, int SackQuantity, double OverallPrice, DateTime dateTime)
    {
        this.SerialNumber = SerialNumber;
        this.PricePerPair = PricePerPair;
        this.QuantityPerSack = QuantityPerSack;
        this.SackQuantity = SackQuantity;
        this.OverallPrice = OverallPrice;
        this.dateTime = dateTime;
    }
    public Sock() { }
}