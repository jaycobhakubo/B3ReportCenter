using B3ReportCenter.Helper;
using B3ReportCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3ReportCenter.ViewModel
{
   public  class ReportTemplateViewModel : Notifier
    {
        private string m_reportTitle;
        private string m_reportTemplateVm;
        private ReportTemplateModel m_reportTemplateModel = new ReportTemplateModel();

        public ReportTemplateViewModel(ReportTemplateModel rptModel)
        {
            ReportTemplate_Vm = rptModel;
            ReportTitle = ReportTemplate_Vm.ReportTitle;

        }

        public ReportTemplateModel ReportTemplate_Vm
        {
            get { return m_reportTemplateModel; }
            set
            {
                m_reportTemplateModel = value;
                RaisePropertyChanged("ReportTemplate_Vm");
            }
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
