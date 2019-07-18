using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Employee
    {
        private decimal _HoulyPayRate = 20.00M;
        public decimal HourlyPayRate{get => _HoulyPayRate ; }

        public decimal AccordiWeeklyPay
        {


            get
            {
                decimal Pay = 0M;
                Pay += (decimal)HoursWorked * HourlyPayRate;
                Pay += (decimal)OverTimeHours * HourlyPayRate;
                return Pay;
            }

            }
           private decimal _hoursWorked;
        public double HoursWorked { get => _hoursWorked; }


        public double _OverTimeHours;
        public double OverTimeHours { get => _OverTimeHours; }

        private DateTime _TimeClockedIn;

        public void ClockIn()
        {
            _TimeClockedIn = DateTime.Now;
        }
        public void ClockOut()
        {
            TimeSpan hoursWorkedToday = DateTime.Now - _TimeClockedIn;
            _hoursWorked += hoursWorkedToday.TotalHours;

            if (HoursWorked + hoursWorkedToday.TotalHours <= 40)
            {
                _hoursWorked += hoursWorkedToday.TotalHours;

            }
            else
            {
                _OvertimeHours += hoursWorkedToday.TotalHours - (40 - HoursWorked);
                _HoursWorked = 40;
            }
        }
    }
}