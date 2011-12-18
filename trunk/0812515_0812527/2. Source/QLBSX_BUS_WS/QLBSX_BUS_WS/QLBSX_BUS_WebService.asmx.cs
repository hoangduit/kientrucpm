using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using QLBSX_BUS_WS.QLBSX_DAL_WebService;

namespace QLBSX_BUS_WS
{
    /// <summary>
    /// Summary description for QLBSX_BUS_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLBSX_BUS_WebService : System.Web.Services.WebService
    {
        [System.Xml.Serialization.XmlInclude(typeof(BienSoXeMoto))]
        [System.Xml.Serialization.XmlInclude(typeof(BienSoXeOto))]
        [System.Xml.Serialization.XmlInclude(typeof(BienSoXeRomooc))]

        [WebMethod]
        public void Connect()
        {
            DataProviderBUS dp = new DataProviderBUS();
            dp.Connect();
        }
        [WebMethod]
        public void Disconnect()
        {
            DataProviderBUS dp = new DataProviderBUS();
            dp.Disconnect();
        }
        /////////////////////////////////////////////////////////
        //////////          Biển số xe              /////////////
        /////////////////////////////////////////////////////////
        [WebMethod]
        public List<BienSoXe> LayDanhSachBienSoXe()
        {
            BienSoXeBUS bienso = new BienSoXeBUS();
            return bienso.LayDanhSachBienSoXe();            
        }
        [WebMethod]
        public List<BienSoXe> LayDanhSachBSXTongQuat()
        {
            BienSoXeBUS bienso = new BienSoXeBUS();
            return bienso.LayDanhSachTongQuat();
        }
        [WebMethod]
        public bool ThemBienSoXe(object bs)
        {
            BienSoXeBUS bienso = new BienSoXeBUS();
            return bienso.ThemBienSoXe(bs);
        }
        [WebMethod]
        public bool CapNhatBienSoXe(object bs)
        {
            BienSoXeBUS bienso = new BienSoXeBUS();
            return bienso.CapNhatBienSoXe(bs);
        }
        [WebMethod]
        public bool VoHieuHoaBienSoXe(object bs)
        {
            BienSoXeBUS bienso = new BienSoXeBUS();
            return bienso.VoHieuHoaBienSoXe(bs);
        }
        [WebMethod]
        public BienSoXe TraCuuBSXTheoBienSo(string bienso)
        {
            BienSoXeBUS bs = new BienSoXeBUS();
            return bs.TraCuuTheoBienSo(bienso);
        }
        [WebMethod]
        public BienSoXe TraCuuBSXTheoMaBienSo(int mabienso)
        {
            BienSoXeBUS bs = new BienSoXeBUS();
            return bs.TraCuuTheoMaBienSo(mabienso);
        }
        [WebMethod]
        public BienSoXeMoto LaMoto(object bs)
        {
            BienSoXeBUS bienso = new BienSoXeBUS();
            return bienso.LaMoto(bs);
        }
        [WebMethod]
        public BienSoXeOto LaOto(object bs)
        {
            BienSoXeBUS bienso = new BienSoXeBUS();
            return bienso.LaOto(bs);
        }
        [WebMethod]
        public BienSoXeRomooc LaRomooc(object bs)
        {
            BienSoXeBUS bienso = new BienSoXeBUS();
            return bienso.LaRomooc(bs);
        }
        [WebMethod]
        public KichThuocBao TaoKichThuocBao(float d, float r, float c)
        {
            BienSoXeBUS bienso = new BienSoXeBUS();
            return bienso.TaoKichThuocBao(d,r,c);
        }
        [WebMethod]
        public SoCho TaoSoCho(int ng, int d, int na)
        {
            BienSoXeBUS bienso = new BienSoXeBUS();
            return bienso.TaoSoCho(ng,d,na);
        }
        /////////////////////////////////////////////////////////
        //////////          Hành vi vi phạm              ////////
        /////////////////////////////////////////////////////////        
        [WebMethod]
        public List<HanhViViPhamDTO> LayDanhSachHanhVi()
        {
            HanhViViPhamBUS hanhvi = new HanhViViPhamBUS();
            return hanhvi.LayDanhSachHanhVi();
        }
        [WebMethod]
        public bool ThemHanhVi(HanhViViPhamDTO hv)
        {
            HanhViViPhamBUS hanhvi = new HanhViViPhamBUS();
            return hanhvi.ThemHanhVi(hv);
        }
        [WebMethod]
        public bool VoHieuHoaHanhVi(HanhViViPhamDTO hv)
        {
            HanhViViPhamBUS hanhvi = new HanhViViPhamBUS();
            return hanhvi.VoHieuHoaHanhVi(hv);
        }
        [WebMethod]
        public bool CapNhatHanhVi(HanhViViPhamDTO hv)
        {
            HanhViViPhamBUS hanhvi = new HanhViViPhamBUS();
            return hanhvi.CapNhatHanhVi(hv);
        }
        [WebMethod]
        public HanhViViPhamDTO TraCuuHanhViTheoTenHanhVi(string ten)
        {
            HanhViViPhamBUS hanhvi = new HanhViViPhamBUS();
            return hanhvi.TraCuuTheoTenHanhVi(ten);
        }
        [WebMethod]
        public HanhViViPhamDTO TraCuuHanhViTheoMaHanhVi(int ma)
        {
            HanhViViPhamBUS hanhvi = new HanhViViPhamBUS();
            return hanhvi.TraCuuTheoMaHanhVi(ma);
        }
        /////////////////////////////////////////////////////////
        //////          Chi tiết hành vi vi phạm            /////
        /////////////////////////////////////////////////////////
        [WebMethod]
        public List<ChiTietHVVPDTO> LayDanhSachChiTietHanhVi()
        {
            ChiTietHVVPBUS cthv = new ChiTietHVVPBUS();
            return cthv.LayDanhSachChiTietHanhVi();
        }
        [WebMethod]
        public bool ThemChiTietHanhVi(ChiTietHVVPDTO ct)
        {
            ChiTietHVVPBUS cthv = new ChiTietHVVPBUS();
            return cthv.ThemChiTietHanhVi(ct);
        }
        [WebMethod]
        public bool CapNhatChiTietHanhVi(ChiTietHVVPDTO ct)
        {
            ChiTietHVVPBUS cthv = new ChiTietHVVPBUS();
            return cthv.CapNhatChiTietHanhVi(ct);
        }
        [WebMethod]
        public List<ChiTietHVVPDTO> TraCuuCTHVTheoBienSo(string bienso)
        {
            ChiTietHVVPBUS cthv = new ChiTietHVVPBUS();
            return cthv.TraCuuTheoBienSo(bienso);
        }
        [WebMethod]
        public List<ChiTietHVVPDTO> TraCuuCTHVTheoMaBienSo(int _mabs)
        {
            ChiTietHVVPBUS cthv = new ChiTietHVVPBUS();
            return cthv.TraCuuTheoMaBienSo(_mabs);
        }
        [WebMethod]
        public List<ChiTietHVVPDTO> TraCuuCTHVTheoTenHanhVi(string tenhv)
        {
            ChiTietHVVPBUS cthv = new ChiTietHVVPBUS();
            return cthv.TraCuuTheoTenHanhVi(tenhv);
        }
        [WebMethod]
        public List<ChiTietHVVPDTO> TraCuuCTHVTheoMaHanhVi(int _mahv)
        {
            ChiTietHVVPBUS cthv = new ChiTietHVVPBUS();
            return cthv.TraCuuTheoMaHanhVi(_mahv);
        }
    }
}
