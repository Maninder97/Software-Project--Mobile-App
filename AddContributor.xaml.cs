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
	public partial class AddContributor : ContentPage
	{
        ContributorDataAccessClass dataAccess;

        public AddContributor ()
		{
			InitializeComponent ();
            //Accessing Contributor Data
            dataAccess = new ContributorDataAccessClass();
            this.BindingContext = dataAccess;
            
        }
        async void Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        async void ContributorViewOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContributorList());
        }
        async void RaisersViewOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IssueRaisers());
        }
        //Save button to add a new contributor.
        public void Save_Clicked(object sender, EventArgs e)
        {

            ContributorModel Contributors = (ContributorModel)(((BindableObject)sender).BindingContext);
            if (Contributors == null || Contributors.Id < 1)
            {
                Console.WriteLine("Save data: ");
                dataAccess.SaveContributor(Contributors);
                dataAccess.AddNewContributor();
            }
            else
            {

                dataAccess.SaveContributor(Contributors);
            }
        }
    }
}