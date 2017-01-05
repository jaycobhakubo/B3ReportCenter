using B3ReportCenter.View;
using B3ReportCenter.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3ReportCenter.Model
{
    public class ReportModel
    {
        public  ReportTemplate reportTemplate
        {
            get;
            set;
        }

        public string reportTitle
        { get; set; }
    }
}
