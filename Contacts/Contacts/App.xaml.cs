using System;
using Contacts.pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Contacts
{
    public partial class App : Application
    {
        public static string RUTA_BD;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactosPage());
        }

        public App(string rutaBd)
        {
            InitializeComponent();

            RUTA_BD = rutaBd;

            MainPage = new NavigationPage(new ContactosPage());
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
