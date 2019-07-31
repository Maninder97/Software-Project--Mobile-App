using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IssueRaisers : ContentPage
	{
		public IssueRaisers ()
        {
            InitializeComponent();
        }
        async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        async void ContributorViewOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContributorList());
        }
       
        async void PeopleViewOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PeopleList());
        }
        async void CompaniesViewOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CompanyList());
        }
    }
}