using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//checked

namespace DTO
{
    public class DichVuDTO
    {
        private int _MaDichVu;

        public int MaDichVu
        {
            get { return _MaDichVu; }
            set { _MaDichVu = value; }
        }

        private string _TenDichVu;

        public string TenDichVu
        {
            get { return _TenDichVu; }
            set { _TenDichVu = value; }
        }
    }
}
