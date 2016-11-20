using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupNavigationTest
{
    class PopupViewModel : INotifyPropertyChanged
    {
        public PopupViewModel()
        {
            Categories = new ObservableCollection<string>();
            Categories.Add("CatA");
            Categories.Add("CatB");
            Categories.Add("CatC");
            currentCategory = "CatA";
        }

        public ObservableCollection<string> Categories { get; private set; }
        string currentCategory;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string CurrentCategory
        {
            get
            {
                return currentCategory;
            }

            set
            {
                if (currentCategory != value)
                {
                    currentCategory = value;
                    if (currentCategory != null)
                    {

                        PopupNavigation.PopAsync();
                    }
                    OnPropertyChanged(nameof(CurrentCategory));
                }
            }
        }
    }
}
