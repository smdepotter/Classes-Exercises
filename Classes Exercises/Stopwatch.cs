using System;

namespace Classes_Exercises
{
    public class Stopwatch
    {
        private DateTime _start;
        private bool _hasStarted;

        public void Start()
        {
            if (_hasStarted)
                throw new InvalidOperationException("You have already started");
            _start = DateTime.Now;
            _hasStarted = true;
        }

        public TimeSpan Stop()
        {
            if(!_hasStarted)
                throw new InvalidOperationException("You have not started");
            _hasStarted = false;
            return DateTime.Now - _start;
        }
    }
}