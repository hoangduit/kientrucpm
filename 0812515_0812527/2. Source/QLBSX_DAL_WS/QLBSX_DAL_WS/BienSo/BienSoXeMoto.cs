using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Data.OleDb;

namespace QLBSX_DAL_WS
{
    [System.Xml.Serialization.XmlInclude(typeof(BienSoXeMoto))]
    public class BienSoXeMoto : BienSoXe
    {        
        #region - Attribute
        private string _LoaiXe;
        private string _SoMay;
        private int _DungTich;
        private int _CongSuat;
        private int _SoNguoiDuocPhepCho;
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
        public int SoNguoiDuocPhepCho
        {
            get { return _SoNguoiDuocPhepCho; }
            set { _SoNguoiDuocPhepCho = value; }
        }
        #endregion

        //public BienSoXeMoto()
        //{
        //    _TenChuXe = _DiaChi = _NhanHieu = _MauSon = _SoKhung = _BienSo = "";
        //    _NgayDangKyLanDau = new DateTime(1900, 1, 1);
        //    _VoHieuHoa = false;
        //}
        //public BienSoXeMoto(BienSoXe bs)
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
            String info = "<BS l='Moto' "
                            + "lx='" + LoaiXe + "' "
                            + "sm='" + SoMay + "' "
                            + "dt='" + DungTich + "' "
                            + "cs='" + CongSuat + "' "
                            + "sn='" + SoNguoiDuocPhepCho + "'/>";

            return info;
        }

        public static BienSoXeMoto ConvertToMoto(object bs)
        {
            if (bs is BienSoXeMoto)
            {
                BienSoXeMoto temp = new BienSoXeMoto();
                temp = (BienSoXeMoto)bs;
                return temp;
            }
            else
                return null;
        }

        public static BienSoXeMoto FromDataReader(OleDbDataReader dr)
        {
            BienSoXeMoto bs = new BienSoXeMoto();
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