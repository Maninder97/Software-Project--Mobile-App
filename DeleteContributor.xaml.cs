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
	public partial class DeleteContributor : ContentPage
	{
        ContributorDataAccessClass dataAccess;
        public int id;

        public DeleteContributor ()
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
        //Delete button to delete a contributor.
        public void Delete_Clicked(object sender, EventArgs e)
        {

            ContributorModel Contributors = (ContributorModel)(((BindableObject)sender).BindingContext);
            if (id != 0)
            {
                Console.WriteLine("Delete data: ");
                dataAccess.DeleteContributor(Contributors);
                dataAccess.DeleteContributor();
            }
            else
            {

                dataAccess.DeleteContributor(Contributors);
            }
        }
    }
}