namespace NFG.RGB_HSL_Gamma_Worker
{
  partial class ColorSlider
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

    #region Component Designer generated code
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorSlider));
      this.trackBar = new System.Windows.Forms.TrackBar();
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.numericUpDown = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // trackBar
      // 
      resources.ApplyResources(this.trackBar, "trackBar");
      this.trackBar.Maximum = 100;
      this.trackBar.Name = "trackBar";
      this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
      // 
      // pictureBox
      // 
      resources.ApplyResources(this.pictureBox, "pictureBox");
      this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.TabStop = false;
      // 
      // numericUpDown
      // 
      resources.ApplyResources(this.numericUpDown, "numericUpDown");
      this.numericUpDown.MaximumSize = new System.Drawing.Size(50, 0);
      this.numericUpDown.MinimumSize = new System.Drawing.Size(50, 0);
      this.numericUpDown.Name = "numericUpDown";
      // 
      // ColorSlider
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.numericUpDown);
      this.Controls.Add(this.pictureBox);
      this.Controls.Add(this.trackBar);
      this.MaximumSize = new System.Drawing.Size(0, 20);
      this.MinimumSize = new System.Drawing.Size(200, 20);
      this.Name = "ColorSlider";
      ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
      this.ResumeLayout(false);

    }
    #endregion

    private System.Windows.Forms.TrackBar trackBar;
    private System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.NumericUpDown numericUpDown;
  }
}
