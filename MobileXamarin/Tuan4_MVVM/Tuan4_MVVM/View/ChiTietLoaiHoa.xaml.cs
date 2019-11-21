using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Tuan4_MVVM.Model;
using Tuan4_MVVM.ViewModel;

namespace Tuan4_MVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChiTietLoaiHoa : ContentPage
    {
        public ChiTietLoaiHoa()
        {
            InitializeComponent();
        }

        public ChiTietLoaiHoa(LoaiHoa loaihoa)
        {
            InitializeComponent();
            BindingContext = new HoaBinder(loaihoa);
        }
    }
}