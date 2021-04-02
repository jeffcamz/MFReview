using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MFReview
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MFReviewMasterPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
