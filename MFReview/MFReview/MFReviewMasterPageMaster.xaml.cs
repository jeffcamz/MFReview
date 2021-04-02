using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MFReview
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MFReviewMasterPageMaster : ContentPage
    {
        public ListView ListView;

        public MFReviewMasterPageMaster()
        {
            InitializeComponent();

            BindingContext = new MFReviewMasterPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MFReviewMasterPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MFReviewMasterPageMasterMenuItem> MenuItems { get; set; }

            public MFReviewMasterPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MFReviewMasterPageMasterMenuItem>(new[]
                {
                    new MFReviewMasterPageMasterMenuItem { Id = 0, Title = "Page 1" },
                    new MFReviewMasterPageMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MFReviewMasterPageMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MFReviewMasterPageMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MFReviewMasterPageMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}