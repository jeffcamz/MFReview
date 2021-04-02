using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MFReview
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var names = new List<string>
            {
                "John Doe",
                "Susan Baker",
                "Eddy Free"
            };

            listView.ItemsSource = names;
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddReviewPage());
        }
    }
}
