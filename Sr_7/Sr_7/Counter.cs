using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sr_7
{
    class Counter
    {
        public int Seconds { set; get; }
        public Counter()
        {
            Seconds = 0;
        }

        public static explicit operator Counter(int num)
        {
            return (Counter)num;
        }

        public static implicit operator int(Counter counter)
        {
            return (int)counter.Seconds;
        }

        public override string ToString()
        {
            return $"Seconds: {Seconds} ";
        }
    }

    class Timer
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Timer()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public static implicit operator Timer(Counter counter)
        {
            Timer timer = new Timer();
            timer.Hours = (counter.Seconds / 3600);
            timer.Minutes = (counter.Seconds % 3600 / 60);
            timer.Seconds = (counter.Seconds % 60);
            return timer;
        }

        public static implicit operator Counter(Timer timer)
        {
            return new Counter { Seconds = timer.Hours * 3600 + timer.Minutes * 60 + timer.Seconds };
        }
        public override string ToString()
        {
            return $"HH: {Hours} MM: {Minutes} SS: {Seconds}";
        }
    }

}
