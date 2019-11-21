using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuan4_MVVM.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tuan4_MVVM.Model;

namespace Tuan4_MVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HoaPage : ContentPage
    {
        public HoaPage()
        {
            InitializeComponent();
            BindingContext = new HoaBinder();
        }
        
        public HoaPage(LoaiHoa loaihoa)
        {
            InitializeComponent();
            BindingContext = new HoaBinder(loaihoa);
        }
    }
}