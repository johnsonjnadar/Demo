﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Droid
{

    [Activity( Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true )]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            //System.Threading.Thread.Sleep(8000);
            System.Threading.Thread.Sleep(1000);
            StartActivity(typeof(MainActivity));

        }
    }
}