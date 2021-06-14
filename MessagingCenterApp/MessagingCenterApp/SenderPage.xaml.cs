using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessagingCenterApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SenderPage : ContentPage
    {
        public SenderPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<Page, DateTime>(this, "tick", DateTime.Now);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}