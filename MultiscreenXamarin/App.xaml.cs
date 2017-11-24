using Xamarin.Forms;

namespace MultiscreenXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MultiscreenXamarinPage())
            {
                BarTextColor = Color.White, BarBackgroundColor = Color.Gray
            };  //new MultiscreenXamarinPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
