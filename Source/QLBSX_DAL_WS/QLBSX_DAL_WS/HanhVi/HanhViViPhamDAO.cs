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
    public class HanhViViPhamDAO
    {
        public static List<HanhViViPhamDTO> LayDanhSachHanhVi()
        {
            List<HanhViViPhamDTO> ds = new List<HanhViViPhamDTO>();
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM HanhViViPham";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    HanhViViPhamDTO hv = new HanhViViPhamDTO();
                    hv.MaHanhVi = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        hv.TenHanhVi = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        hv.VoHieuHoa = boDoc.GetBoolean(2);

                    ds.Add(hv);
                }
            }
            catch (Exception)
            {
                ds = new List<HanhViViPhamDTO>();
            }
            finally
            {
                //DataProvider.Disconnect();
            }
            return ds;
        }
        public static bool ThemHanhVi(HanhViViPhamDTO hv)
        {
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "INSERT INTO HanhViViPham(TenHanhVi) VALUES";
                chuoiLenh += "(@ten)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@ten", OleDbType.VarChar);
                thamSo.Value = hv.TenHanhVi;
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
        public static bool VoHieuHoaHanhVi(HanhViViPhamDTO hv)
        {
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "UPDATE HanhViViPham SET "
                    + "VoHieuHoa = @vhh "
                    + "WHERE MaHanhVi = " + hv.MaHanhVi;

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
        public static bool CapNhatHanhVi(HanhViViPhamDTO hv)
        {
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "UPDATE HanhViViPham SET "
                    + "TenHanhVi = '" + hv.TenHanhVi + "' "
                    + "WHERE MaHanhVi = " + hv.MaHanhVi;

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                lenh.ExecuteNonQuery();
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
        public static HanhViViPhamDTO TraCuuTheoTenHanhVi(string ten)
        {
            
            HanhViViPhamDTO hv = new HanhViViPhamDTO();
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM HanhViViPham WHERE TenHanhVi = @ten";

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@ten", OleDbType.VarChar);
                thamSo.Value = ten;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    hv.MaHanhVi = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        hv.TenHanhVi = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        hv.VoHieuHoa = boDoc.GetBoolean(2);
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
            return hv;
        }
        public static HanhViViPhamDTO TraCuuTheoMaHanhVi(int ma)
        {            
            HanhViViPhamDTO hv = new HanhViViPhamDTO();
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM HanhViViPham WHERE MaHanhVi = @ma";

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@ma", OleDbType.Integer);
                thamSo.Value = ma;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    hv.MaHanhVi = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        hv.TenHanhVi = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        hv.VoHieuHoa = boDoc.GetBoolean(2);
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
            return hv;
        }
    }
}
