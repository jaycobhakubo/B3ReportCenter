using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3ReportCenter.Model
{
    public class ReportParameterModel
    {
        public string DateMonthString { get; set; }
        public string DateDayInt { get; set; }
        public string DateYearInt { get; set; }
        public int Session { get; set; }
        public int AccountNumber { get; set; }
        public string Category { get; set; }
        public int StartingCard { get; set; }
        public string DateTimeHourMin { get; set; }
        public string AMorPM { get; set; }


    }
}
