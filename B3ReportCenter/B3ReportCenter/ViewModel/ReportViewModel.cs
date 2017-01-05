using B3ReportCenter.Helper;
using B3ReportCenter.Model;
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

        private AcctHistoryView m_acctHistoryReportView;


        //private AcctHistoryVm m_acctHistoryVm;

        private ReportTemplate m_acctHistoryView;
        private ReportTemplateViewModel m_acctHistoryVm;
        private ReportTemplateModel m_acctHistoryModel;// = new ReportTemplateModel();

        public ReportViewModel()
        {

            InitializeReports(m_acctHistoryView, m_acctHistoryVm, SetReportM("Account History"));
            LoadReportList();
            //SelectedReportView = m_acctHistoryReportView;
        }

        private ReportTemplateModel SetReportM(string reportTitle)
        {
            ReportTemplateModel reportM = new ReportTemplateModel();
            reportM.ReportTitle = reportTitle;
            return reportM;
        }

        private void InitializeReports(ReportTemplate reportView, ReportTemplateViewModel reportVM, ReportTemplateModel reportModel)
        {
            reportVM = new ReportTemplateViewModel(reportModel);
            reportView = new ReportTemplate(reportVM);
        }


        private List<string> m_reportList = new List<string>();

        public List<string> ReportList
        {
            get { return m_reportList; }
        }

        private void LoadReportList()
        {
            m_reportList.Clear();
            m_reportList.Add("Accounts");
            m_reportList.Add("Account History");
            m_reportList.Add("Ball Call");
            m_reportList.Add("Bingo Card");
            m_reportList.Add("Daily");
            m_reportList.Add("Detail");
            m_reportList.Add("Drawer");
            m_reportList.Add("Jackpot");
            m_reportList.Add("Monthly");
            m_reportList.Add("Session");
            m_reportList.Add("Session Summary");
            m_reportList.Add("Session Transaction");
            m_reportList.Add("Void");
            m_reportList.Add("Winner Cards");
            ReportSelected = m_reportList.FirstOrDefault();
        }

        private string m_reportSelected;
        public string ReportSelected
        {
            get { return m_reportSelected; }
            set
            {
                if (m_reportSelected != value)
                {
                    m_reportSelected = value;
                   
                    SelectionChanged(value);
                    RaisePropertyChanged("ReportSelected");
                }
            }
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

        public  void SelectionChanged(string ReportName)
        {

            UserControl view = null;

            switch (ReportName)
            {
                case "Accounts":
                    {
                        view = m_acctHistoryView;
                        break;
                    }
                //case "Daily":
                //    {
                //        view = m_dailyReportView;
                //        break;
                //    }
                //case "Detail":
                //    {
                //        view = m_detailReportView;
                //        break;
                //    }
                //case "Drawer":
                //    {
                //        view = m_drawerReportView;
                //        break;
                //    }
                //case "Jackpot":
                //    {
                //        view = m_jackpotReportView;
                //        break;
                //    }
                //case "Monthly":
                //    {
                //        view = m_monthlyReportView;
                //        break;
                //    }
                //case "Session":
                //    {
                //        view = m_sessionReportView;
                //        break;
                //    }
                //case "Void":
                //    {
                //        view = m_voidReportView;
                //        break;
                //    }
                //case "Session Summary":
                //    {
                //        view = m_sessionsummaryReportView;
                //        break;
                //    }
                //case "Account History":
                //    {
                //        view = m_accountHistoryReportView;
                //        break;
                //    }
                //case "Winner Cards":
                //    {
                //        view = m_winnerCardsReportView;
                //        break;
                //    }
                //case "Ball Call":
                //    {
                //        view = m_ballCallReportView;
                //        break;
                //    }
                //case "Session Transaction":
                //    {
                //        view = m_sessionTranReportView;
                //        break;
                //    }
                //case "Bingo Card":
                //    {
                //        view = m_bingoCardReportView;
                //        break;
                //    }
            }


            SelectedReportView = view;
        }
    }
}
