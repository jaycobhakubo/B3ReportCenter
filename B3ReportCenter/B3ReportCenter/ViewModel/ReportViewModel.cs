using B3ReportCenter.Helper;
using B3ReportCenter.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace B3ReportCenter.ViewModel
{
    public class ReportViewModel : Notifier
    {

        private AcctHistoryView m_acctHistory; 

        public ReportViewModel()
        {
            m_acctHistory = new AcctHistoryView();
            SelectedReportView = m_acctHistory;
        }

        private UserControl m_selectedReportView = new UserControl();


        public UserControl SelectedReportView
        {
            get
            {
                return m_selectedReportView;
            }
            set
            {

                m_selectedReportView = value;
                RaisePropertyChanged("SelectedReportView");
            }
        }
    }
}
