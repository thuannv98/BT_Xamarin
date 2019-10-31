using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQLite;
using System.Diagnostics;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Tuan3
{
    class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        private SQLiteConnection database;
        private static object collisionLock = new object();
        public ObservableCollection<LoaiHoa> LoaiHoa { get; set; }
        public ObservableCollection<Hoa> Hoa { get; set; }
        public void CreateDatabase()
        {
            database = DependencyService.Get<IDatabaseConnection>().DbConnection();
            database.CreateTable<LoaiHoa>();
            this.LoaiHoa = new ObservableCollection<LoaiHoa>(database.Table<LoaiHoa>());
            database.CreateTable<Hoa>();
            this.Hoa = new ObservableCollection<Hoa>(database.Table<Hoa>());
        }

        public bool InsertLoaiHoa(LoaiHoa loai)
        {
            if (database.Insert(loai) == 1)
                return true;
            return false;
            
        }
        public bool UpdateLoaiHoa(LoaiHoa loai)
        {
            if(database.Update(loai) == 1)
                return true;
            return false;
        }
        public bool DeleteLoaiHoa(LoaiHoa loai)
        {
            if (database.Delete(loai) == 1)
                return true;
            return false;
        }

        public List<LoaiHoa> selectLoaiHoa()
        {
            return database.Table<LoaiHoa>().ToList();
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