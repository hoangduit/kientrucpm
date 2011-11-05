using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    public class QuanHuyenDTO
    {
        private int _MaQuanHuyen;

        public int MaQuanHuyen
        {
            get { return _MaQuanHuyen; }
            set { _MaQuanHuyen = value; }
        }

        private string _TenQuanHuyen;

        public string TenQuanHuyen
        {
            get { return _TenQuanHuyen; }
            set { _TenQuanHuyen = value; }
        }
    }
}
