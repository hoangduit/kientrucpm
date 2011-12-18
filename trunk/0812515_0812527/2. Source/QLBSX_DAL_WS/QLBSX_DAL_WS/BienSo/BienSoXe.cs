using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace QLBSX_DAL_WS
{
    [System.Xml.Serialization.XmlInclude(typeof(BienSoXeRomooc))]
    [System.Xml.Serialization.XmlInclude(typeof(BienSoXeMoto))]
    [System.Xml.Serialization.XmlInclude(typeof(BienSoXeOto))]
    public abstract class BienSoXe
    {
        #region - Attribute
        protected int _MaBienSo;
        protected string _TenChuXe;
        protected string _DiaChi;
        protected string _NhanHieu;
        protected string _MauSon;
        protected string _SoKhung;
        protected string _BienSo;
        protected DateTime _NgayDangKyLanDau;
        protected bool _VoHieuHoa;
        #endregion

        #region - Property
        public int MaBienSo
        {
            get { return _MaBienSo; }
            set { _MaBienSo = value; }
        }
        public string TenChuXe
        {
            get { return _TenChuXe; }
            set { _TenChuXe = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string NhanHieu
        {
            get { return _NhanHieu; }
            set { _NhanHieu = value; }
        }
        public string MauSon
        {
            get { return _MauSon; }
            set { _MauSon = value; }
        }
        public string SoKhung
        {
            get { return _SoKhung; }
            set { _SoKhung = value; }
        }
        public string BienSo
        {
            get { return _BienSo; }
            set { _BienSo = value; }
        }
        public DateTime NgayDangKyLanDau
        {
            get { return _NgayDangKyLanDau; }
            set { _NgayDangKyLanDau = value; }
        }
        public bool VoHieuHoa
        {
            get { return _VoHieuHoa; }
            set { _VoHieuHoa = value; }
        }
        #endregion

        public BienSoXe()
        {
            _TenChuXe = _DiaChi = _NhanHieu = _MauSon = _SoKhung = _BienSo = "";
            _VoHieuHoa = false;
        }
        public BienSoXe(BienSoXeMoto bs)
        {
            _MaBienSo = bs.MaBienSo;
            _TenChuXe = bs.TenChuXe;
            _DiaChi = bs.DiaChi;
            _NhanHieu = bs.NhanHieu;
            _MauSon = bs.MauSon;
            _SoKhung = bs.SoKhung;
            _BienSo = bs.BienSo;
            _NgayDangKyLanDau = bs.NgayDangKyLanDau;
            _VoHieuHoa = bs.VoHieuHoa;
        }
        public BienSoXe(BienSoXeOto bs)
        {
            _MaBienSo = bs.MaBienSo;
            _TenChuXe = bs.TenChuXe;
            _DiaChi = bs.DiaChi;
            _NhanHieu = bs.NhanHieu;
            _MauSon = bs.MauSon;
            _SoKhung = bs.SoKhung;
            _BienSo = bs.BienSo;
            _NgayDangKyLanDau = bs.NgayDangKyLanDau;
            _VoHieuHoa = bs.VoHieuHoa;
        }
        public BienSoXe(BienSoXeRomooc bs)
        {
            _MaBienSo = bs.MaBienSo;
            _TenChuXe = bs.TenChuXe;
            _DiaChi = bs.DiaChi;
            _NhanHieu = bs.NhanHieu;
            _MauSon = bs.MauSon;
            _SoKhung = bs.SoKhung;
            _BienSo = bs.BienSo;
            _NgayDangKyLanDau = bs.NgayDangKyLanDau;
            _VoHieuHoa = bs.VoHieuHoa;
        }

        public abstract string GetInfo();

        public virtual bool Add()
        {
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "INSERT INTO BienSoXe(TenChuXe, DiaChi, NhanHieu, MauSon, SoKhung, BienSo, NgayDangKyLanDau, VoHieuHoa, ThongTinRieng) VALUES";
                chuoiLenh += "(@ten,@diachi,@nhanhieu,@mauson,@sokhung,@bienso, @ngaydangkylandau,@vohieuhoa,@thongtinrieng)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@ten", OleDbType.VarChar);
                thamSo.Value = TenChuXe;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@diachi", OleDbType.VarChar);
                thamSo.Value = DiaChi;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@nhanhieu", OleDbType.VarChar);
                thamSo.Value = NhanHieu;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@mauson", OleDbType.VarChar);
                thamSo.Value = MauSon;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@sokhung", OleDbType.VarChar);
                thamSo.Value = SoKhung;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@bienso", OleDbType.VarChar);
                thamSo.Value = BienSo;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@ngaydangkylandau", OleDbType.Date);
                thamSo.Value = NgayDangKyLanDau;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@vohieuhoa", OleDbType.Boolean);
                thamSo.Value = VoHieuHoa;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@thongtinrieng", OleDbType.VarChar);
                thamSo.Value = this.GetInfo();
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                return false;
            }

            return true;
        }
        public virtual bool Update()
        {
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "UPDATE BienSoXe SET "
                    + "TenChuXe = '" + TenChuXe + "', "
                    + "DiaChi = '" + DiaChi + "', "
                    + "NhanHieu = '" + NhanHieu + "', "
                    + "MauSon = '" + MauSon + "', "
                    + "SoKhung = '" + SoKhung + "', "
                    + "BienSo = '" + BienSo + "', "
                    + "NgayDangKyLanDau = '" + NgayDangKyLanDau.ToShortDateString() + "', "
                    + "VoHieuHoa = @vhh, "
                    + "ThongTinRieng = @info "
                    + "WHERE MaBienSo = " + MaBienSo;

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@vhh", OleDbType.Boolean);
                thamSo.Value = VoHieuHoa;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@info", OleDbType.VarChar);
                thamSo.Value = this.GetInfo();
                lenh.Parameters.Add(thamSo);

                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return false;
            }

            return true;
        }
        public virtual bool Remove()
        {
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "UPDATE BienSoXe SET "
                    + "VoHieuHoa = @vhh "
                    + "WHERE MaBienSo = " + MaBienSo;

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@vhh", OleDbType.Boolean);
                thamSo.Value = true;
                lenh.Parameters.Add(thamSo);

                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return false;
            }
            return true;
        }

        public static KichThuocBao TaoKichThuocBao(float d, float r, float c)
        {
            KichThuocBao ktb = new KichThuocBao(d, r, c);
            return ktb;
        }
        public static SoCho TaoSoCho(int ng, int d, int na)
        {
            SoCho sc = new SoCho(ng, d, na);
            return sc;
        }

        public abstract BienSoXe Clone();
    }    
}
