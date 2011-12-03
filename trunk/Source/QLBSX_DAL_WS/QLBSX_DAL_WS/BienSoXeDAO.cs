using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data.OleDb;
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
    public class BienSoXeDAO
    {
        public static List<BienSoXeDTO> LayDanhSachBienSoXe()
        {
            DataProvider.Connect();
            List<BienSoXeDTO> ds = new List<BienSoXeDTO>();
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM BienSoXe";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    //Đọc các thông tin chung vào đối tượng bs
                    BienSoXeDTO bs = new BienSoXeDTO();
                    bs.MaBienSo = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        bs.TenChuXe = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        bs.DiaChi = boDoc.GetString(2);
                    if (!boDoc.IsDBNull(3))
                        bs.NhanHieu = boDoc.GetString(3);
                    if (!boDoc.IsDBNull(4))
                        bs.MauSon = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        bs.SoKhung = boDoc.GetString(5);
                    if (!boDoc.IsDBNull(6))
                        bs.BienSo = boDoc.GetString(6);
                    if (!boDoc.IsDBNull(7))
                        bs.NgayDangKyLanDau = boDoc.GetDateTime(7);
                    if (!boDoc.IsDBNull(8))
                        bs.VoHieuHoa = boDoc.GetBoolean(8);

                    string info = boDoc.GetString(9);
                    XmlDocument reader = new XmlDocument();
                    reader.LoadXml(info);
                    XmlElement e = reader.DocumentElement;
                    //Đọc các thông tin riêng nếu là môtô
                    if (e.Attributes[0].Value == "Moto")
                    {
                        BienSoXeMotoDTO Moto = new BienSoXeMotoDTO(bs);
                        Moto.LoaiXe = e.Attributes[1].Value;
                        Moto.SoMay = e.Attributes[2].Value;
                        Moto.DungTich = int.Parse(e.Attributes[3].Value);
                        Moto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Moto.SoNguoiDuocPhepCho = int.Parse(e.Attributes[5].Value);

                        ds.Add(Moto);
                    }
                    //Đọc các thông tin riêng nếu là Ôtô
                    else if (e.Attributes[0].Value == "Oto")
                    {
                        BienSoXeOtoDTO Oto = new BienSoXeOtoDTO(bs);
                        Oto.LoaiXe = e.Attributes[1].Value;
                        Oto.SoMay = e.Attributes[2].Value;
                        Oto.DungTich = int.Parse(e.Attributes[3].Value);
                        Oto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Oto.TenDongCo = e.Attributes[5].Value;
                        Oto.NamSanXuat = int.Parse(e.Attributes[6].Value);
                        Oto.TuTrong = e.Attributes[7].Value;
                        Oto.Ktb = new KichThuocBao();
                        Oto.Ktb.Dai = float.Parse(e.ChildNodes[0].Attributes[0].Value);
                        Oto.Ktb.Rong = float.Parse(e.ChildNodes[0].Attributes[1].Value);
                        Oto.Ktb.Cao = float.Parse(e.ChildNodes[0].Attributes[2].Value);
                        Oto.Sc = new SoCho();
                        Oto.Sc.Ngoi = int.Parse(e.ChildNodes[1].Attributes[0].Value);
                        Oto.Sc.Dung = int.Parse(e.ChildNodes[1].Attributes[1].Value);
                        Oto.Sc.Nam = int.Parse(e.ChildNodes[1].Attributes[2].Value);
                        Oto.TaiTrongHangHoa = int.Parse(e.Attributes[8].Value);
                        string[] temp = e.Attributes[9].Value.Split('/');
                        Oto.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        ds.Add(Oto);
                    }
                    //Đọc các thông tin riêng nếu là Rơmoóc
                    else
                    {
                        BienSoXeRomoocDTO Romooc = new BienSoXeRomoocDTO(bs);
                        Romooc.NamSanXuat = int.Parse(e.Attributes[1].Value);
                        Romooc.Ktb = new KichThuocBao();
                        Romooc.Ktb.Dai = float.Parse(e.FirstChild.Attributes[0].Value);
                        Romooc.Ktb.Rong = float.Parse(e.FirstChild.Attributes[1].Value);
                        Romooc.Ktb.Cao = float.Parse(e.FirstChild.Attributes[2].Value);
                        Romooc.TaiTrong = int.Parse(e.Attributes[2].Value);
                        string[] temp = e.Attributes[3].Value.Split('/');
                        Romooc.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        ds.Add(Romooc);
                    }
                }
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                ds = new List<BienSoXeDTO>();
            }
            finally
            {
                //DataProvider.Disconnect();
            }
            return ds;
        }
        public static List<BienSoXeDTO> LayDanhSachTongQuat()
        {
            
            List<BienSoXeDTO> ds = new List<BienSoXeDTO>();
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM BienSoXe";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    //Đọc các thông tin chung vào đối tượng bs
                    BienSoXeDTO bs = new BienSoXeDTO();
                    bs.MaBienSo = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        bs.TenChuXe = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        bs.DiaChi = boDoc.GetString(2);
                    if (!boDoc.IsDBNull(3))
                        bs.NhanHieu = boDoc.GetString(3);
                    if (!boDoc.IsDBNull(4))
                        bs.MauSon = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        bs.SoKhung = boDoc.GetString(5);
                    if (!boDoc.IsDBNull(6))
                        bs.BienSo = boDoc.GetString(6);
                    if (!boDoc.IsDBNull(7))
                        bs.NgayDangKyLanDau = boDoc.GetDateTime(7);
                    if (!boDoc.IsDBNull(8))
                        bs.VoHieuHoa = boDoc.GetBoolean(8);

                    ds.Add(bs);
                }
            }
            catch (Exception)
            {
                ds = new List<BienSoXeDTO>();
            }
            finally
            {
                
                    //DataProvider.Disconnect();
            }
            return ds;
        }
        public static bool ThemBienSoXe(object Xe)
        {
            string info;
            BienSoXeDTO general;
            if (Xe is BienSoXeMotoDTO)
            {
                BienSoXeMotoDTO bs = new BienSoXeMotoDTO();
                bs = (BienSoXeMotoDTO)Xe;
                general = new BienSoXeDTO(bs);
                info = "<BS l='Moto' "
                        + "lx='" + bs.LoaiXe + "' "
                        + "sm='" + bs.SoMay + "' "
                        + "dt='" + bs.DungTich + "' "
                        + "cs='" + bs.CongSuat + "' "
                        + "sn='" + bs.SoNguoiDuocPhepCho + "'/>";
            }
            else if (Xe is BienSoXeOtoDTO)
            {
                BienSoXeOtoDTO bs = new BienSoXeOtoDTO();
                bs = (BienSoXeOtoDTO)Xe;
                general = new BienSoXeDTO(bs);
                info = "<BS l='Oto' "
                        + "lx='" + bs.LoaiXe + "' "
                        + "sm='" + bs.SoMay + "' "
                        + "dt='" + bs.DungTich + "' "
                        + "cs='" + bs.CongSuat + "' "
                        + "tdc='" + bs.TenDongCo + "' "
                        + "nsx='" + bs.NamSanXuat + "' "
                        + "tut='" + bs.TuTrong + "' "
                        + "tat='" + bs.TaiTrongHangHoa + "' "
                        + "nhh='" + bs.NgayHetHan.ToShortDateString() + "'>"
                        + "<KTB "
                            + "d='" + bs.Ktb.Dai + "' "
                            + "r='" + bs.Ktb.Rong + "' "
                            + "c='" + bs.Ktb.Cao + "'/>"
                        + "<SC "
                            + "ng='" + bs.Sc.Ngoi + "' "
                            + "d='" + bs.Sc.Dung + "' "
                            + "na='" + bs.Sc.Nam + "'/>"
                        + "</BS>";
            }
            else if (Xe is BienSoXeRomoocDTO)
            {
                BienSoXeRomoocDTO bs = new BienSoXeRomoocDTO();
                bs = (BienSoXeRomoocDTO)Xe;
                general = new BienSoXeDTO(bs);
                info = "<BS l='Romooc' "
                        + "nsx ='" + bs.NamSanXuat + "' "
                        + "tat='" + bs.TaiTrong + "' "
                        + "nhh='" + bs.NgayHetHan.ToShortDateString() + "'>"
                        + "<KTB "
                            + "d='" + bs.Ktb.Dai + "' "
                            + "r='" + bs.Ktb.Rong + "' "
                            + "c='" + bs.Ktb.Cao + "'/>"
                        + "</BS>";
            }
            else
                return false;

            
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "INSERT INTO BienSoXe(TenChuXe, DiaChi, NhanHieu, MauSon, SoKhung, BienSo, NgayDangKyLanDau, VoHieuHoa, ThongTinRieng) VALUES";
                chuoiLenh += "(@ten,@diachi,@nhanhieu,@mauson,@sokhung,@bienso, @ngaydangkylandau,@vohieuhoa,@thongtinrieng)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@ten", OleDbType.VarChar);
                thamSo.Value = general.TenChuXe;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@diachi", OleDbType.VarChar);
                thamSo.Value = general.DiaChi;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@nhanhieu", OleDbType.VarChar);
                thamSo.Value = general.NhanHieu;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@mauson", OleDbType.VarChar);
                thamSo.Value = general.MauSon;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@sokhung", OleDbType.VarChar);
                thamSo.Value = general.SoKhung;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@bienso", OleDbType.VarChar);
                thamSo.Value = general.BienSo;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@ngaydangkylandau", OleDbType.Date);
                thamSo.Value = general.NgayDangKyLanDau;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@vohieuhoa", OleDbType.Boolean);
                thamSo.Value = general.VoHieuHoa;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@thongtinrieng", OleDbType.VarChar);
                thamSo.Value = info;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                return false;
            }
            finally
            {
                
                    //DataProvider.Disconnect();
            }
            return true;
        }
        public static bool CapNhatBienSoXe(object Xe)
        {
            string info;
            BienSoXeDTO general;
            if (Xe is BienSoXeMotoDTO)
            {
                BienSoXeMotoDTO bs = new BienSoXeMotoDTO();
                bs = (BienSoXeMotoDTO)Xe;
                general = new BienSoXeDTO(bs);
                info = "<BS l='Moto' "
                        + "lx='" + bs.LoaiXe + "' "
                        + "sm='" + bs.SoMay + "' "
                        + "dt='" + bs.DungTich + "' "
                        + "cs='" + bs.CongSuat + "' "
                        + "sn='" + bs.SoNguoiDuocPhepCho + "'/>";
            }
            else if (Xe is BienSoXeOtoDTO)
            {
                BienSoXeOtoDTO bs = new BienSoXeOtoDTO();
                bs = (BienSoXeOtoDTO)Xe;
                general = new BienSoXeDTO(bs);
                info = "<BS l='Oto' "
                        + "lx='" + bs.LoaiXe + "' "
                        + "sm='" + bs.SoMay + "' "
                        + "dt='" + bs.DungTich + "' "
                        + "cs='" + bs.CongSuat + "' "
                        + "tdc='" + bs.TenDongCo + "' "
                        + "nsx='" + bs.NamSanXuat + "' "
                        + "tut='" + bs.TuTrong + "' "
                        + "tat='" + bs.TaiTrongHangHoa + "' "
                        + "nhh='" + bs.NgayHetHan.ToShortDateString() + "'>"
                        + "<KTB "
                            + "d='" + bs.Ktb.Dai + "' "
                            + "r='" + bs.Ktb.Rong + "' "
                            + "c='" + bs.Ktb.Cao + "'/>"
                        + "<SC "
                            + "ng='" + bs.Sc.Ngoi + "' "
                            + "d='" + bs.Sc.Dung + "' "
                            + "na='" + bs.Sc.Nam + "'/>"
                        + "</BS>";
            }
            else if (Xe is BienSoXeRomoocDTO)
            {
                BienSoXeRomoocDTO bs = new BienSoXeRomoocDTO();
                bs = (BienSoXeRomoocDTO)Xe;
                general = new BienSoXeDTO(bs);
                info = "<BS l='Romooc' "
                        + "nsx ='" + bs.NamSanXuat + "' "
                        + "tat='" + bs.TaiTrong + "' "
                        + "nhh='" + bs.NgayHetHan.ToShortDateString() + "'>"
                        + "<KTB "
                            + "d='" + bs.Ktb.Dai + "' "
                            + "r='" + bs.Ktb.Rong + "' "
                            + "c='" + bs.Ktb.Cao + "'/>"
                        + "</BS>";
            }
            else
                return false;

            
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "UPDATE BienSoXe SET "
                    + "TenChuXe = '" + general.TenChuXe + "', "
                    + "DiaChi = '" + general.DiaChi + "', "
                    + "NhanHieu = '" + general.NhanHieu + "', "
                    + "MauSon = '" + general.MauSon + "', "
                    + "SoKhung = '" + general.SoKhung + "', "
                    + "BienSo = '" + general.BienSo + "', "
                    + "NgayDangKyLanDau = '" + general.NgayDangKyLanDau.ToShortDateString() + "', "
                    + "VoHieuHoa = @vhh, "                    
                    + "ThongTinRieng = @info "
                    + "WHERE MaBienSo = " + general.MaBienSo;

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@vhh", OleDbType.Boolean);
                thamSo.Value = general.VoHieuHoa;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@info", OleDbType.VarChar);
                thamSo.Value = info;
                lenh.Parameters.Add(thamSo);

                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return false;
            }
            finally
            {
                
                    //DataProvider.Disconnect();
            }
            return true;
        }
        public static bool VoHieuHoaBienSoXe(object bs)
        {
            int maso;
            if (bs is BienSoXeMotoDTO)
            {
                BienSoXeMotoDTO temp = new BienSoXeMotoDTO();
                temp = (BienSoXeMotoDTO)bs;
                maso = temp.MaBienSo;
            }
            else if (bs is BienSoXeOtoDTO)
            {
                BienSoXeOtoDTO temp = new BienSoXeOtoDTO();
                temp = (BienSoXeOtoDTO)bs;
                maso = temp.MaBienSo;
            }
            else if (bs is BienSoXeRomoocDTO)
            {
                BienSoXeRomoocDTO temp = new BienSoXeRomoocDTO();
                temp = (BienSoXeRomoocDTO)bs;
                maso = temp.MaBienSo;
            }
            else
                return false;

            
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "UPDATE BienSoXe SET "
                    + "VoHieuHoa = @vhh "
                    + "WHERE MaBienSo = " + maso;

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
            finally
            {
                
                    //DataProvider.Disconnect();
            }
            return true;
        }
        public static BienSoXeDTO TraCuuTheoBienSo(string bienso)
        {
            
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM BienSoXe WHERE BienSo = @bs";

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@bs", OleDbType.VarChar);
                thamSo.Value = bienso;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    //Đọc các thông tin chung vào đối tượng bs
                    BienSoXeDTO bs = new BienSoXeDTO();
                    bs.MaBienSo = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        bs.TenChuXe = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        bs.DiaChi = boDoc.GetString(2);
                    if (!boDoc.IsDBNull(3))
                        bs.NhanHieu = boDoc.GetString(3);
                    if (!boDoc.IsDBNull(4))
                        bs.MauSon = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        bs.SoKhung = boDoc.GetString(5);
                    if (!boDoc.IsDBNull(6))
                        bs.BienSo = boDoc.GetString(6);
                    if (!boDoc.IsDBNull(7))
                        bs.NgayDangKyLanDau = boDoc.GetDateTime(7);
                    if (!boDoc.IsDBNull(8))
                        bs.VoHieuHoa = boDoc.GetBoolean(8);

                    string info = boDoc.GetString(9);
                    XmlDocument reader = new XmlDocument();
                    reader.LoadXml(info);
                    XmlElement e = reader.DocumentElement;
                    if (e.Attributes[0].Value == "Moto")
                    {
                        BienSoXeMotoDTO Moto = new BienSoXeMotoDTO(bs);
                        Moto.LoaiXe = e.Attributes[1].Value;
                        Moto.SoMay = e.Attributes[2].Value;
                        Moto.DungTich = int.Parse(e.Attributes[3].Value);
                        Moto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Moto.SoNguoiDuocPhepCho = int.Parse(e.Attributes[5].Value);

                        return Moto;
                    }
                    else if (e.Attributes[0].Value == "Oto")
                    {
                        BienSoXeOtoDTO Oto = new BienSoXeOtoDTO(bs);
                        Oto.LoaiXe = e.Attributes[1].Value;
                        Oto.SoMay = e.Attributes[2].Value;
                        Oto.DungTich = int.Parse(e.Attributes[3].Value);
                        Oto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Oto.TenDongCo = e.Attributes[5].Value;
                        Oto.NamSanXuat = int.Parse(e.Attributes[6].Value);
                        Oto.TuTrong = e.Attributes[7].Value;
                        Oto.Ktb = new KichThuocBao();
                        Oto.Ktb.Dai = float.Parse(e.ChildNodes[0].Attributes[0].Value);
                        Oto.Ktb.Rong = float.Parse(e.ChildNodes[0].Attributes[1].Value);
                        Oto.Ktb.Cao = float.Parse(e.ChildNodes[0].Attributes[2].Value);
                        Oto.Sc = new SoCho();
                        Oto.Sc.Ngoi = int.Parse(e.ChildNodes[1].Attributes[0].Value);
                        Oto.Sc.Dung = int.Parse(e.ChildNodes[1].Attributes[1].Value);
                        Oto.Sc.Nam = int.Parse(e.ChildNodes[1].Attributes[2].Value);
                        Oto.TaiTrongHangHoa = int.Parse(e.Attributes[8].Value);
                        string[] temp = e.Attributes[9].Value.Split('/');
                        Oto.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        return Oto;
                    }
                    else
                    {
                        BienSoXeRomoocDTO Romooc = new BienSoXeRomoocDTO(bs);
                        Romooc.NamSanXuat = int.Parse(e.Attributes[1].Value);
                        Romooc.Ktb = new KichThuocBao();
                        Romooc.Ktb.Dai = float.Parse(e.FirstChild.Attributes[0].Value);
                        Romooc.Ktb.Rong = float.Parse(e.FirstChild.Attributes[1].Value);
                        Romooc.Ktb.Cao = float.Parse(e.FirstChild.Attributes[2].Value);
                        Romooc.TaiTrong = int.Parse(e.Attributes[2].Value);
                        string[] temp = e.Attributes[3].Value.Split('/');
                        Romooc.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        return Romooc;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                
                    //DataProvider.Disconnect();
            }
            return null;
        }
        public static BienSoXeDTO TraCuuTheoMaBienSo(int mabienso)
        {
            
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM BienSoXe WHERE MaBienSo = @mbs";

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@mbs", OleDbType.Integer);
                thamSo.Value = mabienso;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    //Đọc các thông tin chung vào đối tượng bs
                    BienSoXeDTO bs = new BienSoXeDTO();
                    bs.MaBienSo = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        bs.TenChuXe = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        bs.DiaChi = boDoc.GetString(2);
                    if (!boDoc.IsDBNull(3))
                        bs.NhanHieu = boDoc.GetString(3);
                    if (!boDoc.IsDBNull(4))
                        bs.MauSon = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        bs.SoKhung = boDoc.GetString(5);
                    if (!boDoc.IsDBNull(6))
                        bs.BienSo = boDoc.GetString(6);
                    if (!boDoc.IsDBNull(7))
                        bs.NgayDangKyLanDau = boDoc.GetDateTime(7);
                    if (!boDoc.IsDBNull(8))
                        bs.VoHieuHoa = boDoc.GetBoolean(8);

                    string info = boDoc.GetString(9);
                    XmlDocument reader = new XmlDocument();
                    reader.LoadXml(info);
                    XmlElement e = reader.DocumentElement;
                    if (e.Attributes[0].Value == "Moto")
                    {
                        BienSoXeMotoDTO Moto = new BienSoXeMotoDTO(bs);
                        Moto.LoaiXe = e.Attributes[1].Value;
                        Moto.SoMay = e.Attributes[2].Value;
                        Moto.DungTich = int.Parse(e.Attributes[3].Value);
                        Moto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Moto.SoNguoiDuocPhepCho = int.Parse(e.Attributes[5].Value);

                        return Moto;
                    }
                    else if (e.Attributes[0].Value == "Oto")
                    {
                        BienSoXeOtoDTO Oto = new BienSoXeOtoDTO(bs);
                        Oto.LoaiXe = e.Attributes[1].Value;
                        Oto.SoMay = e.Attributes[2].Value;
                        Oto.DungTich = int.Parse(e.Attributes[3].Value);
                        Oto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Oto.TenDongCo = e.Attributes[5].Value;
                        Oto.NamSanXuat = int.Parse(e.Attributes[6].Value);
                        Oto.TuTrong = e.Attributes[7].Value;
                        Oto.Ktb = new KichThuocBao();
                        Oto.Ktb.Dai = float.Parse(e.ChildNodes[0].Attributes[0].Value);
                        Oto.Ktb.Rong = float.Parse(e.ChildNodes[0].Attributes[1].Value);
                        Oto.Ktb.Cao = float.Parse(e.ChildNodes[0].Attributes[2].Value);
                        Oto.Sc = new SoCho();
                        Oto.Sc.Ngoi = int.Parse(e.ChildNodes[1].Attributes[0].Value);
                        Oto.Sc.Dung = int.Parse(e.ChildNodes[1].Attributes[1].Value);
                        Oto.Sc.Nam = int.Parse(e.ChildNodes[1].Attributes[2].Value);
                        Oto.TaiTrongHangHoa = int.Parse(e.Attributes[8].Value);
                        string[] temp = e.Attributes[9].Value.Split('/');
                        Oto.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        return Oto;
                    }
                    else
                    {
                        BienSoXeRomoocDTO Romooc = new BienSoXeRomoocDTO(bs);
                        Romooc.NamSanXuat = int.Parse(e.Attributes[1].Value);
                        Romooc.Ktb = new KichThuocBao();
                        Romooc.Ktb.Dai = float.Parse(e.FirstChild.Attributes[0].Value);
                        Romooc.Ktb.Rong = float.Parse(e.FirstChild.Attributes[1].Value);
                        Romooc.Ktb.Cao = float.Parse(e.FirstChild.Attributes[2].Value);
                        Romooc.TaiTrong = int.Parse(e.Attributes[2].Value);
                        string[] temp = e.Attributes[3].Value.Split('/');
                        Romooc.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        return Romooc;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                
                    //DataProvider.Disconnect();
            }
            return null;
        }
        public static BienSoXeMotoDTO LaMoto(object bs)
        {
            if (bs is BienSoXeMotoDTO)
            {
                BienSoXeMotoDTO temp = new BienSoXeMotoDTO();
                temp = (BienSoXeMotoDTO)bs;
                return temp;
            }
            else
                return null;
        }
        public static BienSoXeOtoDTO LaOto(object bs)
        {
            if (bs is BienSoXeOtoDTO)
            {
                BienSoXeOtoDTO temp = new BienSoXeOtoDTO();
                temp = (BienSoXeOtoDTO)bs;
                return temp;
            }
            else
                return null;
        }
        public static BienSoXeRomoocDTO LaRomooc(object bs)
        {
            if (bs is BienSoXeRomoocDTO)
            {
                BienSoXeRomoocDTO temp = new BienSoXeRomoocDTO();
                temp = (BienSoXeRomoocDTO)bs;
                return temp;
            }
            else
                return null;
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
    }
}
