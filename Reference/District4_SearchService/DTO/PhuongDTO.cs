using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    public class PhuongDTO
    {
        private int _MaPhuong;

        public int MaPhuong
        {
            get { return _MaPhuong; }
            set { _MaPhuong = value; }
        }

        private string _TenPhuong;

        public string TenPhuong
        {
            get { return _TenPhuong; }
            set { _TenPhuong = value; }
        }
    }
}
