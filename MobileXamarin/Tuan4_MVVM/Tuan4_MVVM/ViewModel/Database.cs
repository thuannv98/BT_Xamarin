using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SQLite;
using Tuan4_MVVM.Model;
using Tuan4_MVVM.Helper;
using Xamarin.Forms;
using System.Linq;

namespace Tuan4_MVVM.ViewModel
{
    public class Database
    {
        private SQLiteConnection database;
        public ObservableCollection<LoaiHoa> LoaiHoa { get; set; }
        public ObservableCollection<Hoa> Hoa { get; set; }
        public Database()
        {
            database = DependencyService.Get<InterfaceDbConnection>().DbConnection();
            database.CreateTable<LoaiHoa>();
            this.LoaiHoa = new ObservableCollection<LoaiHoa>(database.Table<LoaiHoa>());
            database.CreateTable<Hoa>();
            this.Hoa = new ObservableCollection<Hoa>(database.Table<Hoa>());
        }
        public ObservableCollection<LoaiHoa> DSLoaiHoa()
        {
            ObservableCollection<LoaiHoa> ObsColLoaiHoa = new ObservableCollection<LoaiHoa>(database.Table<LoaiHoa>());
            //List<LoaiHoa> list = database.Table<LoaiHoa>().ToList();
            //foreach (var item in list)
            //    ObsColLoaiHoa.Add(item);
            return ObsColLoaiHoa;
        }
        public ObservableCollection<Hoa> DSHoa()
        {
            ObservableCollection<Hoa> ObsColHoa = new ObservableCollection<Hoa>(database.Table<Hoa>());
            return ObsColHoa;
        }
        public ObservableCollection<Hoa> DSHoa(int maloaihoa)
        {
            ObservableCollection<Hoa> ObsColHoa = new ObservableCollection<Hoa>();
            var dsh = from lhs in database.Table<Hoa>().ToList()
                      where lhs.MaLoai == maloaihoa
                      select lhs;
            foreach (var item in dsh)
                ObsColHoa.Add(item);
            return ObsColHoa;
        }

        public bool InsertLoaiHoa(LoaiHoa loai)
        {
            if (database.Insert(loai) == 1)
                return true;
            return false;

        }
        public bool UpdateLoaiHoa(LoaiHoa loai)
        {
            if (database.Update(loai) == 1)
                return true;
            return false;
        }
        public bool DeleteLoaiHoa(LoaiHoa loai)
        {
            if (database.Delete(loai) == 1)
                return true;
            return false;
        }

        public bool InsertHoa(Hoa hoa)
        {
            if (database.Insert(hoa) == 1)
                return true;
            return false;
        }
        public bool UpdateHoa(Hoa hoa)
        {
            if (database.Update(hoa) == 1)
                return true;
            return false;
        }
        public bool DeleteHoa(Hoa hoa)
        {
            if (database.Delete(hoa) == 1)
                return true;
            return false;
        }

        public List<Hoa> selecthoaTheoLoai(int maloai)
        {
            var dsh = from lhs in database.Table<Hoa>().ToList()
                      where lhs.MaLoai == maloai
                      select lhs;
            return dsh.ToList<Hoa>();
        }
    }
}
