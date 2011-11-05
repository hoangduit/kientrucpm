using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    class TuKhoaDiaDiemDTO
    {
        private int _MaTuKhoaTenDiaDiem;

        public int MaTuKhoaTenDiaDiem
        {
            get { return _MaTuKhoaTenDiaDiem; }
            set { _MaTuKhoaTenDiaDiem = value; }
        }

        private string _TuKhoaTenDiaDiem;

        public string TuKhoaTenDiaDiem
        {
            get { return _TuKhoaTenDiaDiem; }
            set { _TuKhoaTenDiaDiem = value; }
        }

        private int _MaTenDiaDiem;

        public int MaTenDiaDiem
        {
            get { return _MaTenDiaDiem; }
            set { _MaTenDiaDiem = value; }
        }
    }
}
