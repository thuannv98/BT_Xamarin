using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuan4_MVVM.ViewModel;
using Tuan4_MVVM.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan4_MVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemLoaiHoaPage : ContentPage
    {
        public ThemLoaiHoaPage()
        {
            InitializeComponent();
        }

        private void themlh(object sender, EventArgs e)
        {
            if (tenloai.Text != null)
            {
                Database db = new Database();
                LoaiHoa lh = new LoaiHoa { TenLoai = tenloai.Text };
                if (db.InsertLoaiHoa(lh))
                    DisplayAlert("TB", "Succ", "OK");
                else
                    DisplayAlert("TB", "FAIL", "OK");
            }
            else
                DisplayAlert("Thông báo", "Phải nhập tên loại hoa!", "OK");
        }
    }
}