using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class KhachHang_DTO
    {
        #region fields
        private string tenKH, gioiTinhKH;
        private int canCuocKH, soDienThoaiKH, maKH;
        private DateTime ngaySinhKH;
        #endregion
        #region properties
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string GioiTinhKH { get => gioiTinhKH; set => gioiTinhKH = value; }
        public int CanCuocKH { get => canCuocKH; set => canCuocKH = value; }
        public int SoDienThoaiKH { get => soDienThoaiKH; set => soDienThoaiKH = value; }
        public int MaKH { get => maKH; set => maKH = value; }
        public DateTime NgaySinhkh { get => ngaySinhKH; set => ngaySinhKH = value; }
        #endregion
    }
}
