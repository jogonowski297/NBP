namespace NBP.Models.Exchange
{
    public class ExchangeRate
    {
        public string No { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }
        public string Mid { get; set; }
    }
}
