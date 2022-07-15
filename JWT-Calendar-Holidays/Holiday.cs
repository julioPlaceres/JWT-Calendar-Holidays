using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_Calendar_Holidays
{
    internal class Holiday
    {
        private string _holidayName;
        private DateTime _holidayDate;

        public Holiday() { }

        public Holiday(string holidayName, DateTime holidayDate)
            : this ()
        {
            _holidayName = holidayName;
            _holidayDate = holidayDate;
        }

        public List<Holiday> GetHolidays(int iterationyear)
        {
            throw new NotImplementedException();
        }

        private DateTime GetDayOfWeek(DateTime holidayeDate, DayOfWeek dayOfWeek, int weekNumber)
        {
            throw new NotImplementedException();
        }
    }
}
