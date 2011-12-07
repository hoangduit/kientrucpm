using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace QLBSX_DAL_WS
{
    [System.Xml.Serialization.XmlInclude(typeof(BienSoXeRomooc))]
    public class BienSoXeRomooc : BienSoXe
    {
        #region - Attribute
        private int _NamSanXuat;
        private KichThuocBao _Ktb;
        private int _TaiTrong;
        private DateTime _NgayHetHan;
        #endregion

        #region - Property
        public int NamSanXuat
        {
            get { return _NamSanXuat; }
            set { _NamSanXuat = value; }
        }
        public KichThuocBao Ktb
        {
            get { return _Ktb; }
            set { _Ktb = value; }
        }
        public int TaiTrong
        {
            get { return _TaiTrong; }
            set { _TaiTrong = value; }
        }
        public DateTime NgayHetHan
        {
            get { return _NgayHetHan; }
            set { _NgayHetHan = value; }
        }
        #endregion

        //public BienSoXeRomooc()
        //{
        //    _TenChuXe = _DiaChi = _NhanHieu = _MauSon = _SoKhung = _BienSo = "";
        //    _NgayDangKyLanDau = new DateTime(1900, 1, 1);
        //    _VoHieuHoa = false;
        //}
        //public BienSoXeRomooc(BienSoXe bs)
        //{
        //    _MaBienSo = bs.MaBienSo;
        //    _TenChuXe = bs.TenChuXe;
        //    _DiaChi = bs.DiaChi;
        //    _NhanHieu = bs.NhanHieu;
        //    _MauSon = bs.MauSon;
        //    _SoKhung = bs.SoKhung;
        //    _BienSo = bs.BienSo;
        //    _NgayDangKyLanDau = bs.NgayDangKyLanDau;
        //    _VoHieuHoa = bs.VoHieuHoa;
        //}

        public override string GetInfo()
        {
            string info = "<BS l='Romooc' "
                        + "nsx ='" + NamSanXuat + "' "
                        + "tat='" + TaiTrong + "' "
                        + "nhh='" + NgayHetHan.ToShortDateString() + "'>"
                        + "<KTB "
                            + "d='" + Ktb.Dai + "' "
                            + "r='" + Ktb.Rong + "' "
                            + "c='" + Ktb.Cao + "'/>"
                        + "</BS>";

            return info;
        }

        public static BienSoXeRomooc ConvertToRomooc(object bs)
        {
            if (bs is BienSoXeRomooc)
            {
                BienSoXeRomooc temp = new BienSoXeRomooc();
                temp = (BienSoXeRomooc)bs;
                return temp;
            }
            else
                return null;
        }

        public static BienSoXeRomooc FromDataReader(OleDbDataReader dr)
        {
            BienSoXeRomooc bs = new BienSoXeRomooc();
            bs.MaBienSo = dr.GetInt32(0);
            if (!dr.IsDBNull(1))
                bs.TenChuXe = dr.GetString(1);
            if (!dr.IsDBNull(2))
                bs.DiaChi = dr.GetString(2);
            if (!dr.IsDBNull(3))
                bs.NhanHieu = dr.GetString(3);
            if (!dr.IsDBNull(4))
                bs.MauSon = dr.GetString(4);
            if (!dr.IsDBNull(5))
                bs.SoKhung = dr.GetString(5);
            if (!dr.IsDBNull(6))
                bs.BienSo = dr.GetString(6);
            if (!dr.IsDBNull(7))
                bs.NgayDangKyLanDau = dr.GetDateTime(7);
            if (!dr.IsDBNull(8))
                bs.VoHieuHoa = dr.GetBoolean(8);

            return bs;
        }

        public override BienSoXe Clone()
        {
            return (BienSoXe)this.MemberwiseClone();
        }
    }
}