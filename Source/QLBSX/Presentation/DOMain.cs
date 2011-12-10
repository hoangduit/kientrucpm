using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Presentation.QLBSX_BUS_WebService;
namespace Presentation
{
    public class DOMain
    {
        private QLBSX_BUS_WebServiceSoapClient WebServieDO = new QLBSX_BUS_WebServiceSoapClient();
        public bool ThemChiTietHanhVi(ChiTietHVVPDTO ct)
        {
            return WebServieDO.ThemChiTietHanhVi(ct);
        }
        public bool ThemHanhVi(HanhViViPhamDTO hv)
        {
            return WebServieDO.ThemHanhVi(hv);
        }
        public HanhViViPhamDTO TraCuuHanhViTheoTenHanhVi(string ten)
        {
            return WebServieDO.TraCuuHanhViTheoTenHanhVi(ten);
        }

        public bool VoHieuHoaHanhVi(HanhViViPhamDTO hv)
        {
            return  WebServieDO.VoHieuHoaHanhVi(hv);
        }
        public bool CapNhatHanhVi(HanhViViPhamDTO hv)
        {
            return WebServieDO.CapNhatHanhVi(hv);
        }
        public List<BienSoXe> LayDanhSachBienSoXe()
        {
            return WebServieDO.LayDanhSachBienSoXe().ToList();
        }

        public List<ChiTietHVVPDTO> LayDanhSachChiTietHanhVi()
        {
            return WebServieDO.LayDanhSachChiTietHanhVi().ToList();
        }

        public List<HanhViViPhamDTO> LayDanhSachHanhVi()
        {
            return WebServieDO.LayDanhSachHanhVi().ToList();
        }

        public void Disconnect()
        {
            WebServieDO.Disconnect();
        }
    }
}
