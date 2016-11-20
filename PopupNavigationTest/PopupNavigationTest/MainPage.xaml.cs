using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupNavigationTest
{
    public partial class MainPage : ContentPage
    {
        Popup page;
        public MainPage()
        {
            InitializeComponent();
            page = new Popup();
        }
        private void OpenPopup(object sender, EventArgs e)
        {
            Rg.Plugins.Popup.Services.PopupNavigation.PushAsync(page);
        }
    }
}
