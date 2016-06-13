using RealmDBTest.Models;
using RealmDBTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RealmDBTest
{
    public class App : Application
    {
        public static INavigation Navigation { get; private set; }
        public static Database RealmDB { get; private set; }

        public App()
        {
            RealmDB = new Database();
            RealmDB.PopulateData();

            // The root page of your application
            MainPage = new NavigationPage(new ClientesView());
            Navigation = MainPage.Navigation;
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
