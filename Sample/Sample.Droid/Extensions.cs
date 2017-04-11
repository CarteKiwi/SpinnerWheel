using System;

namespace Sample.Droid
{
    public static class Extensions
    {
        public static DateTime ToDateTime(this long unixTimeMillis)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddMilliseconds(unixTimeMillis);
        }

        public static string ToString(this Colors color)
        {
            switch (color)
            {
                case Colors.Blue:
                    return "On time";
                default:
                    return string.Empty;
            }
        }
    }
}