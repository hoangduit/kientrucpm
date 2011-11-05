using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBSX_DAL_WS
{
    [System.Xml.Serialization.XmlInclude(typeof(BienSoXeMotoDTO))]
    [System.Xml.Serialization.XmlInclude(typeof(BienSoXeOtoDTO))]
    [System.Xml.Serialization.XmlInclude(typeof(BienSoXeRomoocDTO))]
    public class BienSoXeDTO
    {
        protected int _MaBienSo;        
        protected string _TenChuXe;
        protected string _DiaChi;
        protected string _NhanHieu;
        protected string _MauSon;
        protected string _SoKhung;
        protected string _BienSo;
        protected DateTime _NgayDangKyLanDau;
        protected bool _VoHieuHoa;

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

        public BienSoXeDTO()
        {
            _TenChuXe = _DiaChi = _NhanHieu = _MauSon = _SoKhung = _BienSo = "";
            _VoHieuHoa = false;
        }
        public BienSoXeDTO(BienSoXeMotoDTO bs)
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
        public BienSoXeDTO(BienSoXeOtoDTO bs)
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
        public BienSoXeDTO(BienSoXeRomoocDTO bs)
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
    }
    public class BienSoXeMotoDTO : BienSoXeDTO
    {
        private string _LoaiXe;
        private string _SoMay;
        private int _DungTich;
        private int _CongSuat;
        private int _SoNguoiDuocPhepCho;

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

        public BienSoXeMotoDTO()
        {
            _TenChuXe = _DiaChi = _NhanHieu = _MauSon = _SoKhung = _BienSo = "";
            _NgayDangKyLanDau = new DateTime(1900, 1, 1);
            _VoHieuHoa = false;
        }
        public BienSoXeMotoDTO(BienSoXeDTO bs)
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
    }
    public class BienSoXeOtoDTO : BienSoXeDTO
    {
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

        public BienSoXeOtoDTO()
        {
            _TenChuXe = _DiaChi = _NhanHieu = _MauSon = _SoKhung = _BienSo = "";
            _NgayDangKyLanDau = new DateTime(1900, 1, 1);
            _VoHieuHoa = false;
        }
        public BienSoXeOtoDTO(BienSoXeDTO bs)
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
    }
    public class BienSoXeRomoocDTO : BienSoXeDTO
    {
        private int _NamSanXuat;
        private KichThuocBao _Ktb;
        private int _TaiTrong;
        private DateTime _NgayHetHan;

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

        public BienSoXeRomoocDTO()
        {
            _TenChuXe = _DiaChi = _NhanHieu = _MauSon = _SoKhung = _BienSo = "";
            _NgayDangKyLanDau = new DateTime(1900, 1, 1);
            _VoHieuHoa = false;
        }
        public BienSoXeRomoocDTO(BienSoXeDTO bs)
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
    }
    public class SoCho
    {
        private int _Ngoi;
        private int _Dung;
        private int _Nam;

        public int Ngoi
        {
            get { return _Ngoi; }
            set { _Ngoi = value; }
        }
        public int Dung
        {
            get { return _Dung; }
            set { _Dung = value; }
        }
        public int Nam
        {
            get { return _Nam; }
            set { _Nam = value; }
        }

        public SoCho()
        {
            _Ngoi = _Dung = _Nam = 0;
        }
        public SoCho(int ngoi, int dung, int nam)
        {
            _Ngoi = ngoi;
            _Dung = dung;
            _Nam = nam;
        }
    }
    public class KichThuocBao
    {
        private float _Dai;
        private float _Rong;
        private float _Cao;

        public float Dai
        {
            get { return _Dai; }
            set { _Dai = value; }
        }
        public float Rong
        {
            get { return _Rong; }
            set { _Rong = value; }
        }
        public float Cao
        {
            get { return _Cao; }
            set { _Cao = value; }
        }

        public KichThuocBao()
        {
            _Dai = _Rong = _Cao = 0;
        }
        public KichThuocBao(float dai, float rong, float cao)
        {
            _Dai = dai;
            _Rong = rong;
            _Cao = cao;
        }
    }
    
}
