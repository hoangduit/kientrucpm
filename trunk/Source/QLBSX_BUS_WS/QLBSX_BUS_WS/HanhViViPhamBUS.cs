using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLBSX_BUS_WS.QLBSX_DAL_WebService;
/**
 * Tên Đề Tài; Phần Mền Quản Lý Biển Số Xe và Vi Phạm Giao Thông(VLNM (Vehicle license number management))
 * Ho tên sinh viên:
 * 1. Phan Nhật Tiến       0812515
 * 2. Huỳnh Công Toàn      0812527
 * 
 * GVHD. Trần Minh Triết
 **/

namespace QLBSX_BUS_WS
{
    public class HanhViViPhamBUS
    {        
        private QLBSX_DAL_WebServiceSoapClient ws = new QLBSX_DAL_WebServiceSoapClient();
        public List<HanhViViPhamDTO> LayDanhSachHanhVi()
        {
            return ws.LayDanhSachHanhVi().ToList();
        }
        public bool ThemHanhVi(HanhViViPhamDTO hv)
        {
            return ws.ThemHanhVi(hv);
        }
        public bool VoHieuHoaHanhVi(HanhViViPhamDTO hv)
        {
            return ws.VoHieuHoaHanhVi(hv);
        }
        public bool CapNhatHanhVi(HanhViViPhamDTO hv)
        {
            return ws.CapNhatHanhVi(hv);
        }
        public HanhViViPhamDTO TraCuuTheoTenHanhVi(string ten)
        {
            return ws.TraCuuHanhViTheoTenHanhVi(ten);
        }
        public HanhViViPhamDTO TraCuuTheoMaHanhVi(int ma)
        {
            return ws.TraCuuHanhViTheoMaHanhVi(ma);
        }
    }
}