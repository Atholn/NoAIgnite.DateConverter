using System;
using System.Collections.Generic;
using System.Text;

namespace NoAIgnite
{
    public class DatePair
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public DatePair(DateTime sDate, DateTime eDate)
        {
            startDate = sDate < eDate ? sDate : eDate;
            endDate = sDate < eDate ? eDate : sDate;
        }
    }
}
