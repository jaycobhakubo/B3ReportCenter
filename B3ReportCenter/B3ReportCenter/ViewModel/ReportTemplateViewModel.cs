using B3ReportCenter.Helper;
using B3ReportCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3ReportCenter.ViewModel
{
   public class ReportTemplateViewModel : Notifier
    {


        public ReportTemplateViewModel(ReportTemplateModel reportTemplateModel)
        {
            ReportTemplate_Vm = reportTemplateModel;

        }

        private ReportTemplateModel m_reportTemplateModel = new ReportTemplateModel();
        public ReportTemplateModel ReportTemplate_Vm
        {
            get { return m_reportTemplateModel; }
            set
            {
                m_reportTemplateModel = value;
                RaisePropertyChanged("ReportTemplate_Vm");
            }
        }
    }
}
