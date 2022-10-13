using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOADON_DTO
{
    public class HoaDon_DTO
    {
        #region fields
        private int maHD,maNV,maKH;
        #endregion

        #region properties
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        #endregion

    }
}
