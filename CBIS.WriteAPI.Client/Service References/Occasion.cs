using System;

namespace CBIS.WriteAPI.Client.Generated
{ 
    partial class Occasion
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
            StartTime = startTime;
            Duration = duration;
            Arena = arenaId;
            Monday = monday;
            Tuesday = tuesday;
            Wednesday = wednesday;
            Thursday = thursday;
            Friday = friday;
            Saturday = saturday;
            Sunday = sunday;
        }
    }
}