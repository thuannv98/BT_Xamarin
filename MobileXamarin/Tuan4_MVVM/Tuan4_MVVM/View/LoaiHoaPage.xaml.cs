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
    public partial class LoaiHoaPage : ContentPage
    {
        public LoaiHoaPage()
        {
            InitializeComponent();
            BindingContext = new LoaiHoaBinder(Navigation);
        }
    }
}