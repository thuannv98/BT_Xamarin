using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite;

namespace Tuan4_MVVM.Model
{
    public class Hoa : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int mahoa, maloai;
        private string tenhoa, hinh, mota;
        private double dongia;

        [PrimaryKey, AutoIncrement]
        public int MaHoa
        {
            get
            {
                return mahoa;
            }
            set
            {
                mahoa = value;
                OnPropertyChanged("MaHoa");
            }
        }
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
        public string TenHoa
        {
            get
            {
                return tenhoa;
            }
            set
            {
                tenhoa = value;
                OnPropertyChanged("TenHoa");
            }
        }
        public string Hinh
        {
            get
            {
                return hinh;
            }
            set
            {
                hinh = value;
                OnPropertyChanged("Hinh");
            }
        }
        public string MoTa
        {
            get
            {
                return mota;
            }
            set
            {
                mota = value;
                OnPropertyChanged("MoTa");
            }
        }
        public double DonGia
        {
            get
            {
                return dongia;
            }
            set
            {
                dongia = value;
                OnPropertyChanged("DonGia");
            }
        }

    }
}
