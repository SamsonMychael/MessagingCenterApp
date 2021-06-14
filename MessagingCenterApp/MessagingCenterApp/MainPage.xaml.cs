using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MessagingCenterApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> MessagingItems { get; set; } = new ObservableCollection<string>();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<Page, DateTime>(this, "tick", (p, DateTime) =>
         {
             MessagingItems.Add($"Message Received at {DateTime}");
         });
        }

       
        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SenderPage());
        }
    }
}
