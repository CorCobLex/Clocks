using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.Timers;

namespace Clocks
{
    public partial class MainPage : ContentPage
    {
        private int _seconds;
        private int _minutes;
        private int _hours;

        public MainPage()
        {
            InitializeComponent();
            //var timeNow = DateTime.Now;
            //secon.WidthRequest = timeNow.Second * 6;
            //minutes.WidthRequest = timeNow.Minute * 6;
            //hours.WidthRequest = timeNow.Hour * 12;
            InitTimer();
            BindingContext = true;

        }

        public int Seconds
        {
            get => _seconds;
            set
            {
                _seconds = value;
                OnPropertyChanged();
            }
        }

        public int Minutes
        {
            get => _minutes;
            set
            {
                _minutes = value;
                OnPropertyChanged();
            }
        }

        public int Hours
        {
            get => _hours;
            set
            {
                _hours = value;
                OnPropertyChanged();
            }
        }

        private void InitTimer()
        {
            var timer = new Timer(1000);
            timer.Elapsed += Update;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void Update(object sender, ElapsedEventArgs e)
        {
            var timeNow = DateTime.Now;

            _hours = timeNow.Hour;
            _minutes = timeNow.Minute;
            _seconds = timeNow.Second;
   
            



        }
    }
}
