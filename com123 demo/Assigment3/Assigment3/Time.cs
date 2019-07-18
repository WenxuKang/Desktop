using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreDemo
{
    public class Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
        {
            return Hours + Minutes + " " + Seconds;
        }
        public static bool operator ==(Time lhs, Time rhs)
        {
            int l = lhs.Hours * 60 + lhs.Minutes;
            int r = rhs.Hours * 60 + rhs.Minutes;
            if ((l - r) > 15 || (l - r) < -15)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool operator !=(Time lhs, Time rhs)
        {
            int l = lhs.Hours * 60 + lhs.Minutes;
            int r = rhs.Hours * 60 + rhs.Minutes;
            if ((l - r) > 15 || (l - r) < -15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}