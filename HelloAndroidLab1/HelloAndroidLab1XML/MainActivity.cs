using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace HelloAndroidLab1XML
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
            var bLabel = FindViewById<TextView>(Resource.Id.helloLabel2);
            var clearButton = FindViewById<Button>(Resource.Id.clearButton);
            clearButton.Text = "Clear";
            bLabel.SetText(Resource.String.bLabelDefaultText);
            aButton.Click += (sender, e) => {
                aLabel.Text = "Hello from the button";
                bLabel.Text = "Hello from the button";
            };
            clearButton.Click += (sender, e) => {
                aLabel.Text = "";
                bLabel.Text = "";
                };
        }
    }
}

