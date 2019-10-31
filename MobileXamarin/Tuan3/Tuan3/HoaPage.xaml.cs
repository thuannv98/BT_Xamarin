using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HoaPage : ContentPage
    {
        int malh;
        List<Hoa> dshoa;
        private Hoa hoaduocchon;
        private Database db;
        public HoaPage()
        {
            InitializeComponent();
        }
        public HoaPage(int maloaihoa)
        {
            InitializeComponent();
            db = new Database();
            db.CreateDatabase();
            dshoa = db.selecthoaTheoLoai(maloaihoa);
            DSHoa.ItemsSource = dshoa;
            malh = maloaihoa;
        }

        private void themhoa(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThemHoa(malh));
        }

        private void refresh(object sender, EventArgs e)
        {
            dshoa = db.selecthoaTheoLoai(malh);
            DSHoa.ItemsSource = dshoa;
        }

        private void sua(object sender, EventArgs e)
        {
            hoaduocchon = (sender as Xamarin.Forms.MenuItem).BindingContext as Hoa;
            tenhoamoi.Text = hoaduocchon.TenHoa;
            motamoi.Text = hoaduocchon.MoTa;
            dongiamoi.Text = hoaduocchon.DonGia.ToString();
            popupSuaHoa.IsVisible = true;
        }

        private void xacnhansua(object sender, EventArgs e)
        {
            hoaduocchon.TenHoa = tenhoamoi.Text;
            hoaduocchon.MoTa = motamoi.Text;
            hoaduocchon.DonGia = Double.Parse(dongiamoi.Text);
            if (db.UpdateHoa(hoaduocchon))
            {
                DisplayAlert("Thông báo", "Đã cập nhật thông tin hoa", "OK");
                dshoa = db.selecthoaTheoLoai(malh);
                DSHoa.ItemsSource = dshoa;
            }
            else DisplayAlert("Thông báo", "Lỗi cập nhật hoa", "OK");
        }

        private void huy(object sender, EventArgs e)
        {
            popupSuaHoa.IsVisible = false;
        }

        private async void xoa(object sender, EventArgs e)
        {
            hoaduocchon = (sender as Xamarin.Forms.MenuItem).BindingContext as Hoa;
            bool xacnhan = await DisplayAlert("Xác nhận xóa", "Xóa hoa này khỏi danh sách?", "Ừ", "Không");
            if (xacnhan)
            {
                if (db.DeleteHoa(hoaduocchon))
                {
                    dshoa = db.selecthoaTheoLoai(malh);
                    DSHoa.ItemsSource = dshoa;
                    await DisplayAlert("Thông báo", "Đã xóa hoa '" + hoaduocchon.TenHoa + "'", "OK");
                }
                else await DisplayAlert("Thông báo", "Lỗi xóa hoa'" + hoaduocchon.TenHoa + "'", "OK");
            }
        }
    }
}