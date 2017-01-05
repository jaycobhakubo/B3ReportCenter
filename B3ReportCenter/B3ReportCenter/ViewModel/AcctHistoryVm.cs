using B3ReportCenter.Helper;
using B3ReportCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3ReportCenter.ViewModel
{
    public class AcctHistoryVm : Notifier
    {
        private string m_reportTemplateVm;
        private ReportTemplateModel m_reportTemplateModel = new ReportTemplateModel();

        public AcctHistoryVm(ReportTemplateModel reportTemplateModel)
        {
            ReportTemplate_Vm = reportTemplateModel;
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

        //public string ReportTemplateVm
        //{
        //    get {return m_reportTemplateVm; }
        //set
        //    {
        //        m_reportTemplateVm = value;
        //        RaisePropertyChanged("ReportTemplateVm");
        //    }
        //}
    }
}
