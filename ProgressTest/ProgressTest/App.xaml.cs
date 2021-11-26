using ProgressTest.Services;
using ProgressTest.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProgressTest
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new UserDetailPage();
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
