namespace WindowsCalculator;

public class Config (int wholesaleDiscount, double insulatedFactor,
		double sashPrice, double aluminiumPrice, double plasticPrice, double woodPrice)
{
	public int WholesaleDiscount { get; set; } = wholesaleDiscount;
	public double InsulatedFactor { get; set; } = insulatedFactor;
	public double SashPrice { get; set; } = sashPrice;
	public double AluminiumPrice { get; set; } = aluminiumPrice;
	public double PlasticPrice { get; set; } = plasticPrice;
	public double WoodPrice { get; set; } = woodPrice;
}
