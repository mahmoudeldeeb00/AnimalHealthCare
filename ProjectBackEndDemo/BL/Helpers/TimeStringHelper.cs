using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.BL.Helpers
{
    public class TimeStringHelper
    {
        public static string GetTimeSince(DateTime objDateTime)
        {
           
            TimeSpan span = DateTime.Now - objDateTime;
            if (span.Days > 365)
            {
                int years = (span.Days / 365);
                if (span.Days % 365 != 0)
                    years += 1;
                return String.Format("about {0} {1} ago",
                years, years == 1 ? "year" : "years");
            }
            if (span.Days > 30)
            {
                int months = (span.Days / 30);
                if (span.Days % 31 != 0)
                    months += 1;
                return String.Format("about {0} {1} ago",
                months, months == 1 ? "month" : "months");
            }
            if (span.Days > 0)
                return String.Format("about {0} {1} ago",
                span.Days, span.Days == 1 ? "day" : "days");
            if (span.Hours > 0)
                return String.Format("about {0} {1} ago",
                span.Hours, span.Hours == 1 ? "hour" : "hours");
            if (span.Minutes > 0)
                return String.Format("about {0} {1} ago",
                span.Minutes, span.Minutes == 1 ? "minute" : "minutes");
            if (span.Seconds > 5)
                return String.Format("about {0} seconds ago", span.Seconds);
            if (span.Seconds <= 5)
                return "just now";
            return string.Empty;
        }
        public static string GetAgeFromDate(DateTime objDateTime)
        {

            TimeSpan span = DateTime.Now - objDateTime;
            if (span.Days > 365)
            {
                int Days = span.Days;
                int Years = Days / 365;
                Days = Days % 365;
                int months = Days / 30;

                if (months == 0)
                {
                    return String.Format("{0} {1}", Years, Years == 1 ? "year" : "Years");

                }
                return String.Format("{0} {1} and {2} {3} ", Years, Years == 1 ? "year" : "Years", months, months == 1 ? "Month" : "Months");

            }
            if (span.Days > 30)
            {
                int Days = span.Days;
                int months = Days / 30;
                Days = Days % 30;

                if (Days == 0)
                {
                    return String.Format("{0} {1}", months, months == 1 ? "Month" : "Months");

                }
                return String.Format("{0} {1}  and {2} {3} ", months, months == 1 ? "Month" : "Months", Days, Days == 1 ? "Day" : "Days");

            }
            else
            {

                int Days = span.Days;

                return String.Format("{0} Days ", Days);


            }

        }

        public static string GetVetAgeFromDate(DateTime objDateTime)
        {

            TimeSpan span = DateTime.Now - objDateTime;
            int Days = span.Days;
            int Years = Days / 365;
            return String.Format("{0} Years", Years);

        }
    }
}
