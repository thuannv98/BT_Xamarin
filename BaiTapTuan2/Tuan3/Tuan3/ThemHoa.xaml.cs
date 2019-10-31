using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemHoa : ContentPage
    {
        int maloaihoa;
        private Database db;
        public ThemHoa()
        {
            InitializeComponent();
        }
        public ThemHoa(int maloai)
        {
            InitializeComponent();
            maloaihoa = maloai;
            db = new Database();
            db.CreateDatabase();
        }

        private void themhoa(object sender, EventArgs e)
        {
            if (tenhoa.Text != null)
            {
                Hoa hoa;
                if (dongia.Text == null || mota.Text == null)
                {
                    hoa = new Hoa { MaLoai = maloaihoa, TenHoa = tenhoa.Text, DonGia = 0, Hinh = "", MoTa = "" };
                }
                else 
                { 
                    hoa = new Hoa { MaLoai = maloaihoa, TenHoa = tenhoa.Text, DonGia = double.Parse(dongia.Text), Hinh = "", MoTa = mota.Text }; 
                }
                if (db.InsertHoa(hoa))
                    DisplayAlert("Thông báo", "Thêm hoa thành công", "OK");
                else DisplayAlert("Thông báo", "Thêm hoa lỗi", "OK");
            }
            else
                DisplayAlert("Thông báo", "Phải nhập tên hoa!", "OK");
        }

        //private  void OnPickPhotoButtonClicked(object sender, EventArgs e)
        //{
            
        //}
    }
}