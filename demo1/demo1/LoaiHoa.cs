using System;
using System.Collections.Generic;
using System.Text;

namespace demo1
{
    public class LoaiHoa : List<hoa>
    {
        public string TenLoai { get; set; }
        private LoaiHoa (string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<LoaiHoa> Loaihoas { get; set; }
        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa("hoa cuc")
                {
                    new hoa { Tenhoa = "don xuan", Gia = "5000", Hinh = "cuc.JPG", Mota = "hoa cuc cac mau: trang, vang, cam" },
                    new hoa { Tenhoa = "hon nhien", Gia = "5000", Hinh = "cuc1.jpg", Mota = "hoa cuc vang, cam" },
                    new hoa { Tenhoa = "Tim thuy chung", Gia = "5000", Hinh = "cuc2.jpg", Mota = "hoa cuc tim" },
                },
                new LoaiHoa ("hoa cuoi")
                {   new hoa { Tenhoa = "don xuan", Gia = "5000", Hinh = "cuc3.JPG", Mota = "hoa cuc cac mau: trang, vang, cam" },
                    new hoa { Tenhoa = "hon nhien", Gia = "5000", Hinh = "cuc4.jpg", Mota = "hoa cuc vang, cam" },
                    new hoa { Tenhoa = "Tim thuy chung", Gia = "5000", Hinh = "cuc5.jpg", Mota = "hoa cuc tim" },
                } };
            Loaihoas = l;
            }
        }
    }


