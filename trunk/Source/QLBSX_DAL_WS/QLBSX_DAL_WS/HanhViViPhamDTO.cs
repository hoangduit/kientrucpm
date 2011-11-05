using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Tên Đề Tài; Phần Mền Quản Lý Biển Số Xe và Vi Phạm Giao Thông(VLNM (Vehicle license number management))
 * Ho tên sinh viên:
 * 1. Phan Nhật Tiến       0812515
 * 2. Huỳnh Công Toàn      0812527
 * 
 * GVHD. Trần Minh Triết
 **/
namespace QLBSX_DAL_WS
{
    public class HanhViViPhamDTO
    {
        private int _MaHanhVi;
        private string _TenHanhVi;
        private bool _VoHieuHoa;

        public int MaHanhVi
        {
            get { return _MaHanhVi; }
            set { _MaHanhVi = value; }
        }        
        public string TenHanhVi
        {
            get { return _TenHanhVi; }
            set { _TenHanhVi = value; }
        }
        public bool VoHieuHoa
        {
            get { return _VoHieuHoa; }
            set { _VoHieuHoa = value; }
        }

        public HanhViViPhamDTO()
        {
            _TenHanhVi = "";
            _VoHieuHoa = false;
        }
    }    
}
