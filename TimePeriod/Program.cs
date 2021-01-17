using System;
using TimeLib;

namespace TimePeriod
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(9, 14, 00);
            Time t2 = new Time(0,14);
            Time t3 = new Time(4, 14, 0);
            Time t4 = new Time("4:14:00");

            var varFalse = t1.Equals(t2);
            var varTrue = t4.Equals(t3);
            Console.WriteLine("Time1: " + t1);
            Console.WriteLine("Time2: " + t2);
            Console.WriteLine("Time3: " + t3);
            Console.WriteLine("Time4: " + t4);
            Console.WriteLine("Time1 equals Time2: " + varFalse);
            Console.WriteLine("Time3 equals Time4: "  + varTrue);
            Console.WriteLine("Compare Time1 and Time2: " + t1.CompareTo(t2));
            Console.WriteLine("Compare Time3 and Time4: " + t3.CompareTo(t4));
        }
    }
}
