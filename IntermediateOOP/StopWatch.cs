using System;

namespace IntermediateOOP
{
    public class StopWatch
    {
        private DateTime _start;
        private TimeSpan _elapsed;
        public TimeSpan Elapsed
        {
            get
            {
                return _elapsed;
            }
        }
        public void Start()
        {
            if (_start != default)
                throw new InvalidOperationException("StopWatch already started.");

            _start = DateTime.Now;
        }
        public void Stop()
        {
            if (_start == default)
                throw new InvalidOperationException("StopWatch not started.");

            _elapsed = DateTime.Now - _start;
            Reset();
        }
        public void Reset()
        {
            _start = default;
        }
    }
}
