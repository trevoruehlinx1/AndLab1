﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace HelloAndroidTutorial
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //Create the user interface in code
            var layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;
            var aLabel = new TextView(this);
            aLabel.SetText(Resource.String.helloLabelText);
            var aButton = new Button(this);
            aButton.SetText(Resource.String.helloButtonText);
            aButton.Click += (sender, e) => {
                aLabel.Text = "Hello from the button";
            };
            layout.AddView(aLabel);
            layout.AddView(aButton);
            SetContentView(layout);
        }
    }
}

