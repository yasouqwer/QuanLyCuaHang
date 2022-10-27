using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTHD_DTO
{
    public class ChiTietHoaDon_DTO
    {
        #region fields
        private int soHD, maSP,SoLuong;
        #endregion
        #region properties
        public int MaHD { get => soHD; set => soHD = value; }
        public int MaHH { get => maSP; set => maSP = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        #endregion
    }
}
