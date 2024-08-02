using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    public class SinhVien
    {
        private string id;
        private string hoten;
        private string malop;
        private string tenlop;
        private string masv;

        // Constructor không tham số
        public SinhVien() { }

        // Constructor có tham số
        public SinhVien(string id, string hoten, string malop, string tenlop, string masv)
        {
            this.id = id;
            this.hoten = hoten;
            this.malop = malop;
            this.tenlop = tenlop;
            this.masv = masv;
        }

        // Getter và Setter
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public string MaLop
        {
            get { return malop; }
            set { malop = value; }
        }

        public string TenLop
        {
            get { return tenlop; }
            set { tenlop = value; }
        }

        public string MaSV
        {
            get { return masv; }
            set { masv = value; }
        }
    }
}
