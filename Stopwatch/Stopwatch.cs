using System;

namespace Mosh
{
    public class Stopwatch
    {
        private bool _isStarted;
        private DateTime _startTime;
        private DateTime _stopTime;

        private TimeSpan TimeSpan
        {
            get => _stopTime - _startTime;
            set => TimeSpan = _stopTime - _startTime;
        }

        public int Duration
        {
            get
            {
                var duration = (_stopTime - _startTime).Seconds;
                return duration;

            }
        }

        public Stopwatch()
        {
            _isStarted = false;
        }


        public void Start()
        {
            if (!_isStarted)
            {
                _isStarted = true;
                _startTime = (Duration > 0) ? _startTime : DateTime.Now;
                Console.WriteLine("Stopwatch started");

            }
            else
            {
                throw new InvalidOperationException("STOPWATCH ALREADY STARTED");
            }
        }

        public void Stop()
        {
            if (_isStarted)
            {
                _isStarted = false;
                _stopTime = DateTime.Now;
                Console.WriteLine("Stopwatch stopped");
            }
            else
            {
                throw new InvalidOperationException("STOPWATCH ALREADY STOPPED");
            }
        }

        public void Reset()
        {
            _isStarted = false;
            _startTime = DateTime.Now;
            _stopTime = _startTime;
            Console.WriteLine("Stopwatch reset");
        }
    }
}