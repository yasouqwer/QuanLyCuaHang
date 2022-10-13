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
        private int maHH, giaHH;
        private string tenHH;
        #endregion
        #region properties
        public int MaHH { get => maHH; set => maHH = value; }
        public int GiaHH { get => giaHH; set => giaHH = value; }
        public string TenHH { get => tenHH; set => tenHH = value; }
        #endregion
    }
}
