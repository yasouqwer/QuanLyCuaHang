using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class NhanVien_DTO
    {
        #region fields
        private string tenNV;
        private int soDienThoaiNV, maNV, luongNV;
       
        #endregion
        #region properties
        public string TenNV { get => tenNV; set => tenNV = value; }
       
        public int SoDienThoaiNV { get => soDienThoaiNV; set => soDienThoaiNV = value; }
        public int MaNV { get => maNV; set => maNV = value; }
     
        public int LuongNV { get => luongNV; set => luongNV = value; }
        #endregion
    }
}
