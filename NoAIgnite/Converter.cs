using System;
using System.Collections.Generic;
using System.Text;

namespace NoAIgnite
{
    public class Converter
    {
        public string Start(string[] args)
        {
            if (!ValidArgs(args)) return "Error! You didnt provide two arguments";

            var parseDate = TryParseDateTimes(args[0], args[1]);
            if (parseDate == null) return "Error! Bad dates format or this are not dates. Correct format date: 'dd.mm.yyyy dd.mm.yyyy'";

            return Convert(parseDate.startDate, parseDate.endDate);
        }

        public bool ValidArgs(string[] args)
        {
            if (args.Length != 2) return false;
            return true;
        }

        public DatePair TryParseDateTimes(string firstDate, string secondDate)
        {
            DateTime dateValue1;
            DateTime dateValue2;

            if (DateTime.TryParse(firstDate, out dateValue1) && DateTime.TryParse(secondDate, out dateValue2))
            {
                DatePair datePair = new DatePair(dateValue1, dateValue2);
                return datePair;
            }
            return null;
        }

        public string Convert(DateTime firstDate, DateTime secondDate)
        {
            if (firstDate.Year != secondDate.Year) return firstDate.ToString("dd.MM.yyyy") + "-" + secondDate.Date.ToString("dd.MM.yyyy");

            if (firstDate.Month != secondDate.Month) return firstDate.ToString("dd.MM") + "-" + secondDate.Date.ToString("dd.MM.yyyy");

            return firstDate.ToString("dd") + "-" + secondDate.Date.ToString("dd.MM.yyyy");
        }
    }
}
