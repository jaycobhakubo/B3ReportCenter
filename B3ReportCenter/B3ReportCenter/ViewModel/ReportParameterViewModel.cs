using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B3ReportCenter.Helper;
using B3ReportCenter.Model;

namespace B3ReportCenter.ViewModel
{
   public class ReportParameterViewModel: Notifier
    {
        private ReportParameterModel m_reportParameterModel;

        public ReportParameterViewModel()
        {
               Months = Enum.GetNames(typeof(Month)).Where(m => m != Month.NotSet.ToString());
               StartingCard = "235456";
        }

        public ReportParameterModel reportParameterModel
        {
            get { return m_reportParameterModel; }
            set { m_reportParameterModel = value; }
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
