using B3ReportCenter.Helper;
using B3ReportCenter.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using B3ReportCenter.View;

namespace B3ReportCenter.ViewModel
{
   public  class ReportTemplateViewModel : Notifier
    {
    
        private ReportTemplateModel m_reportTemplateModel; //= new ReportTemplateModel();
        private ReportParameterModel m_reportParModel;

        public ReportTemplateViewModel(ReportTemplateModel reportTemplateModel)
        {
            ReportTemplate_Vm = reportTemplateModel;
            ReportTitle = ReportTemplate_Vm.ReportTitle;
            reportParameterList = ReportTemplate_Vm.ReportParameter;
            m_parVm = new ReportParameterViewModel(reportParameterList);
        }

        private List<string> reportParameterList;

        private void SetReportparameter()
        {

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


        private string m_reportTitle;
        public string ReportTitle
        {
            get { return m_reportTitle; }
            set
            {
                if (m_reportTitle != value)
                {
                    m_reportTitle = value;
                    RaisePropertyChanged("ReportTitle");
                }
            }
        }

        private ReportParameterViewModel m_parVm;
        public ReportParameterViewModel parVm
        {
            get { return m_parVm; }
            set { m_parVm = value;
            RaisePropertyChanged("parVm");
            }
        }


        //private ReportParameter m_reportparameterView;
        //public ReportParameter reportParameterView
        //{
        //    get { return m_reportparameterView; }
        //    set
        //    {
        //    m_reportparameterView = value;
        //    RaisePropertyChanged("reportParameterView");
        //    }
        //}


        

     

    }
}
