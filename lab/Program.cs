using System;
using System.Windows.Forms;

namespace lab {
static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        SetProcessDPIAware();
        Application.Run(new MainForm());
    }
    
    // ***also dllimport of that function***
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool SetProcessDPIAware();
}
}