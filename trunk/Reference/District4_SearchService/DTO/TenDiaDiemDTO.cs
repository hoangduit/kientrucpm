using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    class TenDiaDiemDTO
    {
        private int _MaTenDiaDiem;

        public int MaTenDiaDiem
        {
            get { return _MaTenDiaDiem; }
            set { _MaTenDiaDiem = value; }
        }
        private string _TenDiaDiem;

        public string TenDiaDiem
        {
            get { return _TenDiaDiem; }
            set { _TenDiaDiem = value; }
        }
    }
}
