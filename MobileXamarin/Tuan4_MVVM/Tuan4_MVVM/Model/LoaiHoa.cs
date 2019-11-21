using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite;

namespace Tuan4_MVVM.Model
{
    public class LoaiHoa : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private int maloai;
        private string tenloai;

        [PrimaryKey, AutoIncrement]
        public int MaLoai
        {
            get
            {
                return maloai;
            }
            set
            {
                maloai = value;
                OnPropertyChanged("MaLoai");
            }
        }
        public string TenLoai
        {
            get
            {
                return tenloai;
            }
            set
            {
                tenloai = value;
                OnPropertyChanged("TenLoai");
            }
        }
    }
}
