using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HangHoa_DTO
    {
        #region fields
        private int maSP, giaSP,maLoaiSP;
        private string tenSP;


        #endregion
        #region properties
        public int MaSP { get => maSP; set => maSP = value; }
        public int GiaSP { get => giaSP; set => giaSP = value; }
        public int MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        #endregion
    }
}
