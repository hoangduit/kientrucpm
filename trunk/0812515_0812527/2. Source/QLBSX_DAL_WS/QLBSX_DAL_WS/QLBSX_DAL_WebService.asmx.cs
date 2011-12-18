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

namespace QLBSX_DAL_WS
{
    /// <summary>
    /// Summary description for QLBSX_DAL_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QLBSX_DAL_WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public void Connect()
        {
            DataProvider.Connect();
        }
        [WebMethod]
        public void Disconnect()
        {
            DataProvider.Disconnect();
        }
        /////////////////////////////////////////////////////////
        //////////          Biển số xe              /////////////
        /////////////////////////////////////////////////////////
        [WebMethod]
        public List<BienSoXe> LayDanhSachBSX()
        {
            return BienSoXeFactory.GetAllPlates();
        }
        [WebMethod]
        public List<BienSoXe> LayDanhSachBSXTongQuat()
        {
            return BienSoXeFactory.GetAllGeneralPlates();
        }
        [WebMethod]
        public bool ThemBienSoXe(object Xe)
        {
            return BienSoXeFactory.AddPlate(Xe);
        }
        [WebMethod]
        public bool CapNhatBienSoXe(object Xe)
        {
            return BienSoXeFactory.UpdatePlate(Xe);
        }
        [WebMethod]
        public bool VoHieuHoaBienSoXe(object bs)
        {
            return BienSoXeFactory.RemovePlate(bs);
        }
        [WebMethod]
        public BienSoXe TraCuuBSXTheoBienSo(string bienso)
        {
            return BienSoXeFactory.FindPlate(bienso);
        }
        [WebMethod]
        public BienSoXe TraCuuBSXTheoMaBienSo(int mabienso)
        {
            return BienSoXeFactory.FindPlate(mabienso);
        }
        [WebMethod]
        public BienSoXeMoto LaMoto(object bs)
        {
            return BienSoXeMoto.ConvertToMoto(bs);
        }
        [WebMethod]
        public BienSoXeOto LaOto(object bs)
        {
            return BienSoXeOto.ConvertToOto(bs);
        }
        [WebMethod]
        public BienSoXeRomooc LaRomooc(object bs)
        {
            return BienSoXeRomooc.ConvertToRomooc(bs);
        }
        [WebMethod]
        public KichThuocBao TaoKichThuocBao(float d, float r, float c)
        {
            return BienSoXe.TaoKichThuocBao(d, r, c);
        }
        [WebMethod]
        public SoCho TaoSoCho(int ng, int d, int na)
        {
            return BienSoXe.TaoSoCho(ng, d, na);
        }
        /////////////////////////////////////////////////////////
        //////////          Hành vi vi phạm              ////////
        /////////////////////////////////////////////////////////
        [WebMethod]
        public List<HanhViViPhamDTO> LayDanhSachHanhVi()
        {
            return HanhViViPhamDAO.LayDanhSachHanhVi();
        }
        [WebMethod]
        public bool ThemHanhVi(HanhViViPhamDTO hv)
        {
            return HanhViViPhamDAO.ThemHanhVi(hv);
        }
        [WebMethod]
        public bool VoHieuHoaHanhVi(HanhViViPhamDTO hv)
        {
            return HanhViViPhamDAO.VoHieuHoaHanhVi(hv);
        }
        [WebMethod]
        public bool CapNhatHanhVi(HanhViViPhamDTO hv)
        {
            return HanhViViPhamDAO.CapNhatHanhVi(hv);
        }
        [WebMethod]
        public HanhViViPhamDTO TraCuuHanhViTheoTenHanhVi(string ten)
        {
            return HanhViViPhamDAO.TraCuuTheoTenHanhVi(ten);
        }
        [WebMethod]
        public HanhViViPhamDTO TraCuuHanhViTheoMaHanhVi(int ma)
        {
            return HanhViViPhamDAO.TraCuuTheoMaHanhVi(ma);
        }
        /////////////////////////////////////////////////////////
        //////          Chi tiết hành vi vi phạm            /////
        /////////////////////////////////////////////////////////
        [WebMethod]
        public List<ChiTietHVVPDTO> LayDanhSachChiTietHanhVi()
        {
            return ChiTietHVVPDAO.LayDanhSachChiTietHanhVi();
        }
        [WebMethod]
        public bool ThemChiTietHanhVi(ChiTietHVVPDTO ct)
        {
            return ChiTietHVVPDAO.ThemChiTietHanhVi(ct);
        }
        [WebMethod]
        public bool CapNhatChiTietHanhVi(ChiTietHVVPDTO ct)
        {
            return ChiTietHVVPDAO.CapNhatChiTietHanhVi(ct);
        }
        [WebMethod]
        public List<ChiTietHVVPDTO> TraCuuCTHVTheoBienSo(string bienso)
        {
            return ChiTietHVVPDAO.TraCuuTheoBienSo(bienso);
        }
        [WebMethod]
        public List<ChiTietHVVPDTO> TraCuuCTHVTheoMaBienSo(int _mabs)
        {
            return ChiTietHVVPDAO.TraCuuTheoMaBienSo(_mabs);
        }
        [WebMethod]
        public List<ChiTietHVVPDTO> TraCuuCTHVTheoTenHanhVi(string tenhv)
        {
            return ChiTietHVVPDAO.TraCuuTheoTenHanhVi(tenhv);
        }
        [WebMethod]
        public List<ChiTietHVVPDTO> TraCuuCTHVTheoMaHanhVi(int _mahv)
        {
            return ChiTietHVVPDAO.TraCuuTheoMaHanhVi(_mahv);
        }
    }
}
