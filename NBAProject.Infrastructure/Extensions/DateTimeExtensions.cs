using System;

namespace NBAProject.Infrastructure.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToTimeAgo(this DateTime dateTime)
        {
            string result;
            var timeSpan = DateTime.Now.Subtract(dateTime.ToLocalTime());

            if (timeSpan <= TimeSpan.FromSeconds(60))
                result = $"{timeSpan.Seconds.ToString()} seconds ago";

            else if (timeSpan <= TimeSpan.FromMinutes(60))
                result = timeSpan.Minutes > 1
                    ? $"about {timeSpan.Minutes.ToString()} minutes ago"
                    : "about a minute ago";

            else if (timeSpan <= TimeSpan.FromHours(24))
                result = timeSpan.Hours > 1
                    ? $"about {timeSpan.Hours.ToString()} hours ago"
                    : "about an hour ago";

            else if (timeSpan <= TimeSpan.FromDays(30))
                result = timeSpan.Days > 1 ? string.Format("about {0} days ago", timeSpan.Days) : "yesterday";

            else if (timeSpan <= TimeSpan.FromDays(365))
                result = timeSpan.Days > 30
                    ? $"about {(timeSpan.Days / 30).ToString()} months ago"
                    : "about a month ago";

            else
                result = timeSpan.Days > 365
                    ? $"about {(timeSpan.Days / 365).ToString()} years ago"
                    : "about a year ago";

            return result;
        }
    }
}