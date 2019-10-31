using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapTuan2
{
    class loaihoa : List<hoa>
    {
        public string TenLoai { get; set; }
        private loaihoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<loaihoa> LoaiHoas { get; set; }
        public loaihoa()
        {
            List<loaihoa> l = new List<loaihoa>()
            {
                new loaihoa("Hoa Cúc")
                {
                    new hoa { TenHoa = "Đón Xuân", Gia = 50000, Hinh = "cuc_9.jpg", MoTa = "Hoa cúc các màu: trắng, vàng, cam"},
                    new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "cuc_2.jpg", MoTa = "Hoa cúc vàng, cam, lá măng"},
                    new hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "cuc_3.jpg", MoTa = "Hoa cúc tím"}
                },
                new loaihoa("Hoa Cưới")
                {
                    new hoa { TenHoa = "Dây tơ hồng", Gia = 250000, Hinh = "cuoi_1.jpg", MoTa = "Hoa hồng màu hồng đậm, hoa hồng xanh, các loại lá măng"},
                    new hoa { TenHoa = "Hoa thủy tiên", Gia = 220000, Hinh = "cuoi_2.jpg", MoTa = "Hoa hồng và hoa thủy tiên trắng"},
                    new hoa { TenHoa = "Duyên thầm", Gia = 260000, Hinh = "cuoi_3.jpg", MoTa = "Hoa cúc trắng, baby, lá măng"}
                }
            };
            LoaiHoas = l;
        }
    }
}
