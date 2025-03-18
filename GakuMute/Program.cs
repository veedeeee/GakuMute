using System;
using System.Windows.Forms;

namespace GakuMute
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]

    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      
      new Form1();
      Application.Run(); // If pass the instance of Form1, Window of Form1 will be appeared
    }
  }
}
