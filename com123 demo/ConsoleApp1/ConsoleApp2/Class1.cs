using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ParttimeEmplyee:Employee
    {
        private decimal _HoulyPayRate = 20.00M;
        public decimal HourlyPayRate { get => _HoulyPayRate; }

        public decimal AccordiWeeklyPay
        {


            get
            {
                decimal Pay = 0M;
                Pay += (decimal)HoursWorked * HourlyPayRate;
            }

        }
        private decimal _HoursWorked;
        public double HoursWorked { get => _hoursWorked; }


        public double OverTimeHours { get => _OverTimeHours; }

        private DateTime _TimeClockedIn;

        public void ClockIn()
        {
            _TimeClockedIn = DateTime.Now;
        }
        public void ClockOut()
        {
            TimeSpan HoursWorkedToday = DateTime.Now - _TimeClockedIn;
            _hoursWorked += hoursWorkedToday.TotalHours;

            if (HoursWorked + HoursWorkedToday.TotalHours <= 40)
            {
                _hoursWorked += hoursWorkedToday.TotalHours;

            }
            else
            {
                _OverTimeHours += HoursWorkedToday.TotalHours - (17.5 - HoursWorked);
                _HoursWorked = 17.5;
            }
        }
    }
}

