using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace HelloAndroidTutorialXML
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
            var aButton = FindViewById<Button>(Resource.Id.aButton);
            var aLabel = FindViewById<TextView>(Resource.Id.helloLabel);
            aButton.Click += (sender, e) => {
                aLabel.Text = "Hello from the button";
            };
        }
    }
}

