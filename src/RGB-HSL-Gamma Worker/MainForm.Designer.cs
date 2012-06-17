namespace NFG.RGB_HSL_Gamma_Worker
{
  partial class MainForm
  {
    private global::System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if(disposing)
      {
        if(this.components != null)
        {
          this.components.Dispose();
        }
      }

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.groupBoxRgb = new System.Windows.Forms.GroupBox();
      this.buttonReset = new System.Windows.Forms.Button();
      this.buttonCopyRgb = new System.Windows.Forms.Button();
      this.groupBoxBlue = new System.Windows.Forms.GroupBox();
      this.colorSliderBlue = new NFG.RGB_HSL_Gamma_Worker.ColorSlider();
      this.groupBoxGreen = new System.Windows.Forms.GroupBox();
      this.colorSliderGreen = new NFG.RGB_HSL_Gamma_Worker.ColorSlider();
      this.groupBoxRed = new System.Windows.Forms.GroupBox();
      this.colorSliderRed = new NFG.RGB_HSL_Gamma_Worker.ColorSlider();
      this.groupBoxHsl = new System.Windows.Forms.GroupBox();
      this.buttonCopyHsl = new System.Windows.Forms.Button();
      this.groupBoxLuminance = new System.Windows.Forms.GroupBox();
      this.colorSliderLuminance = new NFG.RGB_HSL_Gamma_Worker.ColorSlider();
      this.groupBoxSaturation = new System.Windows.Forms.GroupBox();
      this.colorSliderSaturation = new NFG.RGB_HSL_Gamma_Worker.ColorSlider();
      this.groupBoxHue = new System.Windows.Forms.GroupBox();
      this.colorSliderHue = new NFG.RGB_HSL_Gamma_Worker.ColorSlider();
      this.groupBoxGamma = new System.Windows.Forms.GroupBox();
      this.buttonCopy = new System.Windows.Forms.Button();
      this.groupBoxGammaBlue = new System.Windows.Forms.GroupBox();
      this.numericUpDownGammaBlue = new System.Windows.Forms.NumericUpDown();
      this.groupBoxGammaRed = new System.Windows.Forms.GroupBox();
      this.numericUpDownGammaRed = new System.Windows.Forms.NumericUpDown();
      this.groupBoxGammaGreen = new System.Windows.Forms.GroupBox();
      this.numericUpDownGammaGreen = new System.Windows.Forms.NumericUpDown();
      this.groupBoxPreview = new System.Windows.Forms.GroupBox();
      this.groupBoxSwatch = new System.Windows.Forms.GroupBox();
      this.groupBoxCode = new System.Windows.Forms.GroupBox();
      this.buttonCopyCode = new System.Windows.Forms.Button();
      this.textBoxCode = new System.Windows.Forms.TextBox();
      this.buttonAbout = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBoxRgb.SuspendLayout();
      this.groupBoxBlue.SuspendLayout();
      this.groupBoxGreen.SuspendLayout();
      this.groupBoxRed.SuspendLayout();
      this.groupBoxHsl.SuspendLayout();
      this.groupBoxLuminance.SuspendLayout();
      this.groupBoxSaturation.SuspendLayout();
      this.groupBoxHue.SuspendLayout();
      this.groupBoxGamma.SuspendLayout();
      this.groupBoxGammaBlue.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGammaBlue)).BeginInit();
      this.groupBoxGammaRed.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGammaRed)).BeginInit();
      this.groupBoxGammaGreen.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGammaGreen)).BeginInit();
      this.groupBoxCode.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 432);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(571, 22);
      this.statusStrip1.TabIndex = 0;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // groupBoxRgb
      // 
      this.groupBoxRgb.Controls.Add(this.buttonReset);
      this.groupBoxRgb.Controls.Add(this.buttonCopyRgb);
      this.groupBoxRgb.Controls.Add(this.groupBoxBlue);
      this.groupBoxRgb.Controls.Add(this.groupBoxGreen);
      this.groupBoxRgb.Controls.Add(this.groupBoxRed);
      this.groupBoxRgb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxRgb.Location = new System.Drawing.Point(12, 12);
      this.groupBoxRgb.Name = "groupBoxRgb";
      this.groupBoxRgb.Size = new System.Drawing.Size(224, 201);
      this.groupBoxRgb.TabIndex = 1;
      this.groupBoxRgb.TabStop = false;
      this.groupBoxRgb.Text = "RGB";
      // 
      // buttonReset
      // 
      this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonReset.Location = new System.Drawing.Point(143, 172);
      this.buttonReset.Name = "buttonReset";
      this.buttonReset.Size = new System.Drawing.Size(75, 23);
      this.buttonReset.TabIndex = 4;
      this.buttonReset.Text = "&Reset";
      this.buttonReset.UseVisualStyleBackColor = true;
      // 
      // buttonCopyRgb
      // 
      this.buttonCopyRgb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCopyRgb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCopyRgb.Location = new System.Drawing.Point(6, 172);
      this.buttonCopyRgb.Name = "buttonCopyRgb";
      this.buttonCopyRgb.Size = new System.Drawing.Size(131, 23);
      this.buttonCopyRgb.TabIndex = 3;
      this.buttonCopyRgb.Text = "Copy R&GB";
      this.buttonCopyRgb.UseVisualStyleBackColor = true;
      // 
      // groupBoxBlue
      // 
      this.groupBoxBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxBlue.Controls.Add(this.colorSliderBlue);
      this.groupBoxBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxBlue.Location = new System.Drawing.Point(6, 121);
      this.groupBoxBlue.Name = "groupBoxBlue";
      this.groupBoxBlue.Size = new System.Drawing.Size(212, 45);
      this.groupBoxBlue.TabIndex = 2;
      this.groupBoxBlue.TabStop = false;
      this.groupBoxBlue.Text = "Blue";
      // 
      // colorSliderBlue
      // 
      this.colorSliderBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.colorSliderBlue.Location = new System.Drawing.Point(6, 19);
      this.colorSliderBlue.MaximumSize = new System.Drawing.Size(0, 20);
      this.colorSliderBlue.MinimumSize = new System.Drawing.Size(200, 20);
      this.colorSliderBlue.Name = "colorSliderBlue";
      this.colorSliderBlue.Size = new System.Drawing.Size(200, 20);
      this.colorSliderBlue.TabIndex = 0;
      // 
      // groupBoxGreen
      // 
      this.groupBoxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxGreen.Controls.Add(this.colorSliderGreen);
      this.groupBoxGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxGreen.Location = new System.Drawing.Point(6, 70);
      this.groupBoxGreen.Name = "groupBoxGreen";
      this.groupBoxGreen.Size = new System.Drawing.Size(212, 45);
      this.groupBoxGreen.TabIndex = 1;
      this.groupBoxGreen.TabStop = false;
      this.groupBoxGreen.Text = "Green";
      // 
      // colorSliderGreen
      // 
      this.colorSliderGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.colorSliderGreen.Location = new System.Drawing.Point(6, 19);
      this.colorSliderGreen.MaximumSize = new System.Drawing.Size(0, 20);
      this.colorSliderGreen.MinimumSize = new System.Drawing.Size(200, 20);
      this.colorSliderGreen.Name = "colorSliderGreen";
      this.colorSliderGreen.Size = new System.Drawing.Size(200, 20);
      this.colorSliderGreen.TabIndex = 0;
      // 
      // groupBoxRed
      // 
      this.groupBoxRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxRed.Controls.Add(this.colorSliderRed);
      this.groupBoxRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxRed.Location = new System.Drawing.Point(6, 19);
      this.groupBoxRed.Name = "groupBoxRed";
      this.groupBoxRed.Size = new System.Drawing.Size(212, 45);
      this.groupBoxRed.TabIndex = 0;
      this.groupBoxRed.TabStop = false;
      this.groupBoxRed.Text = "Red";
      // 
      // colorSliderRed
      // 
      this.colorSliderRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.colorSliderRed.Location = new System.Drawing.Point(6, 19);
      this.colorSliderRed.MaximumSize = new System.Drawing.Size(0, 20);
      this.colorSliderRed.MinimumSize = new System.Drawing.Size(200, 20);
      this.colorSliderRed.Name = "colorSliderRed";
      this.colorSliderRed.Size = new System.Drawing.Size(200, 20);
      this.colorSliderRed.TabIndex = 0;
      // 
      // groupBoxHsl
      // 
      this.groupBoxHsl.Controls.Add(this.buttonCopyHsl);
      this.groupBoxHsl.Controls.Add(this.groupBoxLuminance);
      this.groupBoxHsl.Controls.Add(this.groupBoxSaturation);
      this.groupBoxHsl.Controls.Add(this.groupBoxHue);
      this.groupBoxHsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxHsl.Location = new System.Drawing.Point(242, 12);
      this.groupBoxHsl.Name = "groupBoxHsl";
      this.groupBoxHsl.Size = new System.Drawing.Size(224, 201);
      this.groupBoxHsl.TabIndex = 2;
      this.groupBoxHsl.TabStop = false;
      this.groupBoxHsl.Text = "HSL";
      // 
      // buttonCopyHsl
      // 
      this.buttonCopyHsl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCopyHsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCopyHsl.Location = new System.Drawing.Point(6, 172);
      this.buttonCopyHsl.Name = "buttonCopyHsl";
      this.buttonCopyHsl.Size = new System.Drawing.Size(212, 23);
      this.buttonCopyHsl.TabIndex = 7;
      this.buttonCopyHsl.Text = "Copy &HSL";
      this.buttonCopyHsl.UseVisualStyleBackColor = true;
      // 
      // groupBoxLuminance
      // 
      this.groupBoxLuminance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxLuminance.Controls.Add(this.colorSliderLuminance);
      this.groupBoxLuminance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxLuminance.Location = new System.Drawing.Point(6, 121);
      this.groupBoxLuminance.Name = "groupBoxLuminance";
      this.groupBoxLuminance.Size = new System.Drawing.Size(212, 45);
      this.groupBoxLuminance.TabIndex = 6;
      this.groupBoxLuminance.TabStop = false;
      this.groupBoxLuminance.Text = "Luminance";
      // 
      // colorSliderLuminance
      // 
      this.colorSliderLuminance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.colorSliderLuminance.Location = new System.Drawing.Point(6, 19);
      this.colorSliderLuminance.MaximumSize = new System.Drawing.Size(0, 20);
      this.colorSliderLuminance.MinimumSize = new System.Drawing.Size(200, 20);
      this.colorSliderLuminance.Name = "colorSliderLuminance";
      this.colorSliderLuminance.Size = new System.Drawing.Size(200, 20);
      this.colorSliderLuminance.TabIndex = 0;
      // 
      // groupBoxSaturation
      // 
      this.groupBoxSaturation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxSaturation.Controls.Add(this.colorSliderSaturation);
      this.groupBoxSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxSaturation.Location = new System.Drawing.Point(6, 70);
      this.groupBoxSaturation.Name = "groupBoxSaturation";
      this.groupBoxSaturation.Size = new System.Drawing.Size(212, 45);
      this.groupBoxSaturation.TabIndex = 5;
      this.groupBoxSaturation.TabStop = false;
      this.groupBoxSaturation.Text = "Saturation";
      // 
      // colorSliderSaturation
      // 
      this.colorSliderSaturation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.colorSliderSaturation.Location = new System.Drawing.Point(6, 19);
      this.colorSliderSaturation.MaximumSize = new System.Drawing.Size(0, 20);
      this.colorSliderSaturation.MinimumSize = new System.Drawing.Size(200, 20);
      this.colorSliderSaturation.Name = "colorSliderSaturation";
      this.colorSliderSaturation.Size = new System.Drawing.Size(200, 20);
      this.colorSliderSaturation.TabIndex = 0;
      // 
      // groupBoxHue
      // 
      this.groupBoxHue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxHue.Controls.Add(this.colorSliderHue);
      this.groupBoxHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxHue.Location = new System.Drawing.Point(6, 19);
      this.groupBoxHue.Name = "groupBoxHue";
      this.groupBoxHue.Size = new System.Drawing.Size(212, 45);
      this.groupBoxHue.TabIndex = 4;
      this.groupBoxHue.TabStop = false;
      this.groupBoxHue.Text = "Hue";
      // 
      // colorSliderHue
      // 
      this.colorSliderHue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.colorSliderHue.Location = new System.Drawing.Point(6, 19);
      this.colorSliderHue.MaximumSize = new System.Drawing.Size(0, 20);
      this.colorSliderHue.MinimumSize = new System.Drawing.Size(200, 20);
      this.colorSliderHue.Name = "colorSliderHue";
      this.colorSliderHue.Size = new System.Drawing.Size(200, 20);
      this.colorSliderHue.TabIndex = 0;
      // 
      // groupBoxGamma
      // 
      this.groupBoxGamma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxGamma.Controls.Add(this.buttonCopy);
      this.groupBoxGamma.Controls.Add(this.groupBoxGammaBlue);
      this.groupBoxGamma.Controls.Add(this.groupBoxGammaRed);
      this.groupBoxGamma.Controls.Add(this.groupBoxGammaGreen);
      this.groupBoxGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxGamma.Location = new System.Drawing.Point(472, 12);
      this.groupBoxGamma.Name = "groupBoxGamma";
      this.groupBoxGamma.Size = new System.Drawing.Size(87, 201);
      this.groupBoxGamma.TabIndex = 3;
      this.groupBoxGamma.TabStop = false;
      this.groupBoxGamma.Text = "Gamma";
      // 
      // buttonCopy
      // 
      this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCopy.Location = new System.Drawing.Point(6, 172);
      this.buttonCopy.Name = "buttonCopy";
      this.buttonCopy.Size = new System.Drawing.Size(75, 23);
      this.buttonCopy.TabIndex = 6;
      this.buttonCopy.Text = "&Copy";
      this.buttonCopy.UseVisualStyleBackColor = true;
      // 
      // groupBoxGammaBlue
      // 
      this.groupBoxGammaBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxGammaBlue.Controls.Add(this.numericUpDownGammaBlue);
      this.groupBoxGammaBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxGammaBlue.Location = new System.Drawing.Point(6, 121);
      this.groupBoxGammaBlue.Name = "groupBoxGammaBlue";
      this.groupBoxGammaBlue.Size = new System.Drawing.Size(75, 45);
      this.groupBoxGammaBlue.TabIndex = 5;
      this.groupBoxGammaBlue.TabStop = false;
      this.groupBoxGammaBlue.Text = "Blue";
      // 
      // numericUpDownGammaBlue
      // 
      this.numericUpDownGammaBlue.Location = new System.Drawing.Point(6, 19);
      this.numericUpDownGammaBlue.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
      this.numericUpDownGammaBlue.Minimum = new decimal(new int[] {
            4096,
            0,
            0,
            -2147483648});
      this.numericUpDownGammaBlue.Name = "numericUpDownGammaBlue";
      this.numericUpDownGammaBlue.Size = new System.Drawing.Size(63, 20);
      this.numericUpDownGammaBlue.TabIndex = 0;
      // 
      // groupBoxGammaRed
      // 
      this.groupBoxGammaRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxGammaRed.Controls.Add(this.numericUpDownGammaRed);
      this.groupBoxGammaRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxGammaRed.Location = new System.Drawing.Point(6, 19);
      this.groupBoxGammaRed.Name = "groupBoxGammaRed";
      this.groupBoxGammaRed.Size = new System.Drawing.Size(75, 45);
      this.groupBoxGammaRed.TabIndex = 3;
      this.groupBoxGammaRed.TabStop = false;
      this.groupBoxGammaRed.Text = "Red";
      // 
      // numericUpDownGammaRed
      // 
      this.numericUpDownGammaRed.Location = new System.Drawing.Point(6, 19);
      this.numericUpDownGammaRed.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
      this.numericUpDownGammaRed.Minimum = new decimal(new int[] {
            4096,
            0,
            0,
            -2147483648});
      this.numericUpDownGammaRed.Name = "numericUpDownGammaRed";
      this.numericUpDownGammaRed.Size = new System.Drawing.Size(63, 20);
      this.numericUpDownGammaRed.TabIndex = 0;
      // 
      // groupBoxGammaGreen
      // 
      this.groupBoxGammaGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxGammaGreen.Controls.Add(this.numericUpDownGammaGreen);
      this.groupBoxGammaGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxGammaGreen.Location = new System.Drawing.Point(6, 70);
      this.groupBoxGammaGreen.Name = "groupBoxGammaGreen";
      this.groupBoxGammaGreen.Size = new System.Drawing.Size(75, 45);
      this.groupBoxGammaGreen.TabIndex = 4;
      this.groupBoxGammaGreen.TabStop = false;
      this.groupBoxGammaGreen.Text = "Green";
      // 
      // numericUpDownGammaGreen
      // 
      this.numericUpDownGammaGreen.Location = new System.Drawing.Point(6, 19);
      this.numericUpDownGammaGreen.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
      this.numericUpDownGammaGreen.Minimum = new decimal(new int[] {
            4096,
            0,
            0,
            -2147483648});
      this.numericUpDownGammaGreen.Name = "numericUpDownGammaGreen";
      this.numericUpDownGammaGreen.Size = new System.Drawing.Size(63, 20);
      this.numericUpDownGammaGreen.TabIndex = 0;
      // 
      // groupBoxPreview
      // 
      this.groupBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxPreview.Location = new System.Drawing.Point(12, 219);
      this.groupBoxPreview.Name = "groupBoxPreview";
      this.groupBoxPreview.Size = new System.Drawing.Size(454, 156);
      this.groupBoxPreview.TabIndex = 4;
      this.groupBoxPreview.TabStop = false;
      this.groupBoxPreview.Text = "Preview";
      // 
      // groupBoxSwatch
      // 
      this.groupBoxSwatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxSwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxSwatch.Location = new System.Drawing.Point(472, 219);
      this.groupBoxSwatch.Name = "groupBoxSwatch";
      this.groupBoxSwatch.Size = new System.Drawing.Size(87, 156);
      this.groupBoxSwatch.TabIndex = 5;
      this.groupBoxSwatch.TabStop = false;
      this.groupBoxSwatch.Text = "Swatch";
      // 
      // groupBoxCode
      // 
      this.groupBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxCode.Controls.Add(this.buttonCopyCode);
      this.groupBoxCode.Controls.Add(this.textBoxCode);
      this.groupBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBoxCode.Location = new System.Drawing.Point(12, 381);
      this.groupBoxCode.Name = "groupBoxCode";
      this.groupBoxCode.Size = new System.Drawing.Size(454, 48);
      this.groupBoxCode.TabIndex = 6;
      this.groupBoxCode.TabStop = false;
      this.groupBoxCode.Text = "Code";
      // 
      // buttonCopyCode
      // 
      this.buttonCopyCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCopyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCopyCode.Location = new System.Drawing.Point(373, 19);
      this.buttonCopyCode.Name = "buttonCopyCode";
      this.buttonCopyCode.Size = new System.Drawing.Size(75, 23);
      this.buttonCopyCode.TabIndex = 1;
      this.buttonCopyCode.Text = "Copy C&ode";
      this.buttonCopyCode.UseVisualStyleBackColor = true;
      // 
      // textBoxCode
      // 
      this.textBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxCode.Location = new System.Drawing.Point(6, 21);
      this.textBoxCode.Name = "textBoxCode";
      this.textBoxCode.Size = new System.Drawing.Size(361, 20);
      this.textBoxCode.TabIndex = 0;
      // 
      // buttonAbout
      // 
      this.buttonAbout.Location = new System.Drawing.Point(6, 19);
      this.buttonAbout.Name = "buttonAbout";
      this.buttonAbout.Size = new System.Drawing.Size(75, 23);
      this.buttonAbout.TabIndex = 7;
      this.buttonAbout.Text = "&About...";
      this.buttonAbout.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.buttonAbout);
      this.groupBox1.Location = new System.Drawing.Point(472, 381);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(87, 48);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(571, 454);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBoxCode);
      this.Controls.Add(this.groupBoxSwatch);
      this.Controls.Add(this.groupBoxPreview);
      this.Controls.Add(this.groupBoxGamma);
      this.Controls.Add(this.groupBoxHsl);
      this.Controls.Add(this.groupBoxRgb);
      this.Controls.Add(this.statusStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "RGB-HSL-Gamma Worker";
      this.groupBoxRgb.ResumeLayout(false);
      this.groupBoxBlue.ResumeLayout(false);
      this.groupBoxGreen.ResumeLayout(false);
      this.groupBoxRed.ResumeLayout(false);
      this.groupBoxHsl.ResumeLayout(false);
      this.groupBoxLuminance.ResumeLayout(false);
      this.groupBoxSaturation.ResumeLayout(false);
      this.groupBoxHue.ResumeLayout(false);
      this.groupBoxGamma.ResumeLayout(false);
      this.groupBoxGammaBlue.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGammaBlue)).EndInit();
      this.groupBoxGammaRed.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGammaRed)).EndInit();
      this.groupBoxGammaGreen.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGammaGreen)).EndInit();
      this.groupBoxCode.ResumeLayout(false);
      this.groupBoxCode.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.GroupBox groupBoxRgb;
    private System.Windows.Forms.Button buttonReset;
    private System.Windows.Forms.Button buttonCopyRgb;
    private System.Windows.Forms.GroupBox groupBoxBlue;
    private System.Windows.Forms.GroupBox groupBoxGreen;
    private System.Windows.Forms.GroupBox groupBoxRed;
    private System.Windows.Forms.GroupBox groupBoxHsl;
    private System.Windows.Forms.Button buttonCopyHsl;
    private System.Windows.Forms.GroupBox groupBoxLuminance;
    private System.Windows.Forms.GroupBox groupBoxSaturation;
    private System.Windows.Forms.GroupBox groupBoxHue;
    private System.Windows.Forms.GroupBox groupBoxGamma;
    private System.Windows.Forms.GroupBox groupBoxPreview;
    private System.Windows.Forms.GroupBox groupBoxSwatch;
    private System.Windows.Forms.GroupBox groupBoxCode;
    private System.Windows.Forms.Button buttonCopyCode;
    private System.Windows.Forms.TextBox textBoxCode;
    private System.Windows.Forms.Button buttonAbout;
    private System.Windows.Forms.Button buttonCopy;
    private System.Windows.Forms.GroupBox groupBoxGammaBlue;
    private System.Windows.Forms.GroupBox groupBoxGammaRed;
    private System.Windows.Forms.GroupBox groupBoxGammaGreen;
    private ColorSlider colorSliderBlue;
    private ColorSlider colorSliderGreen;
    private ColorSlider colorSliderRed;
    private ColorSlider colorSliderLuminance;
    private ColorSlider colorSliderSaturation;
    private ColorSlider colorSliderHue;
    private System.Windows.Forms.NumericUpDown numericUpDownGammaBlue;
    private System.Windows.Forms.NumericUpDown numericUpDownGammaRed;
    private System.Windows.Forms.NumericUpDown numericUpDownGammaGreen;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}
