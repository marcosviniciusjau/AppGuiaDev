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

namespace AppGuiaDev.Droid
{
    [Activity(Label = "SpalshScreen", MainLauncher = true, NoHistory = true)]
    public class SpalshScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(new Intent(Aplication.Context, typeof(MainActivity)))

            // Create your application here
        }
    }
}