using Android.Content;
using Android.Views;
using Android.Widget;
using Antistatic.Spinnerwheel.Adapters;
using Java.Lang;
using Java.Util;
using System;
using System.Globalization;
using Calendar = Java.Util.Calendar;

namespace Sample.Droid.Adapters
{
    public sealed class DayArrayAdapter : AbstractWheelTextAdapter
    {
        // Count of days to be shown
        private const int DaysCount = 365;

        // Calendar
        private readonly Calendar _calendar;

        public DayArrayAdapter(Context context, Calendar calendar) : base(context, Resource.Layout.time_picker_custom_day, NoResource)
        {
            _calendar = calendar;
            ItemTextResource = Resource.Id.time2_monthday;
        }

        public int GetToday()
        {
            return 0;
        }

        public int GetIndexFromValue(DateTime date)
        {
            if (date < DateTime.UtcNow)
                return 0;

            return date.DayOfYear - DateTime.UtcNow.DayOfYear;
        }

        public override View GetItem(int index, View cachedView, ViewGroup parent, int currentItemIdx)
        {
            int day = index;
            Calendar newCalendar = (Calendar)_calendar.Clone();
            newCalendar.Roll(CalendarField.DayOfYear, day);

            View view = base.GetItem(index, cachedView, parent, currentItemIdx);

            TextView monthday = (TextView)view.FindViewById(Resource.Id.time2_monthday);

            if (day == 0)
            {
                monthday.Text = "Today";
            }
            else
            {
                monthday.Text = newCalendar.Time.Time.ToDateTime().ToString("ddd dd MMMM", CultureInfo.CurrentUICulture);
            }

            view.Tag = newCalendar.Time.Time.ToDateTime().ToShortDateString();

            return view;
        }

        public override int ItemsCount => DaysCount + 1;

        public override ICharSequence GetItemTextFormatted(int index)
        {
            var newCalendar = (Calendar)_calendar.Clone();
            newCalendar.Roll(CalendarField.DayOfYear, index);
            var text = newCalendar.Time.Time.ToDateTime().ToShortDateString();
            return new Java.Lang.String(text);
        }
    }
}