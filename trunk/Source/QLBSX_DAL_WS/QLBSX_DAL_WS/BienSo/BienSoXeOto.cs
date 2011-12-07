using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace QLBSX_DAL_WS
{
    [System.Xml.Serialization.XmlInclude(typeof(BienSoXeOto))]    
    public class BienSoXeOto : BienSoXe
    {
        #region - Attribute
        private string _LoaiXe;
        private string _SoMay;
        private int _DungTich;
        private int _CongSuat;
        private string _TenDongCo;
        private int _NamSanXuat;
        private string _TuTrong;
        private KichThuocBao _Ktb;
        private SoCho _Sc;
        private int _TaiTrongHangHoa;
        private DateTime _NgayHetHan;
        #endregion

        #region - Property
        public string LoaiXe
        {
            get { return _LoaiXe; }
            set { _LoaiXe = value; }
        }
        public string SoMay
        {
            get { return _SoMay; }
            set { _SoMay = value; }
        }
        public int DungTich
        {
            get { return _DungTich; }
            set { _DungTich = value; }
        }
        public int CongSuat
        {
            get { return _CongSuat; }
            set { _CongSuat = value; }
        }
        public string TenDongCo
        {
            get { return _TenDongCo; }
            set { _TenDongCo = value; }
        }
        public int NamSanXuat
        {
            get { return _NamSanXuat; }
            set { _NamSanXuat = value; }
        }
        public string TuTrong
        {
            get { return _TuTrong; }
            set { _TuTrong = value; }
        }
        public KichThuocBao Ktb
        {
            get { return _Ktb; }
            set { _Ktb = value; }
        }
        public SoCho Sc
        {
            get { return _Sc; }
            set { _Sc = value; }
        }
        public int TaiTrongHangHoa
        {
            get { return _TaiTrongHangHoa; }
            set { _TaiTrongHangHoa = value; }
        }
        public DateTime NgayHetHan
        {
            get { return _NgayHetHan; }
            set { _NgayHetHan = value; }
        }
        #endregion

        //public BienSoXeOto()
        //{
        //    _TenChuXe = _DiaChi = _NhanHieu = _MauSon = _SoKhung = _BienSo = "";
        //    _NgayDangKyLanDau = new DateTime(1900, 1, 1);
        //    _VoHieuHoa = false;
        //}
        //public BienSoXeOto(BienSoXe bs)
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
            string info = "<BS l='Oto' "
                        + "lx='" + LoaiXe + "' "
                        + "sm='" + SoMay + "' "
                        + "dt='" + DungTich + "' "
                        + "cs='" + CongSuat + "' "
                        + "tdc='" + TenDongCo + "' "
                        + "nsx='" + NamSanXuat + "' "
                        + "tut='" + TuTrong + "' "
                        + "tat='" + TaiTrongHangHoa + "' "
                        + "nhh='" + NgayHetHan.ToShortDateString() + "'>"
                        + "<KTB "
                            + "d='" + Ktb.Dai + "' "
                            + "r='" + Ktb.Rong + "' "
                            + "c='" + Ktb.Cao + "'/>"
                        + "<SC "
                            + "ng='" + Sc.Ngoi + "' "
                            + "d='" + Sc.Dung + "' "
                            + "na='" + Sc.Nam + "'/>"
                        + "</BS>";

            return info;
        }        

        public static BienSoXeOto ConvertToOto(object bs)
        {
            if (bs is BienSoXeOto)
            {
                BienSoXeOto temp = new BienSoXeOto();
                temp = (BienSoXeOto)bs;
                return temp;
            }
            else
                return null;
        }

        public static BienSoXeOto FromDataReader(OleDbDataReader dr)
        {
            BienSoXeOto bs = new BienSoXeOto();
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