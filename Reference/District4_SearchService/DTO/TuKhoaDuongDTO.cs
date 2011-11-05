using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    public class TuKhoaDuongDTO
    {
        private int _MaTuKhoaDuong;

        public int MaTuKhoaDuong
        {
            get { return _MaTuKhoaDuong; }
            set { _MaTuKhoaDuong = value; }
        }

        private string _TuKhoaDuong;

        public string TuKhoaDuong
        {
            get { return _TuKhoaDuong; }
            set { _TuKhoaDuong = value; }
        }

        private int _MaDuong;

        public int MaDuong
        {
            get { return _MaDuong; }
            set { _MaDuong = value; }
        }
    }
}
