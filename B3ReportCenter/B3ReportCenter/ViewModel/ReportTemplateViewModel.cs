using B3ReportCenter.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3ReportCenter.ViewModel
{
    class ReportTemplateViewModel : Notifier
    {
        private string m_reportTitle;

        public ReportTemplateViewModel(string reportTitle)
        {
            ReportTitle = reportTitle;

        }

        public string ReportTitle
        {
            get { return m_reportTitle; }
            set
            {
                m_reportTitle = value;
                RaisePropertyChanged("ReportTitle");
            }

        }

    }
}
