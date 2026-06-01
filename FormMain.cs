namespace WindowsCalculator;

public partial class FormMain : Form
{
	private struct Config (int wholesaleDiscount, double insulatedFactor,
		double sashPrice, double aluminiumPrice, double plasticPrice, double woodPrice)
	{
		public int WholesaleDiscount { get; set; } = wholesaleDiscount;
		public double InsulatedFactor { get; set; } = insulatedFactor;
		public double SashPrice { get; set; } = sashPrice;
		public double AluminiumPrice { get; set; } = aluminiumPrice;
		public double PlasticPrice { get; set; } = plasticPrice;
		public double WoodPrice { get; set; } = woodPrice;
	}

	private const int DefaultWholesaleDiscount = -15;
	private const double DefaultInsulatedFactor = 1.35;
	private const double DefaultSashPrice = 1200;

	private const double DefaultAluminiumPrice = 7200;
	private const double DefaultPlasticPrice = 5500;
	private const double DefaultWoodPrice = 8500;

	private readonly Config _config = new(
		DefaultWholesaleDiscount,
		DefaultInsulatedFactor,
		DefaultSashPrice,
		DefaultAluminiumPrice,
		DefaultPlasticPrice,
		DefaultWoodPrice
	);

	public FormMain () => this.InitializeComponent();

	private void FormMain_Load (object sender, EventArgs e) => this.ResetValues();

	private void btnClear_Click (object sender, System.EventArgs e) => this.ResetValues();

	private void exitToolStripMenuItem_Click (object sender, System.EventArgs e) => this.Close();

	private void settingsToolStripMenuItem_Click (object sender, System.EventArgs e) => this.Close();

	private void input_ValueChanged (object sender, System.EventArgs e) => this.CalculateCost();

	private void input_SelectedIndexChanged (object sender, System.EventArgs e) => this.CalculateCost();

	private void ResetValues ()
	{
		this.numWidth.Value = 120;
		this.numHeight.Value = 140;
		this.numSashes.Value = 2;
		this.cmbMaterial.SelectedIndex = 0;
		this.cmbGlassType.SelectedIndex = 0;
	}

	private void CalculateCost ()
	{
		try {
			int numSashes = (int)this.numSashes.Value;
			double widthMeters = (double)this.numWidth.Value / 100;
			double heightMeters = (double)this.numHeight.Value / 100;
			double materialPrice = GetMaterialPrice((string?)cmbMaterial.SelectedItem);
			double glassMultiplier = GetGlassMultiplier((string?)this.cmbGlassType.SelectedItem);

			double area = widthMeters * heightMeters;
			double frameCost = area * materialPrice * glassMultiplier;
			double sashesCost = numSashes * this._config.SashPrice;
			double retailCost = frameCost + sashesCost;
			int wholesaleDiscount = this._config.WholesaleDiscount;
			double wholesaleCost = retailCost * (1 - (this._config.WholesaleDiscount) / 100.0);

			this.SetAreaValueText(area);
			this.SetRetailValueText(retailCost);
			this.SetWholesaleValueText(wholesaleCost);
			this.SetDetailsText(materialPrice, glassMultiplier, numSashes, this._config.SashPrice, wholesaleDiscount);
		}
		catch (Exception ex) {
			this.lblDetails.Text = $"Ошибка {ex.Message}";
			this.lblWholesaleValue.Text = "-";
			this.lblRetailValue.Text = "-";
			this.lblAreaValue.Text = "-";
		}
	}

	private void SetAreaValueText (double area) => this.lblAreaValue.Text = area.ToString("0.00") + " м²";
	private void SetRetailValueText (double retailCost) => this.lblRetailValue.Text = FormatPrice(retailCost);
	private void SetWholesaleValueText (double wholesaleCost) => this.lblWholesaleValue.Text = FormatPrice(wholesaleCost);
	private void SetDetailsText (double materialPrice, double glassMultiplier, int numSashes, double sashPrice, int wholesaleDiscount)
		=> this.lblDetails.Text = string.Format(
		"Материал: {0}/м²; стекло: x{1:0.00}; створки: {2} x {3}; опт: {4}%",
		FormatPrice(materialPrice),
		glassMultiplier,
		numSashes,
		FormatPrice(sashPrice),
		wholesaleDiscount
	);

	private static double GetMaterialPrice (string? material) => material switch
	{
		"Дерево" => DefaultWoodPrice,
		"Алюминий" => DefaultAluminiumPrice,
		"Пластик" => DefaultPlasticPrice,
		_ => throw new NotImplementedException("Неизвестный материал"),
	};

	private static double GetGlassMultiplier (string? type) => type switch
	{
		"Стеклопакет" => DefaultInsulatedFactor,
		"Обычное стекло" => 1,
		_ => throw new NotImplementedException("Неизвестный материал"),
	};

	private static string FormatPrice (double price) => price.ToString("N0") + " ₽";
}