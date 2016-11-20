using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PopupNavigationTest
{
    public partial class Popup : PopupPage
    {
        public Popup()
        {
            InitializeComponent();
            this.BindingContext = new PopupViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListView listView = this.FindByName<ListView>("listView");
            //listView.SelectedItem = (this.BindingContext as PopupViewModel).CurrentCategory;
            //(this.BindingContext as PopupViewModel).CurrentCategory = (this.BindingContext as PopupViewModel).CurrentCategory;
        }
    }
}
