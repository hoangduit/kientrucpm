using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Presentation.QLBSX_BUS_WebService;
namespace Presentation
{
    public class HanhViViPham
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();
        public bool ThemChiTietHanhVi(ChiTietHVVPDTO ct)
        {
            return ws.ThemChiTietHanhVi(ct);
        }
        public bool ThemHanhVi(HanhViViPhamDTO hv)
        {
            return ws.ThemHanhVi(hv);
        }
        public HanhViViPhamDTO TraCuuHanhViTheoTenHanhVi(string ten)
        {
            return ws.TraCuuHanhViTheoTenHanhVi(ten);
        }

        public bool VoHieuHoaHanhVi(HanhViViPhamDTO hv)
        {
            return  ws.VoHieuHoaHanhVi(hv);
        }
        public bool CapNhatHanhVi(HanhViViPhamDTO hv)
        {
            return ws.CapNhatHanhVi(hv);
        }
        public List<BienSoXe> LayDanhSachBienSoXe()
        {
            return ws.LayDanhSachBienSoXe().ToList();
        }

        public List<ChiTietHVVPDTO> LayDanhSachChiTietHanhVi()
        {
            return ws.LayDanhSachChiTietHanhVi().ToList();
        }

        public List<HanhViViPhamDTO> LayDanhSachHanhVi()
        {
            return ws.LayDanhSachHanhVi().ToList();
        }

        public void Disconnect()
        {
            ws.Disconnect();
        }
    }
}
