namespace WindowsCalculator;

public partial class FormMain : Form
{
	private const int DefaultWholesaleDiscount = -15;
	private const double DefaultSashPrice = 1200;

	private const double DefaultAluminiumPrice = 720;
	private const double DefaultPlasticPrice = 550;
	private const double DefaultWoodPrice = 850;

	private const double DefaultGlassPrice = 500;
	private const double DefaultInsulatedGlassPrice = 1500;

	private readonly Config _config = new(
		DefaultWholesaleDiscount,
		DefaultGlassPrice,
		DefaultInsulatedGlassPrice,
		DefaultSashPrice,
		DefaultAluminiumPrice,
		DefaultPlasticPrice,
		DefaultWoodPrice
	);

	public FormMain () => this.InitializeComponent();

	private void FormMain_Load (object sender, EventArgs e) => this.ResetValues();

	private void btnClear_Click (object sender, System.EventArgs e) => this.ResetValues();

	private void exitToolStripMenuItem_Click (object sender, System.EventArgs e) => this.Close();

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
			double materialPrice = this._config.GetMaterialPrice((string?)this.cmbMaterial.SelectedItem);
			double glassPricePerUnit = this._config.GetGlassPrice((string?)this.cmbGlassType.SelectedItem);

			double area = widthMeters * heightMeters;
			double perimeter = 2 * (widthMeters + heightMeters);

			double glassCost = area * glassPricePerUnit;
			double frameCost = perimeter * materialPrice;
			double sashesCost = numSashes * (this._config.SashPrice + materialPrice);
			double retailCost = frameCost + sashesCost + glassCost;
			int wholesaleDiscount = this._config.WholesaleDiscount;
			double wholesaleCost = retailCost * (1 + (this._config.WholesaleDiscount) / 100.0);

			this.SetAreaValueText(area);
			this.SetRetailValueText(retailCost);
			this.SetWholesaleValueText(wholesaleCost);
			this.SetDetailsText(materialPrice, glassPricePerUnit, numSashes, this._config.SashPrice, wholesaleDiscount);
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
	private void SetDetailsText (double materialPrice, double glassPrice, int numSashes, double sashPrice, int wholesaleDiscount)
		=> this.lblDetails.Text = string.Format(
		"Материал: {0}; стекло: {1}; створки: {2} x {3}; опт: {4}%",
		FormatPrice(materialPrice),
		FormatPrice(glassPrice),
		numSashes,
		FormatPrice(sashPrice),
		wholesaleDiscount
	);

	private static string FormatPrice (double price) => price.ToString("N0") + " ₽";
}