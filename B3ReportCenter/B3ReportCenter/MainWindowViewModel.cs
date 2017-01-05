using B3ReportCenter.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3ReportCenter
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel(B3CenterController controller)
        {
            Controller = controller;

        }


        private B3CenterController Controller
        {
            get;
            set;
        }

        public ReportViewModel ReportVm
        {
            get;
            set;
        }
    }
}
