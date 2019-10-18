using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTapTuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPageGroup : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListViewPageGroup()
        {
            InitializeComponent();

            loaihoa lh = new loaihoa();

            lsthoa.ItemsSource = lh;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
