using B3ReportCenter.Helper;
using B3ReportCenter.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace B3ReportCenter.ViewModel
{
   public  class ReportTemplateViewModel : Notifier
    {
        private string m_reportTitle;
        private ReportTemplateModel m_reportTemplateModel; //= new ReportTemplateModel();

        public ReportTemplateViewModel(ReportTemplateModel reportTemplateModel)
        {
            ReportTemplate_Vm = reportTemplateModel;
            ReportTitle = ReportTemplate_Vm.ReportTitle;
            //ReportUserControl = ReportTemplate_Vm.ReportUserControl;
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

        //private UserControl m_reportSelected;
        //public UserControl ReportUserControl
        //{
        //    get { return m_reportSelected; }
        //    set
        //    {
        //        if (m_reportSelected != value)
        //        {
        //            m_reportSelected = value;
        //            RaisePropertyChanged("ReportUserControl");
        //        }
        //    }
        //}

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

        //public void SelectionChanged(ReportTemplateModel reportTemplateModel)
        //{
        //    ReportUserControl = reportTemplateModel.ReportUserControl;
        //    ReportTitle = reportTemplateModel.ReportTitle;
        //}

     

    }
}
