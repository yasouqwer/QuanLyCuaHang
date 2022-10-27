using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HoaDon_DTO
    {
        #region fields
        private int soHD, maNV, maKH, triGia;
        DateTime ngayHoadon;
        #endregion

        #region properties
        public int SoHD { get => soHD; set => soHD = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public int TriGia { get => triGia; set => triGia = value; }
        public DateTime NgayHoadon { get => ngayHoadon; set => ngayHoadon = value; }
        #endregion
    }
}
