using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using Antistatic.Spinnerwheel;
using Antistatic.Spinnerwheel.Adapters;
using Java.Util;
using System;
using System.Globalization;
using System.Windows.Input;
using Sample.Droid.Adapters;
using Calendar = Java.Util.Calendar;

namespace Sample.Droid.Controls
{
    public class WheelPicker : RelativeLayout, View.IOnClickListener
    {
        private static readonly bool IsFr = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "fr";
        private TranslateAnimation _animation;
        private WheelVerticalView _daySpinner;
        private AbstractWheelView _hoursSpinner;
        private AbstractWheelView _minSpinner;
        private AbstractWheel _ampm;
        private readonly int _hourStartIndex = IsFr ? 0 : 1;
        private readonly int _hourLastIndex = IsFr ? 23 : 12;

        public Button CancelButton { get; set; }
        public Button ValidateButton { get; set; }
        public LinearLayout Menu { get; set; }

        public ICommand ValidateCommand { get; set; }

        public WheelPicker(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            Init();
        }

        public WheelPicker(Context context) : base(context)
        {
            Init();
        }

        public WheelPicker(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Init();
        }

        public WheelPicker(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            Init();
        }

        public WheelPicker(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
            Init();
        }

        public void Init(Drawable imageSource = null, string text = "", string scope = "")
        {
            Inflate(Context, Resource.Layout.WheelPicker, this);

            var title = (Button)FindViewById(Resource.Id.alertButton);
            title.Text = "Picker";

            CancelButton = (Button)FindViewById(Resource.Id.cancelButton);
            ValidateButton = (Button)FindViewById(Resource.Id.validateButton);
            Menu = (LinearLayout)FindViewById(Resource.Id.menu);

            CancelButton.Text = "Cancel";
            ValidateButton.Text = "Validate";

            CancelButton.SetOnClickListener(this);
            ValidateButton.SetOnClickListener(this);

            // set current time
            Calendar calendar = Calendar.GetInstance(Locale.Us);

            _ampm = (AbstractWheel)FindViewById(Resource.Id.ampmSpinner);

            if (IsFr)
            {
                _ampm.Visibility = ViewStates.Gone;
            }
            else
            {
                _ampm.Visibility = ViewStates.Visible;

                var am = new JavaObjectWrapper<string> { Obj = "AM" };
                var pm = new JavaObjectWrapper<string> { Obj = "PM" };

                var ampmAdapter = new ArrayWheelAdapter(Context, new Java.Lang.Object[] { am.Obj, pm.Obj })
                {
                    ItemResource = Resource.Layout.WheelTextCentered,
                    ItemTextResource = Resource.Id.text
                };

                _ampm.ViewAdapter = ampmAdapter;
                _ampm.ScrollingFinished += OnScrollingFinished();
            }

            _daySpinner = (WheelVerticalView)FindViewById(Resource.Id.daySpinner);
            var dayAdapter = new DayArrayAdapter(Context, calendar);
            _daySpinner.ViewAdapter = dayAdapter;
            _daySpinner.SetCurrentItem(dayAdapter.GetToday(), true);
            _daySpinner.SetActiveCoeff(0);
            _daySpinner.SetPassiveCoeff(.5f);
            _daySpinner.ScrollingFinished += OnScrollingFinished();

            _hoursSpinner = (AbstractWheelView)FindViewById(Resource.Id.hourSpinner);
            _hoursSpinner.ViewAdapter = new NumericWheelAdapter(Context, _hourStartIndex, _hourLastIndex, "%02d");
            ((NumericWheelAdapter)_hoursSpinner.ViewAdapter).ItemResource = Resource.Layout.time_picker_custom_day;
            ((NumericWheelAdapter)_hoursSpinner.ViewAdapter).ItemTextResource = Resource.Id.time2_monthday;
            _hoursSpinner.Cyclic = true;
            _hoursSpinner.SetActiveCoeff(0);
            _hoursSpinner.SetPassiveCoeff(.5f);
            _hoursSpinner.ScrollingFinished += OnScrollingFinished();

            _minSpinner = (AbstractWheelView)FindViewById(Resource.Id.minSpinner);
            _minSpinner.ViewAdapter = new IntervalMinuteArrayAdapter(Context, 15, 3);
            _minSpinner.Cyclic = true;
            _minSpinner.SetActiveCoeff(0);
            _minSpinner.SetPassiveCoeff(.5f);
            _minSpinner.ScrollingFinished += OnScrollingFinished();

            SetDefault();
            Hide();
        }

        private EventHandler<ScrollingFinishedEventArgs> OnScrollingFinished()
        {
            return (sender, args) =>
            {
                if (!IsValid())
                    SetDefault();
            };
        }

        private void SetDefault()
        {
            var hourIndex = DateTime.Now.Hour - _hourStartIndex;

            // Set index corresponding to the current hour (index start at 0).
            _hoursSpinner.SetCurrentItem(hourIndex, true);

            // Get index corresponding to the current minute.
            var minuteIndex = (int)Math.Round((double)DateTime.Now.Minute / 15, 0);

            // Increment to get index of the next entry.
            minuteIndex++;

            // If no entry available for the current hour.
            if (minuteIndex > 3)
            {
                // Next available value is the following hour.
                minuteIndex = 0;
                hourIndex++;

                if (hourIndex > _hourLastIndex)
                    hourIndex = 0;

                _hoursSpinner.SetCurrentItem(hourIndex, true);
            }

            _minSpinner.SetCurrentItem(minuteIndex, true);

            // Set AM or PM
            _ampm.SetCurrentItem(DateTime.Now.Hour > 12 ? 1 : 0, true);
        }

        private bool IsValid()
        {
            return GetSelectedDate() > DateTime.Now;
        }

        private DateTime GetSelectedDate()
        {
            var day = ((DayArrayAdapter)_daySpinner.ViewAdapter).GetItemText(_daySpinner.CurrentItem);
            DateTime dayTime;
            DateTime.TryParse(day, out dayTime);
            var hour = int.Parse(((NumericWheelAdapter)_hoursSpinner.ViewAdapter).GetItemText(_hoursSpinner.CurrentItem));

            if (!IsFr)
            {
                if (_ampm.CurrentItem == 0 && hour == 12)
                    hour = 0;

                if (_ampm.CurrentItem == 1 && hour != 12)
                    hour = hour + 12;
            }

            var minute = int.Parse(((IntervalMinuteArrayAdapter)_minSpinner.ViewAdapter).GetItemText(_minSpinner.CurrentItem));

            var date = new DateTime(dayTime.Year, dayTime.Month, dayTime.Day, hour, minute, 0);

            return date;
        }

        public void OnClick(View v)
        {
            if (v.Id == Resource.Id.cancelButton)
            {
                Hide();
            }
            else if (v.Id == Resource.Id.validateButton)
            {
                ValidateCommand.Execute(GetSelectedDate());

                Hide();
            }
        }

        public void SetValue(DateTime value)
        {
            _daySpinner = (WheelVerticalView)FindViewById(Resource.Id.daySpinner);
            var index = ((DayArrayAdapter)_daySpinner.ViewAdapter).GetIndexFromValue(value);
            _daySpinner.SetCurrentItem(index, true);

            _hoursSpinner = (AbstractWheelView)FindViewById(Resource.Id.hourSpinner);
            _hoursSpinner.SetCurrentItem(value.Hour - 1, true);

            _minSpinner = (AbstractWheelView)FindViewById(Resource.Id.minSpinner);
            _minSpinner.SetCurrentItem(value.Minute / 15, true);

            _ampm = (AbstractWheelView)FindViewById(Resource.Id.ampmSpinner);
            _ampm.SetCurrentItem(value.Hour > 12 ? 1 : 0, true);
        }

        private void Hide()
        {
            _animation = new TranslateAnimation(0, 0, 0, Menu.Height)
            {
                Duration = 300
            };

            _animation.AnimationEnd += Anim_AnimationEnd;

            Menu.StartAnimation(_animation);
        }

        public void Show()
        {
            Visibility = ViewStates.Visible;

            _animation = new TranslateAnimation(0, 0, Menu.Height, 0)
            {
                Duration = 300,
                FillAfter = true
            };

            Menu.StartAnimation(_animation);
        }

        private void Anim_AnimationEnd(object sender, Animation.AnimationEndEventArgs e)
        {
            _animation.AnimationEnd -= Anim_AnimationEnd;
            Visibility = ViewStates.Gone;
        }
    }
}