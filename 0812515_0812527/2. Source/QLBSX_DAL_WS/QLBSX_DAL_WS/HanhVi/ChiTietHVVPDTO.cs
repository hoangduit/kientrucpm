using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * Tên Đề Tài; Phần Mền Quản Lý Biển Số Xe và Vi Phạm Giao Thông(VLNM (Vehicle license number management))
 * Ho tên sinh viên:
 * 1. Phan Nhật Tiến       0812515
 * 2. Huỳnh Công Toàn      0812527
 * 
 * GVHD. Trần Minh Triết
 **/
namespace QLBSX_DAL_WS
{
    public class ChiTietHVVPDTO
    {
        private int _MaChiTiet;
        private HanhViViPhamDTO _HanhVi;
        private object _BienSo;
        private DateTime _ThoiGian;
        private string _NguoiLapBienBan;
        private double _TienPhat;

        public int MaChiTiet
        {
            get { return _MaChiTiet; }
            set { _MaChiTiet = value; }
        }
        public HanhViViPhamDTO HanhVi
        {
            get { return _HanhVi; }
            set { _HanhVi = value; }
        }
        public object BienSo
        {
            get { return _BienSo; }
            set { _BienSo = value; }
        }
        public DateTime ThoiGian
        {
            get { return _ThoiGian; }
            set { _ThoiGian = value; }
        }
        public string NguoiLapBienBan
        {
            get { return _NguoiLapBienBan; }
            set { _NguoiLapBienBan = value; }
        }
        public double TienPhat
        {
            get { return _TienPhat; }
            set { _TienPhat = value; }
        }
    }
}
