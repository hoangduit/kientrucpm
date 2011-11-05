using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    public class DuongDTO
    {
        private int _MaDuong;

        public int MaDuong
        {
            get { return _MaDuong; }
            set { _MaDuong = value; }
        }

        private string _TenDuong;

        public string TenDuong
        {
            get { return _TenDuong; }
            set { _TenDuong = value; }
        }
    }
}
