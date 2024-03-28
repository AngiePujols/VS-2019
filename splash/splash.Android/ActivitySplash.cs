using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace splash.Droid
{
    Activity(Theme = "@style/Theme.Splash",

              MainLauncher = true,

              NoHistory = true)]

    public class SplashActivity : Activity

    {

        protected override void OnCreate(Bundle bundle)

        {

            base.OnCreate(bundle);

            System.Threading.Thread.Sleep(50);

            StartActivity(typeof(MainActivity));

        }

    }
}