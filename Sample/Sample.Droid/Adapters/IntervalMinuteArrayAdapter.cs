using Android.Content;
using Android.Views;
using Android.Widget;
using Antistatic.Spinnerwheel.Adapters;
using Java.Lang;

namespace Sample.Droid.Adapters
{
    public sealed class IntervalMinuteArrayAdapter : AbstractWheelTextAdapter
    {
        // Count of days to be shown
        private readonly int _itemsCount;
        private readonly int _interval;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Context</param>
        /// <param name="interval">Interval between 2 items (in minutes)</param>
        /// <param name="itemsCount">Number of items</param>
        public IntervalMinuteArrayAdapter(Context context, int interval, int itemsCount) : base(context, Resource.Layout.time_picker_custom_day, NoResource)
        {
            _interval = interval;
            _itemsCount = itemsCount;
            ItemTextResource = Resource.Id.time2_monthday;
        }

        public override View GetItem(int index, View cachedView, ViewGroup parent, int currentItemIdx)
        {
            View view = base.GetItem(index, cachedView, parent, currentItemIdx);

            TextView monthday = (TextView)view.FindViewById(Resource.Id.time2_monthday);

            monthday.Text = (index * _interval).ToString("D2");

            view.Tag = index * _interval;

            return view;
        }

        public override int ItemsCount => _itemsCount + 1;

        public override ICharSequence GetItemTextFormatted(int index)
        {
            return new String((index * _interval).ToString());
        }
    }
}