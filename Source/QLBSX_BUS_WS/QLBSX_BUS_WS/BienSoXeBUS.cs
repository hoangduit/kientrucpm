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
        public List<BienSoXeDTO> LayDanhSachBienSoXe()
        {
            return ws.LayDanhSachBSX();            
        }
        public List<BienSoXeDTO> LayDanhSachTongQuat()
        {
            return ws.LayDanhSachBSXTongQuat();
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
        public BienSoXeDTO TraCuuTheoBienSo(string bienso)
        {
            return ws.TraCuuBSXTheoBienSo(bienso);
        }
        public BienSoXeDTO TraCuuTheoMaBienSo(int mabienso)
        {
            return ws.TraCuuBSXTheoMaBienSo(mabienso);
        }
        public BienSoXeMotoDTO LaMoto(object bs)
        {
            return ws.LaMoto(bs);
        }
        public BienSoXeOtoDTO LaOto(object bs)
        {
            return ws.LaOto(bs);
        }
        public BienSoXeRomoocDTO LaRomooc(object bs)
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
