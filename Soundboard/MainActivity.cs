using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Media;
using Android.Content;

namespace Soundboard
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageButton imgBtn1, imgBtn2;
        Button btnExit;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            imgBtn1 = FindViewById<ImageButton>(Resource.Id.imgBtn1);
            imgBtn2 = FindViewById<ImageButton>(Resource.Id.imgBtn2);
            btnExit = FindViewById<Button>(Resource.Id.btnExit);
            Intent samuelActivity = new Intent(this, typeof(SamuelActivity));
            Intent walkenActivity = new Intent(this, typeof(SpaceyActivity));

            imgBtn1.Click += delegate
            {
                StartActivity(samuelActivity);
            };
            imgBtn2.Click += delegate
            {
                StartActivity(walkenActivity);
            };
            btnExit.Click += delegate
            {

                var activity = (Activity)this;
                activity.FinishAffinity();
            };
        }

        
    }
}
