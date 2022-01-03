using System;

namespace OTools.Helpers
{
    public static class StringHelpers
    {
        public static string GetTimeStringFromSeconds(float seconds, bool useMilliseconds = false)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);

            var timeString = useMilliseconds ? 
                $"{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}:{t.Milliseconds:D3}" : 
                $"{t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}";

            return timeString;
        }
    }
}