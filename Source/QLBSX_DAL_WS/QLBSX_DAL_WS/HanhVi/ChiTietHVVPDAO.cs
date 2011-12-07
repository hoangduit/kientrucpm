using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class ChiTietHVVPDAO
    {
        public static List<ChiTietHVVPDTO> LayDanhSachChiTietHanhVi()
        {
            List<ChiTietHVVPDTO> ds = new List<ChiTietHVVPDTO>();
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM ChiTietHVVP";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    ChiTietHVVPDTO ct = new ChiTietHVVPDTO();
                    ct.MaChiTiet = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                    {
                        int mahv = boDoc.GetInt32(1);
                        ct.HanhVi = HanhViViPhamDAO.TraCuuTheoMaHanhVi(mahv);
                    }
                    if (!boDoc.IsDBNull(2))
                    {
                        int mabs = boDoc.GetInt32(2);
                        ct.BienSo = BienSoXeFactory.TraCuuTheoMaBienSo(mabs);
                    }
                    if (!boDoc.IsDBNull(3))
                        ct.ThoiGian = boDoc.GetDateTime(3);
                    if (!boDoc.IsDBNull(4))
                        ct.NguoiLapBienBan = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        ct.TienPhat = boDoc.GetDouble(5);

                    ds.Add(ct);
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                ds = new List<ChiTietHVVPDTO>();
            }
            finally
            {
                //DataProvider.Disconnect();
            }
            return ds;
        }
        public static bool ThemChiTietHanhVi(ChiTietHVVPDTO ct)
        {
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "INSERT INTO ChiTietHVVP(MaHanhVi,MaBienSo,ThoiGian,NguoiLapBienBan,TienPhat) VALUES";
                chuoiLenh += "(@mahv,@mabs,@thoigian,@nlbb,@tp)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@mahv", OleDbType.Integer);
                thamSo.Value = ct.HanhVi.MaHanhVi;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@mabs", OleDbType.Integer);
                BienSoXe temp = (BienSoXe)ct.BienSo;
                thamSo.Value = temp.MaBienSo;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@thoigian", OleDbType.Date);
                thamSo.Value = ct.ThoiGian;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@nlbb", OleDbType.VarChar);
                thamSo.Value = ct.NguoiLapBienBan;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@tp", OleDbType.Integer);
                thamSo.Value = ct.TienPhat;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //DataProvider.Disconnect();
            }
            return true;
        }
        public static bool CapNhatChiTietHanhVi(ChiTietHVVPDTO ct)
        {
            try
            {
                DataProvider.Connect();
                BienSoXe temp = (BienSoXe)ct.BienSo;
                string chuoiLenh = "UPDATE ChiTietHVVP SET "
                    + "MaHanhVi = " + ct.HanhVi.MaHanhVi + ", "
                    + "MaBienSo = " + temp.MaBienSo + ", "
                    + "ThoiGian = '" + ct.ThoiGian + "', "
                    + "NguoiLapBienBan = '" + ct.NguoiLapBienBan + "', "
                    + "TienPhat = " + ct.TienPhat + " "
                    + "WHERE MaChiTietHVVP = " + ct.MaChiTiet;

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
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
        public static List<ChiTietHVVPDTO> TraCuuTheoBienSo(string bienso)
        {

            List<ChiTietHVVPDTO> ds = new List<ChiTietHVVPDTO>();

            BienSoXe bs = (BienSoXe)BienSoXeFactory.TraCuuTheoBienSo(bienso);
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM ChiTietHVVP WHERE MaBienSo = @mabs";

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@mabs", OleDbType.Integer);
                thamSo.Value = bs.MaBienSo;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    ChiTietHVVPDTO ct = new ChiTietHVVPDTO();
                    ct.MaChiTiet = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                    {
                        int mahv = boDoc.GetInt32(1);
                        ct.HanhVi = HanhViViPhamDAO.TraCuuTheoMaHanhVi(mahv);
                    }
                    if (!boDoc.IsDBNull(2))
                    {
                        int mabs = boDoc.GetInt32(2);
                        ct.BienSo = BienSoXeFactory.TraCuuTheoMaBienSo(mabs);
                    }
                    if (!boDoc.IsDBNull(3))
                        ct.ThoiGian = boDoc.GetDateTime(3);
                    if (!boDoc.IsDBNull(4))
                        ct.NguoiLapBienBan = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        ct.TienPhat = boDoc.GetDouble(5);

                    ds.Add(ct);
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                ds = new List<ChiTietHVVPDTO>();
            }
            finally
            {

                //DataProvider.Disconnect();
            }
            return ds;
        }
        public static List<ChiTietHVVPDTO> TraCuuTheoMaBienSo(int _mabs)
        {

            List<ChiTietHVVPDTO> ds = new List<ChiTietHVVPDTO>();

            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM ChiTietHVVP WHERE MaBienSo = @mabs";

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@mabs", OleDbType.Integer);
                thamSo.Value = _mabs;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    ChiTietHVVPDTO ct = new ChiTietHVVPDTO();
                    ct.MaChiTiet = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                    {
                        int mahv = boDoc.GetInt32(1);
                        ct.HanhVi = HanhViViPhamDAO.TraCuuTheoMaHanhVi(mahv);
                    }
                    if (!boDoc.IsDBNull(2))
                    {
                        int mabs = boDoc.GetInt32(2);
                        ct.BienSo = BienSoXeFactory.TraCuuTheoMaBienSo(mabs);
                    }
                    if (!boDoc.IsDBNull(3))
                        ct.ThoiGian = boDoc.GetDateTime(3);
                    if (!boDoc.IsDBNull(4))
                        ct.NguoiLapBienBan = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        ct.TienPhat = boDoc.GetDouble(5);

                    ds.Add(ct);
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                ds = new List<ChiTietHVVPDTO>();
            }
            finally
            {

                //DataProvider.Disconnect();
            }
            return ds;
        }
        public static List<ChiTietHVVPDTO> TraCuuTheoTenHanhVi(string tenhv)
        {

            List<ChiTietHVVPDTO> ds = new List<ChiTietHVVPDTO>();

            HanhViViPhamDTO hv = HanhViViPhamDAO.TraCuuTheoTenHanhVi(tenhv);
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM ChiTietHVVP WHERE MaHanhVi = @mahv";

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@mahv", OleDbType.Integer);
                thamSo.Value = hv.MaHanhVi;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    ChiTietHVVPDTO ct = new ChiTietHVVPDTO();
                    ct.MaChiTiet = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                    {
                        int mahv = boDoc.GetInt32(1);
                        ct.HanhVi = HanhViViPhamDAO.TraCuuTheoMaHanhVi(mahv);
                    }
                    if (!boDoc.IsDBNull(2))
                    {
                        int mabs = boDoc.GetInt32(2);
                        ct.BienSo = BienSoXeFactory.TraCuuTheoMaBienSo(mabs);
                    }
                    if (!boDoc.IsDBNull(3))
                        ct.ThoiGian = boDoc.GetDateTime(3);
                    if (!boDoc.IsDBNull(4))
                        ct.NguoiLapBienBan = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        ct.TienPhat = boDoc.GetDouble(5);

                    ds.Add(ct);
                }
            }
            catch (Exception)
            {
                ds = new List<ChiTietHVVPDTO>();
            }
            finally
            {
                //DataProvider.Disconnect();
            }
            return ds;
        }
        public static List<ChiTietHVVPDTO> TraCuuTheoMaHanhVi(int _mahv)
        {

            List<ChiTietHVVPDTO> ds = new List<ChiTietHVVPDTO>();

            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM ChiTietHVVP WHERE MaHanhVi = @mahv";

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@mahv", OleDbType.Integer);
                thamSo.Value = _mahv;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    ChiTietHVVPDTO ct = new ChiTietHVVPDTO();
                    ct.MaChiTiet = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                    {
                        int mahv = boDoc.GetInt32(1);
                        ct.HanhVi = HanhViViPhamDAO.TraCuuTheoMaHanhVi(mahv);
                    }
                    if (!boDoc.IsDBNull(2))
                    {
                        int mabs = boDoc.GetInt32(2);
                        ct.BienSo = BienSoXeFactory.TraCuuTheoMaBienSo(mabs);
                    }
                    if (!boDoc.IsDBNull(3))
                        ct.ThoiGian = boDoc.GetDateTime(3);
                    if (!boDoc.IsDBNull(4))
                        ct.NguoiLapBienBan = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        ct.TienPhat = boDoc.GetDouble(5);

                    ds.Add(ct);
                }
            }
            catch (Exception)
            {
                ds = new List<ChiTietHVVPDTO>();
            }
            finally
            {

                //DataProvider.Disconnect();
            }
            return ds;
        }
    }
}
