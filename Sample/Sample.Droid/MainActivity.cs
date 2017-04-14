using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Sample.Droid.Controls;
using System;
using System.Windows.Input;

namespace Sample.Droid
{
    [Activity(Label = "Sample.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, View.IOnClickListener
    {
        public DateTime SelectedDate { get; set; }
        public ICommand SetDateCommand { get; set; }

        private WheelPicker _wheel;
        private TextView _textDate;
        private TextView _textTime;
        private Button _btn;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _textDate = FindViewById<TextView>(Resource.Id.txtDate);
            _btn = FindViewById<Button>(Resource.Id.btn);
            _wheel = FindViewById<WheelPicker>(Resource.Id.wheelPicker);

            _btn.SetOnClickListener(this);

            SetDateCommand = new Command<DateTime>(OnDateSelected);
        }

        private void OnDateSelected(DateTime date)
        {
            SelectedDate = date;
            _textDate.Text = date.ToLongDateString() + " " + date.ToShortTimeString();
        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.btn:
                    _wheel.SetValue(SelectedDate);
                    _wheel.Show();
                    _wheel.ValidateCommand = SetDateCommand;
                    break;
            }
        }
    }
}

