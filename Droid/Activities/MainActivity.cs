using Android.App;
using Android.Widget;
using Android.OS;
using FormationHulk.Resources;
using FormationHulk.Droid.Activities;
using FormationHulk.ViewModels;

namespace FormationHulk.Droid
{
    [Activity(Label = "FormationHulk", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : BaseActivity<MainViewModel>
    {
        protected override int Layout => Resource.Layout.Main;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        protected override void SetupControls()
        {
            base.SetupControls();

            //TextView button = FindViewById<TextView>(Resource.Id.imageView1);

            //button.Text = Strings.HelloWorld;
        }
    }
}

