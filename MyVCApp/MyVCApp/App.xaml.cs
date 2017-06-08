using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyVCApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var composedStr = "";
            for (int i = 0; i != e.Args.Length; ++i)
            {
                composedStr = $"{composedStr} {e.Args[i]}";
            }

            MainWindow mainWindow = new MainWindow();
            mainWindow.Arg.Text = composedStr;
            mainWindow.Show();
        }
    }
}
