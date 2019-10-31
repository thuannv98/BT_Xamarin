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
    public partial class ListViewPageHoa : ContentPage
    {
        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();

        public ListViewPageHoa()
        {
            InitializeComponent();

            Hoas.Add(new hoa() { TenHoa = "Đón Xuân", Gia = 50000, Hinh = "cuc_9.jpg", MoTa = "Hoa cúc các màu: trắng, vàng, cam" });
            Hoas.Add(new hoa() { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "cuc_2.jpg", MoTa = "Hoa cúc vàng, cam, lá măng" });
            Hoas.Add(new hoa() { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "cuc_3.jpg", MoTa = "Hoa cúc tím" });

            MyListView.ItemsSource = Hoas;
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
