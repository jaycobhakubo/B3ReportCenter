using B3ReportCenter.Helper;
using B3ReportCenter.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3ReportCenter
{
    public class MainWindowViewModel : Notifier
    {
        private ReportViewModel m_reportVm;

        public MainWindowViewModel(B3CenterController controller)
        {
            Controller = controller;
            m_reportVm = new ReportViewModel();
        }


        private B3CenterController Controller
        {
            get;
            set;
        }

        public ReportViewModel ReportVm
        {
            get { return m_reportVm; }
            set
            {
                m_reportVm = value;
                RaisePropertyChanged("ReportVm");

            }
        }
    }
}
