using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    class TuKhoaPhuongDTO
    {
        private int _MaTuKhoaPhuong;

        public int MaTuKhoaPhuong
        {
            get { return _MaTuKhoaPhuong; }
            set { _MaTuKhoaPhuong = value; }
        }

        private string _TuKhoaPhuong;

        public string TuKhoaPhuong
        {
            get { return _TuKhoaPhuong; }
            set { _TuKhoaPhuong = value; }
        }

        private int _MaPhuong;

        public int MaPhuong
        {
            get { return _MaPhuong; }
            set { _MaPhuong = value; }
        }
    }
}
