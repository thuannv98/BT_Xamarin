using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tuan3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Database db;
        public MainPage()
        {
            InitializeComponent();
            db = new Database();
            db.CreateDatabase();
            //List<LoaiHoa> dslh = db.selectLoaiHoa();
            //DSLoaiHoa.ItemsSource = dslh;
        }

        private void themloaihoa(object sender, EventArgs e)
        {
            DisplayAlert("Thông báo", "dsdsds", "OK");
            Navigation.PushAsync(new ThemLoaiHoa());
        }

        private void f(object sender, FocusEventArgs e)
        {
            DisplayAlert("Thông Báo","ggfhg", "OK");
        }
    }
}
