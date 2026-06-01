namespace WindowsCalculator;

partial class FormMain
{
	/// <summary>
	/// Обязательная переменная конструктора.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Освободить все используемые ресурсы.
	/// </summary>
	/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
	protected override void Dispose (bool disposing)
	{
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Код, автоматически созданный конструктором форм Windows

	/// <summary>
	/// Требуемый метод для поддержки конструктора — не изменяйте
	/// содержимое этого метода с помощью редактора кода.
	/// </summary>
	private void InitializeComponent ()
	{
		this.lblTitle = new Label();
		this.grpParameters = new GroupBox();
		this.cmbGlassType = new ComboBox();
		this.btnClear = new Button();
		this.lblGlassType = new Label();
		this.numSashes = new NumericUpDown();
		this.lblSashes = new Label();
		this.cmbMaterial = new ComboBox();
		this.lblMaterial = new Label();
		this.numHeight = new NumericUpDown();
		this.lblHeight = new Label();
		this.numWidth = new NumericUpDown();
		this.lblWidth = new Label();
		this.grpResult = new GroupBox();
		this.lblDetails = new Label();
		this.lblWholesaleValue = new Label();
		this.lblWholesale = new Label();
		this.lblRetailValue = new Label();
		this.lblRetail = new Label();
		this.lblAreaValue = new Label();
		this.lblArea = new Label();
		this.menuStrip1 = new MenuStrip();
		this.settingsToolStripMenuItem = new ToolStripMenuItem();
		this.exitToolStripMenuItem = new ToolStripMenuItem();
		this.grpParameters.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.numSashes).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numHeight).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numWidth).BeginInit();
		this.grpResult.SuspendLayout();
		this.menuStrip1.SuspendLayout();
		this.SuspendLayout();
		// 
		// lblTitle
		// 
		this.lblTitle.AutoSize = true;
		this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
		this.lblTitle.Location = new Point(31, 24);
		this.lblTitle.Name = "lblTitle";
		this.lblTitle.Size = new Size(359, 32);
		this.lblTitle.TabIndex = 0;
		this.lblTitle.Text = "Калькулятор стоимости окна";
		// 
		// grpParameters
		// 
		this.grpParameters.Controls.Add(this.cmbGlassType);
		this.grpParameters.Controls.Add(this.btnClear);
		this.grpParameters.Controls.Add(this.lblGlassType);
		this.grpParameters.Controls.Add(this.numSashes);
		this.grpParameters.Controls.Add(this.lblSashes);
		this.grpParameters.Controls.Add(this.cmbMaterial);
		this.grpParameters.Controls.Add(this.lblMaterial);
		this.grpParameters.Controls.Add(this.numHeight);
		this.grpParameters.Controls.Add(this.lblHeight);
		this.grpParameters.Controls.Add(this.numWidth);
		this.grpParameters.Controls.Add(this.lblWidth);
		this.grpParameters.Font = new Font("Segoe UI", 10F);
		this.grpParameters.Location = new Point(31, 70);
		this.grpParameters.Name = "grpParameters";
		this.grpParameters.Size = new Size(344, 267);
		this.grpParameters.TabIndex = 1;
		this.grpParameters.TabStop = false;
		this.grpParameters.Text = "Параметры";
		// 
		// cmbGlassType
		// 
		this.cmbGlassType.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbGlassType.FormattingEnabled = true;
		this.cmbGlassType.Items.AddRange(new object[] { "Обычное стекло", "Стеклопакет" });
		this.cmbGlassType.Location = new Point(150, 184);
		this.cmbGlassType.Name = "cmbGlassType";
		this.cmbGlassType.Size = new Size(170, 25);
		this.cmbGlassType.TabIndex = 9;
		this.cmbGlassType.SelectedIndexChanged += this.input_SelectedIndexChanged;
		// 
		// btnClear
		// 
		this.btnClear.Font = new Font("Segoe UI", 10F);
		this.btnClear.Location = new Point(156, 215);
		this.btnClear.Name = "btnClear";
		this.btnClear.Size = new Size(164, 40);
		this.btnClear.TabIndex = 10;
		this.btnClear.Text = "Сбросить";
		this.btnClear.UseVisualStyleBackColor = true;
		this.btnClear.Click += this.btnClear_Click;
		// 
		// lblGlassType
		// 
		this.lblGlassType.AutoSize = true;
		this.lblGlassType.Location = new Point(18, 187);
		this.lblGlassType.Name = "lblGlassType";
		this.lblGlassType.Size = new Size(76, 19);
		this.lblGlassType.TabIndex = 8;
		this.lblGlassType.Text = "Тип стекла";
		// 
		// numSashes
		// 
		this.numSashes.Location = new Point(150, 143);
		this.numSashes.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
		this.numSashes.Name = "numSashes";
		this.numSashes.Size = new Size(170, 25);
		this.numSashes.TabIndex = 7;
		this.numSashes.Value = new decimal(new int[] { 2, 0, 0, 0 });
		this.numSashes.ValueChanged += this.input_ValueChanged;
		// 
		// lblSashes
		// 
		this.lblSashes.AutoSize = true;
		this.lblSashes.Location = new Point(18, 145);
		this.lblSashes.Name = "lblSashes";
		this.lblSashes.Size = new Size(101, 19);
		this.lblSashes.TabIndex = 6;
		this.lblSashes.Text = "Число створок";
		// 
		// cmbMaterial
		// 
		this.cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cmbMaterial.FormattingEnabled = true;
		this.cmbMaterial.Items.AddRange(new object[] { "Пластик", "Дерево", "Алюминий" });
		this.cmbMaterial.Location = new Point(150, 102);
		this.cmbMaterial.Name = "cmbMaterial";
		this.cmbMaterial.Size = new Size(170, 25);
		this.cmbMaterial.TabIndex = 5;
		this.cmbMaterial.SelectedIndexChanged += this.input_SelectedIndexChanged;
		// 
		// lblMaterial
		// 
		this.lblMaterial.AutoSize = true;
		this.lblMaterial.Location = new Point(18, 105);
		this.lblMaterial.Name = "lblMaterial";
		this.lblMaterial.Size = new Size(72, 19);
		this.lblMaterial.TabIndex = 4;
		this.lblMaterial.Text = "Материал";
		// 
		// numHeight
		// 
		this.numHeight.Location = new Point(150, 62);
		this.numHeight.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
		this.numHeight.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
		this.numHeight.Name = "numHeight";
		this.numHeight.Size = new Size(170, 25);
		this.numHeight.TabIndex = 3;
		this.numHeight.Value = new decimal(new int[] { 140, 0, 0, 0 });
		this.numHeight.ValueChanged += this.input_ValueChanged;
		// 
		// lblHeight
		// 
		this.lblHeight.AutoSize = true;
		this.lblHeight.Location = new Point(18, 64);
		this.lblHeight.Name = "lblHeight";
		this.lblHeight.Size = new Size(77, 19);
		this.lblHeight.TabIndex = 2;
		this.lblHeight.Text = "Высота, см";
		// 
		// numWidth
		// 
		this.numWidth.Location = new Point(150, 24);
		this.numWidth.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
		this.numWidth.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
		this.numWidth.Name = "numWidth";
		this.numWidth.Size = new Size(170, 25);
		this.numWidth.TabIndex = 1;
		this.numWidth.Value = new decimal(new int[] { 120, 0, 0, 0 });
		this.numWidth.ValueChanged += this.input_ValueChanged;
		// 
		// lblWidth
		// 
		this.lblWidth.AutoSize = true;
		this.lblWidth.Location = new Point(18, 26);
		this.lblWidth.Name = "lblWidth";
		this.lblWidth.Size = new Size(84, 19);
		this.lblWidth.TabIndex = 0;
		this.lblWidth.Text = "Ширина, см";
		// 
		// grpResult
		// 
		this.grpResult.Controls.Add(this.lblDetails);
		this.grpResult.Controls.Add(this.lblWholesaleValue);
		this.grpResult.Controls.Add(this.lblWholesale);
		this.grpResult.Controls.Add(this.lblRetailValue);
		this.grpResult.Controls.Add(this.lblRetail);
		this.grpResult.Controls.Add(this.lblAreaValue);
		this.grpResult.Controls.Add(this.lblArea);
		this.grpResult.Font = new Font("Segoe UI", 10F);
		this.grpResult.Location = new Point(404, 70);
		this.grpResult.Name = "grpResult";
		this.grpResult.Size = new Size(359, 267);
		this.grpResult.TabIndex = 4;
		this.grpResult.TabStop = false;
		this.grpResult.Text = "Расчет";
		// 
		// lblDetails
		// 
		this.lblDetails.ForeColor = Color.DimGray;
		this.lblDetails.Location = new Point(18, 172);
		this.lblDetails.Name = "lblDetails";
		this.lblDetails.Size = new Size(320, 55);
		this.lblDetails.TabIndex = 6;
		this.lblDetails.Text = "Детали расчета";
		// 
		// lblWholesaleValue
		// 
		this.lblWholesaleValue.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
		this.lblWholesaleValue.ForeColor = Color.FromArgb(22, 101, 52);
		this.lblWholesaleValue.Location = new Point(153, 112);
		this.lblWholesaleValue.Name = "lblWholesaleValue";
		this.lblWholesaleValue.Size = new Size(185, 30);
		this.lblWholesaleValue.TabIndex = 5;
		this.lblWholesaleValue.Text = "0 ₽";
		this.lblWholesaleValue.TextAlign = ContentAlignment.MiddleRight;
		// 
		// lblWholesale
		// 
		this.lblWholesale.AutoSize = true;
		this.lblWholesale.Location = new Point(18, 118);
		this.lblWholesale.Name = "lblWholesale";
		this.lblWholesale.Size = new Size(100, 19);
		this.lblWholesale.TabIndex = 4;
		this.lblWholesale.Text = "Оптовая цена:";
		// 
		// lblRetailValue
		// 
		this.lblRetailValue.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
		this.lblRetailValue.ForeColor = Color.FromArgb(185, 28, 28);
		this.lblRetailValue.Location = new Point(153, 70);
		this.lblRetailValue.Name = "lblRetailValue";
		this.lblRetailValue.Size = new Size(185, 30);
		this.lblRetailValue.TabIndex = 3;
		this.lblRetailValue.Text = "0 ₽";
		this.lblRetailValue.TextAlign = ContentAlignment.MiddleRight;
		// 
		// lblRetail
		// 
		this.lblRetail.AutoSize = true;
		this.lblRetail.Location = new Point(18, 76);
		this.lblRetail.Name = "lblRetail";
		this.lblRetail.Size = new Size(114, 19);
		this.lblRetail.TabIndex = 2;
		this.lblRetail.Text = "Розничная цена:";
		// 
		// lblAreaValue
		// 
		this.lblAreaValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
		this.lblAreaValue.Location = new Point(153, 31);
		this.lblAreaValue.Name = "lblAreaValue";
		this.lblAreaValue.Size = new Size(185, 23);
		this.lblAreaValue.TabIndex = 1;
		this.lblAreaValue.Text = "0 м²";
		this.lblAreaValue.TextAlign = ContentAlignment.MiddleRight;
		// 
		// lblArea
		// 
		this.lblArea.AutoSize = true;
		this.lblArea.Location = new Point(18, 33);
		this.lblArea.Name = "lblArea";
		this.lblArea.Size = new Size(71, 19);
		this.lblArea.TabIndex = 0;
		this.lblArea.Text = "Площадь:";
		// 
		// menuStrip1
		// 
		this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.settingsToolStripMenuItem, this.exitToolStripMenuItem });
		this.menuStrip1.Location = new Point(0, 0);
		this.menuStrip1.Name = "menuStrip1";
		this.menuStrip1.Size = new Size(800, 24);
		this.menuStrip1.TabIndex = 5;
		this.menuStrip1.Text = "menuStrip1";
		// 
		// settingsToolStripMenuItem
		// 
		this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
		this.settingsToolStripMenuItem.Size = new Size(83, 20);
		this.settingsToolStripMenuItem.Text = "Параметры";
		this.settingsToolStripMenuItem.Click += this.settingsToolStripMenuItem_Click;
		// 
		// exitToolStripMenuItem
		// 
		this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
		this.exitToolStripMenuItem.Size = new Size(54, 20);
		this.exitToolStripMenuItem.Text = "Выход";
		this.exitToolStripMenuItem.Click += this.exitToolStripMenuItem_Click;
		// 
		// FormMain
		// 
		this.AutoScaleDimensions = new SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new Size(800, 348);
		this.Controls.Add(this.grpResult);
		this.Controls.Add(this.grpParameters);
		this.Controls.Add(this.lblTitle);
		this.Controls.Add(this.menuStrip1);
		this.Font = new Font("Segoe UI", 9F);
		this.FormBorderStyle = FormBorderStyle.FixedSingle;
		this.MainMenuStrip = this.menuStrip1;
		this.MaximizeBox = false;
		this.Name = "FormMain";
		this.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Расчет стоимости окна";
		this.Load += this.FormMain_Load;
		this.grpParameters.ResumeLayout(false);
		this.grpParameters.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.numSashes).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numHeight).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numWidth).EndInit();
		this.grpResult.ResumeLayout(false);
		this.grpResult.PerformLayout();
		this.menuStrip1.ResumeLayout(false);
		this.menuStrip1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private System.Windows.Forms.Label lblTitle;
	private System.Windows.Forms.GroupBox grpParameters;
	private System.Windows.Forms.NumericUpDown numWidth;
	private System.Windows.Forms.Label lblWidth;
	private System.Windows.Forms.NumericUpDown numHeight;
	private System.Windows.Forms.Label lblHeight;
	private System.Windows.Forms.ComboBox cmbMaterial;
	private System.Windows.Forms.Label lblMaterial;
	private System.Windows.Forms.NumericUpDown numSashes;
	private System.Windows.Forms.Label lblSashes;
	private System.Windows.Forms.ComboBox cmbGlassType;
	private System.Windows.Forms.Label lblGlassType;
	private System.Windows.Forms.Button btnClear;
	private System.Windows.Forms.GroupBox grpResult;
	private System.Windows.Forms.Label lblArea;
	private System.Windows.Forms.Label lblAreaValue;
	private System.Windows.Forms.Label lblRetail;
	private System.Windows.Forms.Label lblRetailValue;
	private System.Windows.Forms.Label lblWholesale;
	private System.Windows.Forms.Label lblWholesaleValue;
	private System.Windows.Forms.Label lblDetails;
	private MenuStrip menuStrip1;
	private ToolStripMenuItem settingsToolStripMenuItem;
	private ToolStripMenuItem exitToolStripMenuItem;
}

