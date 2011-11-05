using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    class TuKhoaTinhThanhDTO
    {
        private int _MaTuKhoaTinhThanh;

        public int MaTuKhoaTinhThanh
        {
            get { return _MaTuKhoaTinhThanh; }
            set { _MaTuKhoaTinhThanh = value; }
        }
        private string _TuKhoaTinhThanh;

        public string TuKhoaTinhThanh
        {
            get { return _TuKhoaTinhThanh; }
            set { _TuKhoaTinhThanh = value; }
        }
        private int _MaTinhThanh;

        public int MaTinhThanh
        {
            get { return _MaTinhThanh; }
            set { _MaTinhThanh = value; }
        }
    }
}
