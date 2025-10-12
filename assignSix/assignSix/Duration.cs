using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignSix
{
    internal class Duration
    {
        private int houre;
        private int minute;
        private int second;

        public Duration()
        { }
        public Duration(int houre, int minute, int second)
        {
            this.houre = houre;
            this.minute = minute;
            this.second = second;
        }
        public Duration(int a)
        {
            houre = a / 3600;
            minute = (a % 3600) / 60;
            second = (a % 3600) % 60;
        }
        public override string ToString()
        {
            if (houre > 0)
                return $"hours: {houre}, minutes: {minute}, seconds: {second}";
            else if (minute > 0)
                return $"minutes: {minute}, seconds: {second}";
            else
                return $"seconds: {second}";
        }
        public override int GetHashCode()
        {
            return (houre * 3600 + minute * 60 + second).GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(obj is Duration dr)
                return houre == dr.houre && minute == dr.minute && second == dr.second;
            return false;
        }
        //=========================operator========================
        public static Duration operator +(Duration a, Duration b)
        {
            int totalSeconds = (a.houre * 3600 + a.minute * 60 + a.second) + (b.houre * 3600 + b.minute * 60 + b.second);
            return new Duration(totalSeconds);
        }
        public static Duration operator ++(Duration a)
        {
            return new Duration((a.houre * 3600 + a.minute * 60 + a.second) + 60);
        }
        public static Duration operator --(Duration a)
        {
            return new Duration(((a.houre * 3600 + a.minute * 60 + a.second) - 60) > 0 ? (a.houre * 3600 + a.minute * 60 + a.second) - 60 : 0);
        }
        public static Duration operator +(int a, Duration b)
        {
            int totalSeconds = (b.houre * 3600 + b.minute * 60 + b.second) + a;
            return new Duration(totalSeconds);
        }
        public static Duration operator +(Duration a, int b)
        {
            int totalSeconds = ((a.houre * 3600 + a.minute * 60 + a.second)) + b;
            return new Duration(totalSeconds);
        }
        public static Duration operator -(Duration a, Duration b)
        {
            int totalSeconds = (a.houre * 3600 + a.minute * 60 + a.second) - (b.houre * 3600 + b.minute * 60 + b.second);
            return totalSeconds > 0 ? new Duration(totalSeconds) : new Duration(0);
        }
        public static bool operator >(Duration a, Duration b)
        {
            return (a.houre * 3600 + a.minute * 60 + a.second) > (b.houre * 3600 + b.minute * 60 + b.second);
        }
        public static bool operator <(Duration a, Duration b)
        {
            return (a.houre * 3600 + a.minute * 60 + a.second) < (b.houre * 3600 + b.minute * 60 + b.second);
        }
        public static bool operator <=(Duration a, Duration b)
        {
            return (a.houre * 3600 + a.minute * 60 + a.second) <= (b.houre * 3600 + b.minute * 60 + b.second);
        }
        public static bool operator >=(Duration a, Duration b)
        {
            return (a.houre * 3600 + a.minute * 60 + a.second) >= (b.houre * 3600 + b.minute * 60 + b.second);
        }
        public static bool operator true(Duration a)
        {
            return (a.houre * 3600 + a.minute * 60 + a.second) > 0;
        }
        public static bool operator false(Duration a)
        {
            return (a.houre * 3600 + a.minute * 60 + a.second) == 0;
        }
        public static explicit operator DateTime(Duration a)
        {
            DateTime date = new DateTime(2000, 1, 1, 0, 0, 0);
            return date.AddSeconds(a.houre * 3600 + a.minute * 60 + a.second);
        }
    }
}
