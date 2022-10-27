using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTHD_DTO
{
    class LoaiSanPham_DTO
    {
        #region fields
        private int maLoaiSP;
        private string tenLoaiSP;
        #endregion
        #region properties

        public int MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
        public string TenLoaiSP { get => tenLoaiSP; set => tenLoaiSP = value; }
        #endregion
    }
}
