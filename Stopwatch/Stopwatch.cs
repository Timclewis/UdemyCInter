using System;
namespace Stopwatch
{
    public class Stopwatch
    {
        // properties
        private DateTime _startTime;
        private bool _started = false; 
        private DateTime _endTime;
        private TimeSpan _oldDuration;

        public TimeSpan Duration
        {
            get
            {
                var duration = _endTime - _startTime;
                return duration;           
            }
        
        }

        public TimeSpan OldDuration
        {
            get
            {if (_started == true)
                {
                    var oldDuration = _endTime - _startTime;
                    return oldDuration;
                }

            else return TimeSpan.Zero;
            }
        }

        public Stopwatch()
        {

        }

        // methods w/ logic
        public void SetStartTime()
        {if (_started)
            {
                throw new InvalidOperationException("Already started");
            }
        else
            {
                _startTime = DateTime.Now;
                _started = true;
            }
                       
        }

        public void SetEndTime()
        {
            _endTime = DateTime.Now;
            _started = false;
        }       
    }
}
