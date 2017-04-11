using Android.Content;
using Android.Views;
using Android.Widget;
using Antistatic.Spinnerwheel.Adapters;
using Java.Lang;
using String = Java.Lang.String;

namespace Sample.Droid.Adapters
{
    public sealed class EnumArrayAdapter<T> : AbstractWheelTextAdapter
    {
        // Count of days to be shown
        private readonly T[] _values;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Context</param>
        public EnumArrayAdapter(Context context) : base(context, Resource.Layout.time_picker_custom_day, NoResource)
        {
            _values = (T[])System.Enum.GetValues(typeof(T));

            ItemTextResource = Resource.Id.time2_monthday;
        }

        public override View GetItem(int index, View cachedView, ViewGroup parent, int currentItemIdx)
        {
            View view = base.GetItem(index, cachedView, parent, currentItemIdx);

            TextView monthday = (TextView)view.FindViewById(Resource.Id.time2_monthday);

            monthday.Text = ((T)(System.Enum.Parse(typeof(T), _values[index].ToString()))).ToString();

            return view;
        }

        public override int ItemsCount => _values.Length;

        public override ICharSequence GetItemTextFormatted(int index)
        {
            return new String(_values[index].ToString());
        }
    }
}