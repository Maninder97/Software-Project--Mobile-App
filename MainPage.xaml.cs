using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void StaffViewOnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new ContributorsAndRaisers());
        }
    }
}
