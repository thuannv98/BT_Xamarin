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
    public partial class ThemLoaiHoa : ContentPage
    {
        public ThemLoaiHoa()
        {
            InitializeComponent();
        }

        private void themlh(object sender, EventArgs e)
        {
            if(tenloai.Text != null)
            {
                Database db = new Database();
                db.CreateDatabase();
                LoaiHoa lh = new LoaiHoa { TenLoai = tenloai.Text };
                if (db.InsertLoaiHoa(lh) == true)
                    DisplayAlert("Thông báo", "Đã thêm loại hoa '"+tenloai.Text+"'", "OK");
                else
                    DisplayAlert("Thông báo", "Thêm loại hoa lỗi", "OK");
            }
            else
                DisplayAlert("Thông báo", "Phải nhập tên loại hoa!", "OK");
        }
    }
}