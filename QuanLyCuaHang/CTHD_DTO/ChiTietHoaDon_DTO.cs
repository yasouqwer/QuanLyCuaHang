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
        private int maHD, maHH,SoLuong;
        #endregion
        #region properties
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaHH { get => maHH; set => maHH = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        #endregion
    }
}
