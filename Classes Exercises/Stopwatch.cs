using System;

namespace Classes_Exercises
{
    public class Stopwatch
    {
        private TimeSpan _duration;
        private DateTime _start;

        public void Start()
        {
            _start = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            _duration = (DateTime.Now - _start);
            return _duration;
        }
    }
}