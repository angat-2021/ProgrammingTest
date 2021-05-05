using System;

namespace Exercise
{
    public class Stopwatch
    {
        private DateTime startTime;
        private DateTime endTime;
        private bool running;
        public void Start()
        {
            if (running)
                throw new InvalidOperationException("Stopwatch is already running");
                 
                startTime =DateTime.Now;
                running = true;          
        }
        public void Stop()
        {
            if (!running)
                throw new InvalidOperationException("Stopwatch is not running");
            
                endTime = DateTime.Now;
                running = false;           
        }
        public TimeSpan Interval()
        {          
            return endTime - startTime;
        }
    }
}
