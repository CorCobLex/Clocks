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
        public MainPage()
        {
            InitializeComponent();
            //var timeNow = DateTime.Now;
            //secon.WidthRequest = timeNow.Second * 6;
            //minutes.WidthRequest = timeNow.Minute * 6;
            //hours.WidthRequest = timeNow.Hour * 12;
            InitTimer();

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

   
            secon.WidthRequest = timeNow.Second * 6;
            minutes.WidthRequest = timeNow.Minute * 6;
            hours.WidthRequest = timeNow.Hour * 12;



        }
    }
}
