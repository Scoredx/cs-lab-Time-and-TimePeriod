using System;

namespace TimeLib
{
    public struct Time : IEquatable<Time>, IComparable<Time>
    {
        private byte hour, minute, second;
        public readonly byte Hour => hour;
        public  readonly byte Minute => minute;
        public readonly byte Second => second;

        //var check
        public Time(byte _hours, byte _minutes = 0, byte _seconds = 0)
        {
            if (_hours < 0 || _minutes < 0 || _seconds < 0 || _hours > 23 || _minutes > 59 || _seconds > 59)
                throw new ArgumentOutOfRangeException("Czas nie jest wprowadzony poprawnie");

            second = _seconds;
            minute = _minutes;
            hour = _hours;
        }
        //conversion to bytes
        public Time(string time)
        {
            var times = time.Split(':');
            hour = Convert.ToByte(times[0]);
            minute = Convert.ToByte(times[1]);
            second = Convert.ToByte(times[2]);

        }

        //write out
        public override string ToString()
        {
            return $"{hour:00}:{minute:00}:{second:00}";
        }

        //checkIfEqual
        public bool Equals(Time other)
        {
            return hour == other.hour && minute == other.minute && second == other.second;
        }

        public override bool Equals(object obj)
        {
            return obj is Time other && Equals(other);
        }

        //compareBytes
        public int CompareTo(Time other)
        {
            if (hour - other.hour != 0)
            {
                return hour - other.hour;
            }
            if (minute - other.minute != 0)
            {
                return minute - other.minute;
            }
            if (second - other.second != 0)
            {
                return second - other.second;
            }
            return 0;
        }

        //logicOperators
        public static bool operator != (Time t1, Time t2)
        {
            return !(t1 == t2);
        }
        public static bool operator ==(Time t1, Time t2)
        {
            return t1.Equals(t2);
        }
        public static bool operator < (Time t1, Time t2)
        {
            return t1.CompareTo(t2) < 0;

        }
        public static bool operator > (Time t1, Time t2)
        {
            return t1.CompareTo(t2) > 0;

        }
        public static bool operator <=(Time t1, Time t2)
        {
            return t1.CompareTo(t2) <= 0;

        }
        public static bool operator >= (Time t1, Time t2)
        {
            return t1.CompareTo(t2) >= 0;

        }

        public override int GetHashCode()
        {
            return (hour, minute, second).GetHashCode();
        }
    }
}
