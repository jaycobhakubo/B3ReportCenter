using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using B3ReportCenter.Helper;
using B3ReportCenter.Model;

namespace B3ReportCenter.ViewModel
{
   public class ReportParameterViewModel: Notifier
    {
        private List< ReportParameterModel> m_reportParameterModel;
        private List<string> m_paramList;
        //private List<Visibility> m_ParameterList2;

        public ReportParameterViewModel(List<string> paramlist)
        {
               Months = Enum.GetNames(typeof(Month)).Where(m => m != Month.NotSet.ToString());
               StartingCard = "235456";
               m_paramList = paramlist;
               HideAllparameter();
               HideEnableParamControls(paramlist);      
        }

        private void HideAllparameter()
        {
            DateInput = Visibility.Collapsed;
            MonthYearInput = Visibility.Collapsed;
           StartEndDate = Visibility.Collapsed;
            SessionInput = Visibility.Collapsed;
            AccountNumberInput = Visibility.Collapsed;
            CategoryInput = Visibility.Collapsed;
            StartEndCardInput = Visibility.Collapsed;
            StartEndDateWTime = Visibility.Collapsed;
        }

        private void HideEnableParamControls(List<string> paramlist)
       {
            foreach (string param in paramlist)
            {
                switch (param)
                {

                    case "Date":
                        {
                            DateInput = Visibility.Visible;
                            break;
                        }
                    case "MonthYear":
                        {
                            MonthYearInput = Visibility.Visible;
                            break;
                        }
                    case "StartEndDate":
                        {
                            StartEndDate = Visibility.Visible;
                            break;
                        }
                    case "Session":
                        {
                            SessionInput = Visibility.Visible;
                            break;
                        }
                    case "AccountNumber":
                            {
                                AccountNumberInput = Visibility.Visible;
                                break;
                            }
                    case "Category":
                            {
                                CategoryInput = Visibility.Visible;
                                break;
                            }
                    case "StartEndCard":
                            {
                                StartEndCardInput = Visibility.Visible;
                                break;
                            }
                    case "StartEndDatewTime":
                            {
                                StartEndDateWTime = Visibility.Visible;
                                break;
                            }
                 
                }
            }
       }



        public Visibility StartEndDateWTime
        {
            get;
            set;
        }

        public Visibility StartEndCardInput
        {
            get;
            set;
        }

        public Visibility CategoryInput
        {
            get;
            set;
        }


        public Visibility AccountNumberInput
        {
            get;
            set;
        }


        public Visibility SessionInput
        {
            get;
            set;
        }

        public Visibility StartEndDate
        {
            get;
            set;
        }

        public Visibility MonthYearInput
        {
            get;
            set;
        }

        public Visibility DateInput 
        { 
            get; 
            set; 
        }
       



        private Visibility m_visibility;
        public  Visibility setVisibility
        {
            get { return m_visibility; }
            set { m_visibility = value;
            RaisePropertyChanged("setVisibility");
            }
        }

        public ObservableCollection<ReportParameterModel> reportParameterModel
        {
            get;
            set;
            //get { return m_reportParameterModel; }
            //set { m_reportParameterModel = value;
            //RaisePropertyChanged("reportParameterModel");
            //}
        }

        private IEnumerable<string> m_months; 
   
      public IEnumerable<string> Months
        {
            get
            {
                return m_months;
            }
            set
            {
                m_months = value;
                RaisePropertyChanged("Months");
            }
        }

      private string m_startingCard;
      public string StartingCard
      {
          get { return m_startingCard; }
          set { m_startingCard = value;
          RaisePropertyChanged("StartingCard");
          }
      }
    
    }
}
