using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B3ReportCenter.Helper;
using System.Windows;

namespace B3ReportCenter 
{


    public class B3CenterController : Notifier
    {
        private Window m_mainWindow;

        public B3CenterController()
        {
            CreateWindows();

        }

        private void CreateWindows()
        {
            MainWindow = new MainWindow(new MainWindowViewModel(this));
            MainWindow.Show();
        }

        public Window MainWindow
        {
            get
            {
                return m_mainWindow;
            }
            private set
            {
                m_mainWindow = value;
                RaisePropertyChanged("MainWindow");
            }
        }

    }
}
