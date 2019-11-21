using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Tuan4_MVVM.Model;
using Xamarin.Forms;
using Tuan4_MVVM.View;
using System.Threading.Tasks;

namespace Tuan4_MVVM.ViewModel
{
    public class LoaiHoaBinder : INotifyPropertyChanged
    {
        readonly Database db;
        readonly INavigation Navigation;
        public ICommand ThemLoaiHoa { get; private set; }
        public ICommand SuaLoaiHoa { get; private set; }
        public ICommand XoaLoaiHoa { get; private set; }
        public ICommand ShowDsHoa { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private LoaiHoa loaihoa;
        public LoaiHoa LoaiHoa
        {
            get { return loaihoa; }
            set
            {
                loaihoa = value;
                RaisePropertyChanged("LoaiHoa");
                ((Command)SuaLoaiHoa).ChangeCanExecute();
                ((Command)XoaLoaiHoa).ChangeCanExecute();
                ((Command)ShowDsHoa).ChangeCanExecute();
            }
        }

        private ObservableCollection<LoaiHoa> items;
        public ObservableCollection<LoaiHoa> LoaiHoaItem
        {
            get { return items; }
            set
            {
                items = value;
                RaisePropertyChanged("LoaiHoaItem");
            }
        }

        public LoaiHoaBinder(INavigation navigation)
        {
            db = new Database();
            loaihoa = new LoaiHoa();
            LoaiHoaItem = db.DSLoaiHoa();
            this.ThemLoaiHoa = new Command(Insert);
            this.SuaLoaiHoa = new Command(Update, CanExecute);
            this.XoaLoaiHoa = new Command(Delete, CanExecute);
            this.ShowDsHoa = new Command(async () => await DenTrangDsHoa(), CanExecute);
            this.Navigation = navigation;
            TaiDsLoaiHoa();
        }
        private void TaiDsLoaiHoa()
        {
            this.LoaiHoaItem = db.DSLoaiHoa();
        }

        private void Insert()
        {
            db.InsertLoaiHoa(LoaiHoa);
            TaiDsLoaiHoa();
        }
        private void Update()
        {
            db.UpdateLoaiHoa(LoaiHoa);
            TaiDsLoaiHoa();
        }
        private void Delete()
        {
            db.DeleteLoaiHoa(LoaiHoa);
            TaiDsLoaiHoa();
            LoaiHoa = null;
            ((Command)SuaLoaiHoa).ChangeCanExecute();
            ((Command)XoaLoaiHoa).ChangeCanExecute();
            ((Command)ShowDsHoa).ChangeCanExecute();
        }
        private bool CanExecute()
        {
            if (LoaiHoa == null || LoaiHoa.MaLoai == 0)
            {
                System.Console.WriteLine("Can't execute");
                return false;
            }
            System.Console.WriteLine("Can execute");
            return true;
        }
        public async Task DenTrangDsHoa()
        {
            await Navigation.PushAsync(new HoaPage(LoaiHoa));
        }

    }

}
