using System;
using System.Collections.Generic;
using System.Text;

namespace LearningLibrary
{
    public class StopWatch
    {
        public DateTime StartTimer;
        public DateTime StopTimer;
        private int increment;
        public string timespan { 
            get
            {                
                var timespan = StopTimer - StartTimer;
                var days = timespan.Days;
                var hours = timespan.Hours; 
                var minutes = timespan.Minutes;
                var seconds = timespan.Seconds;
                return $"Duration is {days} days {hours}:{minutes}:{seconds}";


            }
        }
        public void Start()
        {
            StartTimer = DateTime.Today;
            increment++;
            if (increment == 2)
                throw new InvalidOperationException("You have to stop the timer before start it");
        }
        public void Stop()
        {
            StopTimer = DateTime.Today.AddHours(56);
            increment = 0;           
        }

    }
}
