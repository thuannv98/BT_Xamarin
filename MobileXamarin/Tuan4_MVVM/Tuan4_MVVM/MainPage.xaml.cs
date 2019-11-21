using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Tuan4_MVVM.View;

namespace Tuan4_MVVM
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

        private void Loaihoaclk(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoaiHoaPage());
        }

        private void Hoaclk(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HoaPage());
        }
    }
}
