namespace NFG.RGB_HSL_Gamma_Worker
{
  using global::System;
  using global::System.Windows.Forms;

  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      try
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.ToString(), "RGB-HSL-Gamma Worker", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0);
      }
    }
  }
}
