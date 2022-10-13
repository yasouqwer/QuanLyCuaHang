using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHANVIEN_DTO
{
    public class NhanVien_DTO
    {
        #region fields
        private string tenNV,gioiTinhNV;
        private int canCuocNV, soDienThoaiNV,maNV;
        private DateTime ngaySinhNV;
        #endregion
        #region properties
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinhNV { get => gioiTinhNV; set => gioiTinhNV = value; }
        public int CanCuocNV { get => canCuocNV; set => canCuocNV = value; }
        public int SoDienThoaiNV { get => soDienThoaiNV; set => soDienThoaiNV = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public DateTime NgaySinhNV { get => ngaySinhNV; set => ngaySinhNV = value; }
        #endregion
    }
}
