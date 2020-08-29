using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Com.Tapadoo.Alerter;

namespace AlerterDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btn = FindViewById<Button>(Resource.Id.showBtn);
            btn.Click += (sender, args) =>
            {
                Alerter.Create(this)
                .SetTitle("Alert Title")
                .SetText("Alert text...")
                .Show();


                //System.Threading.Tasks.Task.Run(() =>
                //{
                //    System.Threading.Thread.Sleep(3000);
                //    if (Alerter.IsShowing)
                //    {
                //        Alerter.Hide();
                //    }
                //});
            };
        }
    }
}