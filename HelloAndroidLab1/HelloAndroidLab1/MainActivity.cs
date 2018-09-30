using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace HelloAndroidLab1
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
            var bLabel = new TextView(this);
            bLabel.SetText(Resource.String.bLabelDefaultText);
            var clearButton = new Button(this);
            clearButton.SetText(Resource.String.clearButtonText);
            aButton.Click += (sender, e) =>
            {
                aLabel.SetText(Resource.String.helloMessage);
                bLabel.SetText(Resource.String.helloMessage);
            };
            clearButton.Click += (sender, e) =>
            {
                aLabel.Text = "";
                bLabel.Text = "";
            };
            layout.AddView(aLabel);
            layout.AddView(aButton);
            layout.AddView(bLabel);
            layout.AddView(clearButton);
            SetContentView(layout);
        }
    }
}

