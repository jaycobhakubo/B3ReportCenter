using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace B3ReportCenter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            B3CenterController controller = new B3CenterController();
            //MainWindow wnd = new MainWindow();
            //wnd.Title = "B3 Report Center";
            //wnd.Show();
        }


    }
}
