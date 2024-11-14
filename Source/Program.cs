// Drakula Csharp theme based By Yhzan
// www.github.com/yhzan95/
// Credits/Thanks to:
// www.draculatheme.com/contribute

using System;
using System.Windows.Forms;

namespace Drakula_Csharp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
