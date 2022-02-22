using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockExercise
{
    internal class Clock
    {
        public event Action<int> SecondPassed;
        public event Action<int> MinutePassed;
        public event Action<int> HourPassed;
        public event Action<int> DayPassed;
        private int totalSeconds;
        private int secondsInMinute = 60;
        private int secondsInHour = 60 * 60;
        private int secondsInDay = 60 * 60 * 24;

        public Clock(ITimerService timer)
        {
            timer.Tick += OnTick;
        }

        public void OnTick()
        {
            totalSeconds++;
            NotifySecondObservers();
            NotifyMinuteObservers();
            NotifyHourObservers();
            NotifyDayObservers();

        }

        private void NotifyDayObservers()
        {
            if (totalSeconds % secondsInDay == 0)
            {
                DayPassed?.Invoke(totalSeconds / secondsInDay);
            }
        }

        private void NotifyHourObservers()
        {
            if (totalSeconds % secondsInHour == 0)
            {
                HourPassed?.Invoke(totalSeconds / secondsInHour);
            }
        }

        private void NotifyMinuteObservers()
        {
            if (totalSeconds % secondsInMinute == 0)
            {
                MinutePassed?.Invoke(totalSeconds / secondsInMinute);
            }
        }

        private void NotifySecondObservers()
        {
            SecondPassed?.Invoke(totalSeconds);
        }
    }
}
