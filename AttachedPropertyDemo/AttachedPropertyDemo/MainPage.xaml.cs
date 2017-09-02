using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AttachedPropertyDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if(MainPageViewModel.GetIsAttached(WelcomeText))
                WelcomeText.Text = "Welcome to Xamarin Forms! This is Attached Property demo.";
        }
    }
}
