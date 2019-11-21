using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Tuan4_MVVM.Model;
using Xamarin.Forms;

namespace Tuan4_MVVM.ViewModel
{
    public class HoaBinder : INotifyPropertyChanged
    {
        readonly Database db;
        public ICommand ThemHoa { get; private set; }
        public ICommand CapNhatHoa { get; private set; }
        public ICommand XoaHoa { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private string tieude;
        public string TieuDe
        {
            get { return tieude; }
            set
            {
                tieude = value;
                RaisePropertyChanged("TieuDe");
            }
        }

        private Hoa hoa;
        public Hoa Hoa
        {
            get { return hoa; }
            set
            {
                hoa = value;
                RaisePropertyChanged("Hoa");
                ((Command)CapNhatHoa).ChangeCanExecute();
                ((Command)XoaHoa).ChangeCanExecute();
            }
        }

        private ObservableCollection<Hoa> items;
        public ObservableCollection<Hoa> HoaItem
        {
            get { return items; }
            set
            {
                items = value;
                RaisePropertyChanged("HoaItem");
            }
        }
        public HoaBinder()
        {
            TieuDe = "Danh sách hoa";
            db = new Database();
            hoa = new Hoa();
            HoaItem = db.DSHoa();
            this.ThemHoa = new Command(Insert);
            this.CapNhatHoa = new Command(Update, CanExecute);
            this.XoaHoa = new Command(Delete, CanExecute);
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.HoaItem = db.DSHoa();
                return true;
            });
        }

        public HoaBinder(LoaiHoa loaihoa)
        {
            TieuDe = "DS hoa thuộc loại: "+loaihoa.TenLoai;
            db = new Database();
            hoa = new Hoa();
            Hoa.MaLoai = loaihoa.MaLoai;
            HoaItem = db.DSHoa(loaihoa.MaLoai);
            this.ThemHoa = new Command(Insert);
            this.CapNhatHoa = new Command(Update, CanExecute);
            this.XoaHoa = new Command(Delete, CanExecute);
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.HoaItem = db.DSHoa(loaihoa.MaLoai);
                return true;
            });
        }

        private void Insert()
        {
            db.InsertHoa(Hoa);
        }
        private void Update()
        {
            db.UpdateHoa(Hoa);
        }
        private void Delete()
        {
            db.DeleteHoa(Hoa);
            Hoa = null;
            ((Command)CapNhatHoa).ChangeCanExecute();
            ((Command)XoaHoa).ChangeCanExecute();
        }
        private bool CanExecute()
        {
            if (Hoa == null || Hoa.MaHoa == 0)
                return false;
            return true;
        }
    }
}
