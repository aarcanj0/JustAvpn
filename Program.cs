using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace JustAvpn
{
    internal static class Program
    {

        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                new ToastContentBuilder()
                    .AddText("O JustAvpn já está em execução!")
                    .AddText("Para abrir o programa novamente, clique no ícone na bandeja do sistema (system tray)")
                    .Show();
            }
            else
            {
                
                Application.Run(new mainWindow());

            }

        }
    }
}
