using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TinhThanh
    {
        private int maTinhThanh;
        public int MaTinhThanh
        {
            get { return maTinhThanh; }
            set { maTinhThanh = value; }
        }

        private String tenTinhThanh;
        public String TenTinhThanh
        {
            get { return tenTinhThanh; }
            set { tenTinhThanh = value; }
        }
    }
}
