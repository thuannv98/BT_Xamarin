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
    public partial class LoaihoaPage : ContentPage
    {
        private Database db;
        List<LoaiHoa> listviewhoa;
        private LoaiHoa loaihoaduocchon;
        public LoaihoaPage()
        {
            InitializeComponent();
            db = new Database();
            db.CreateDatabase();
            listviewhoa = db.selectLoaiHoa();
            DSLoaiHoa.ItemsSource = listviewhoa;
        }
        private void themloaihoa(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThemLoaiHoa());
        }
        private void tapped(object sender, ItemTappedEventArgs e)
        {
            var lh = e.Item as LoaiHoa;
            //DisplayAlert("sd", lh.TenLoai, "ok");

            if(db.selecthoaTheoLoai(lh.MaLoai).Count == 0)
            {
                Navigation.PushAsync(new ThemHoa(lh.MaLoai));
            }
            else
            {
                Navigation.PushAsync(new HoaPage(lh.MaLoai));
            }
        }

        private void sua(object sender, EventArgs e)
        {
            loaihoaduocchon = (sender as Xamarin.Forms.MenuItem).BindingContext as LoaiHoa;
            //DisplayAlert("sd", visit.TenLoai, "sd");
            tenloaihoamoi.Text = loaihoaduocchon.TenLoai;
            popupSuaLoaiHoa.IsVisible = true;
        }

        private void xacnhansua(object sender, EventArgs e)
        {
            //DisplayAlert("sd", loaihoaduocchon.TenLoai, "sd");
            loaihoaduocchon.TenLoai = tenloaihoamoi.Text;
            if (db.UpdateLoaiHoa(loaihoaduocchon))
            {
                listviewhoa = db.selectLoaiHoa();
                DSLoaiHoa.ItemsSource = listviewhoa;
                DisplayAlert("Thông báo", "Đã cập nhật loại hoa", "OK");
            }
            else DisplayAlert("Thông báo", "Cập nhật loại hoa lỗi", "OK");
        }

        private void huy(object sender, EventArgs e)
        {
            popupSuaLoaiHoa.IsVisible = false;
        }
        private async void xoa(object sender, EventArgs e)
        {
            loaihoaduocchon = (sender as Xamarin.Forms.MenuItem).BindingContext as LoaiHoa;
            bool xacnhan = await DisplayAlert("Xác nhận xóa", "Bạn muốn xóa loại hoa này?", "Ừ", "Ko");
            //Debug.WriteLine("Answer: " + xacnhan);
            if (xacnhan)
            {
                if (db.DeleteLoaiHoa(loaihoaduocchon))
                {
                    listviewhoa = db.selectLoaiHoa();
                    DSLoaiHoa.ItemsSource = listviewhoa;
                    await DisplayAlert("Thông báo", "Đã xóa loại hoa '" + loaihoaduocchon.TenLoai + "'", "OK");
                }
                else await DisplayAlert("Thông báo", "Lỗi xóa loại hoa", "OK");
            }
            
        }

        private void refresh(object sender, EventArgs e)
        {
            listviewhoa = db.selectLoaiHoa();
            DSLoaiHoa.ItemsSource = listviewhoa;
        }
    }
}