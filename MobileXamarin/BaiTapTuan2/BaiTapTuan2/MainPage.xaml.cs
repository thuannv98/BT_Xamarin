using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BaiTapTuan2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void bai1_clicked(object sender, EventArgs e)
        {
            //var rootpage = new NavigationPage(new ListViewPageHoa());
            Navigation.PushAsync(new ListViewPageHoa());
        }

        private void bai2_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewPageGroup());
        }
    }
}
