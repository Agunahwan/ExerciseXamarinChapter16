using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpacityBindingCode
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new OpacityBindingCodePage();
            //MainPage = new OpacityBindingXamlPage();
            //MainPage = new BindingSourceCodePage();
            //MainPage = new BindingSourceXamlPage();
            //MainPage = new WebViewDemoPage();
            //MainPage = new BindingModesPage();
            MainPage = new ReverseBindingPage();
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
