using System;
using System.Globalization;

namespace CBIS.WriteAPI.Client.Models
{ 
    public class Occasion
    {
        public Occasion(DateTime? start, DateTime? end, TimeSpan startTime, TimeSpan duration, int? arenaId,
            bool monday, bool tuesday, bool wednesday, bool thursday, bool friday, bool saturday, bool sunday)
        {
            if (duration.Ticks < 0)
            {
                throw new InvalidOperationException("Need a duration, else it does not happen.");
            }

            if (startTime.Ticks < 0)
            {
                throw new InvalidOperationException("Need a startTime, else it never starts.");
            }

            Start = start;
            End = end;
            StartTime = startTime.ToString();
            Duration = duration.ToString();
            Arena = arenaId;
            Monday = monday;
            Tuesday = tuesday;
            Wednesday = wednesday;
            Thursday = thursday;
            Friday = friday;
            Saturday = saturday;
            Sunday = sunday;
        }

        public bool Sunday { get; set; }

        public bool Saturday { get; set; }

        public bool Friday { get; set; }

        public bool Thursday { get; set; }

        public bool Wednesday { get; set; }

        public bool Tuesday { get; set; }

        public bool Monday { get; set; }

        public int? Arena { get; set; }

        public string Duration { get; set; }

        public string StartTime { get; set; }

        public DateTime? End { get; set; }

        public DateTime? Start { get; set; }
    }
}