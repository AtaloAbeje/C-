using System;

namespace _03_Question1___Clock
{
    class Clock
    {
        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        //
        private int minutes;

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }
        //
        private int seconds;

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        //
        private int milliseconds;

        public int Milliseconds
        {
            get { return milliseconds; }
            set { milliseconds = value; }
        }

        public void tick()
        {
            milliseconds = milliseconds + 100;
            seconds = seconds + milliseconds / 1;
            minutes = minutes + seconds / 60;
            hours = hours + minutes / 60;

            milliseconds = milliseconds % 100;
            seconds = seconds % 60;
            minutes = minutes % 60;
            hours = hours % 24;
        }

        public string show()
        {
            return $"The current time is: {Hours}:{Minutes}:{Seconds}:{Milliseconds}";
        }

        public void setMidNight()
        {
            Milliseconds= 0;
            Seconds = 0;
            Minutes = 0;
            Hours = 24;
        }

        public void setMidDay()
        {
            Milliseconds = 0;
            Seconds = 0; 
            Minutes = 0;
            Hours = 12;
        }

        public Clock(int hours, int minutes, int seconds, int miliseconds) // פונקציה לקבלת פרמטרים
        { 
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Milliseconds = miliseconds;
        }
        public Clock() { }

    }
}
