using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    class TuKhoaQuanHuyenDTO
    {
        private int _MaTuKhoaQuanHuyen;

        public int MaTuKhoaQuanHuyen
        {
            get { return _MaTuKhoaQuanHuyen; }
            set { _MaTuKhoaQuanHuyen = value; }
        }

        private string _TuKhoaQuanHuyen;

        public string TuKhoaQuanHuyen
        {
            get { return _TuKhoaQuanHuyen; }
            set { _TuKhoaQuanHuyen = value; }
        }

        private int _MaQuanHuyen;

        public int MaQuanHuyen
        {
            get { return _MaQuanHuyen; }
            set { _MaQuanHuyen = value; }
        }
    }
}
