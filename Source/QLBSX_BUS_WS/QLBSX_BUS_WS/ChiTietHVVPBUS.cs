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
    public class ChiTietHVVPBUS
    {
        private QLBSX_DAL_WebServiceSoapClient ws = new QLBSX_DAL_WebServiceSoapClient();
        public List<ChiTietHVVPDTO> LayDanhSachChiTietHanhVi()
        {
            return ws.LayDanhSachChiTietHanhVi();
        }
        public bool ThemChiTietHanhVi(ChiTietHVVPDTO ct)
        {
            return ws.ThemChiTietHanhVi(ct);
        }
        public bool CapNhatChiTietHanhVi(ChiTietHVVPDTO ct)
        {
            return ws.CapNhatChiTietHanhVi(ct);
        }
        public List<ChiTietHVVPDTO> TraCuuTheoBienSo(string bienso)
        {
            return ws.TraCuuCTHVTheoBienSo(bienso);
        }
        public List<ChiTietHVVPDTO> TraCuuTheoMaBienSo(int _mabs)
        {
            return ws.TraCuuCTHVTheoMaBienSo(_mabs);
        }
        public List<ChiTietHVVPDTO> TraCuuTheoTenHanhVi(string tenhv)
        {
            return ws.TraCuuCTHVTheoTenHanhVi(tenhv);
        }
        public List<ChiTietHVVPDTO> TraCuuTheoMaHanhVi(int _mahv)
        {
            return ws.TraCuuCTHVTheoMaHanhVi(_mahv);
        }
    }
}
