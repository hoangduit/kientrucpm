using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    class TuKhoaDichVuDTO
    {
        private int _MaTuKhoaDichVu;

        public int MaTuKhoaDichVu
        {
            get { return _MaTuKhoaDichVu; }
            set { _MaTuKhoaDichVu = value; }
        }

        private string _TuKhoaDichVu;

        public string TuKhoaDichVu
        {
            get { return _TuKhoaDichVu; }
            set { _TuKhoaDichVu = value; }
        }

        private int _MaDichVu;

        public int MaDichVu
        {
            get { return _MaDichVu; }
            set { _MaDichVu = value; }
        }
    }
}
