using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLBSX_BUS_WS.QLBSX_DAL_WebService;
/**
 * Tên Đề Tài; Phần Mền Quản Lý Biển Số Xe và Vi Phạm Giao Thông(VLNM (Vehicle license number management))
 * Ho tên sinh viên:
 * 1. Phan Nhật Tiến       0812515
 * 2. Huỳnh Công Toàn      0812527
 * 
 * GVHD. Trần Minh Triết
 **/

namespace QLBSX_BUS_WS
{
    public class BienSoXeBUS
    {
        private QLBSX_DAL_WebServiceSoapClient ws = new QLBSX_DAL_WebServiceSoapClient();        
        public List<BienSoXe> LayDanhSachBienSoXe()
        {
            return ws.LayDanhSachBSX().ToList();            
        }
        public List<BienSoXe> LayDanhSachTongQuat()
        {
            return ws.LayDanhSachBSXTongQuat().ToList();
        }
        public bool ThemBienSoXe(object bs)
        {
            return ws.ThemBienSoXe(bs);
        }        
        public bool CapNhatBienSoXe(object bs)
        {
            return ws.CapNhatBienSoXe(bs);
        }
        public bool VoHieuHoaBienSoXe(object bs)
        {
            return ws.VoHieuHoaBienSoXe(bs);
        }
        public BienSoXe TraCuuTheoBienSo(string bienso)
        {
            return ws.TraCuuBSXTheoBienSo(bienso);
        }
        public BienSoXe TraCuuTheoMaBienSo(int mabienso)
        {
            return ws.TraCuuBSXTheoMaBienSo(mabienso);
        }
        public BienSoXeMoto LaMoto(object bs)
        {
            return ws.LaMoto(bs);
        }
        public BienSoXeOto LaOto(object bs)
        {
            return ws.LaOto(bs);
        }
        public BienSoXeRomooc LaRomooc(object bs)
        {
            return ws.LaRomooc(bs);
        }
        public KichThuocBao TaoKichThuocBao(float d, float r, float c)
        {
            return ws.TaoKichThuocBao(d,r,c);
        }
        public SoCho TaoSoCho(int ng, int d, int na)
        {
            return ws.TaoSoCho(ng,d,na);
        }
    }
}
