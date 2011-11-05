using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    public class TinhThanhDTO
    {
        private int _MaTinhThanh;

        public int MaTinhThanh
        {
            get { return _MaTinhThanh; }
            set { _MaTinhThanh = value; }
        }

        private string _TenTinhThanh;

        public string TenTinhThanh
        {
            get { return _TenTinhThanh; }
            set { _TenTinhThanh = value; }
        }
    }
}
