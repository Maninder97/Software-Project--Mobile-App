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
    public partial class ContributorList : ContentPage
    {
        ContributorDataAccessClass dataAccess;
        public ContributorList()
        {
            InitializeComponent();

            //Accessing Contributor Data
            dataAccess = new ContributorDataAccessClass();
            this.BindingContext = dataAccess;
        }

        async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        
        async void RaisersViewOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IssueRaisers());
        }
        async void AddNewContributorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddContributor());
        }
        async void ModifyClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ModifyContributor());
        }
        async void DeleteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeleteContributor());
        }
    }
}
    

 