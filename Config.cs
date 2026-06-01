namespace WindowsCalculator;

public class Config (int wholesaleDiscount, double standardGlassPrice, double insulatedGlassPrice,
		double sashPrice, double aluminiumPrice, double plasticPrice, double woodPrice)
{
	public int WholesaleDiscount { get; set; } = wholesaleDiscount;
	public double StandardGlassPrice { get; set; } = standardGlassPrice;
	public double InsulatedGlassPrice { get; set; } = insulatedGlassPrice;
	public double SashPrice { get; set; } = sashPrice;
	public double AluminiumPrice { get; set; } = aluminiumPrice;
	public double PlasticPrice { get; set; } = plasticPrice;
	public double WoodPrice { get; set; } = woodPrice;

	public double GetMaterialPrice (string? material) => material switch
	{
		"Дерево" => this.WoodPrice,
		"Алюминий" => this.AluminiumPrice,
		"Пластик" => this.PlasticPrice,
		_ => throw new NotImplementedException("Неизвестный материал"),
	};

	public double GetGlassPrice(string? type) => type switch
	{
		"Стеклопакет" => this.InsulatedGlassPrice,
		"Обычное стекло" => this.StandardGlassPrice,
		_ => throw new NotImplementedException("Неизвестный материал"),
	};
}
