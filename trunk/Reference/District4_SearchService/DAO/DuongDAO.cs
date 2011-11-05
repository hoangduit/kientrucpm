using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class DuongDAO:AbstractDAO
    {
        //Begin edit by Dũng----------
        public static DuongDTO layDuong(int maDuong)
        {
            OleDbConnection ketNoi = null;
            DuongDTO duong;

            try
            {
                duong = new DuongDTO();
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaDuong,TenDuong FROM DUONG WHERE MaDuong=@MaDuong";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbParameter thamSo = new OleDbParameter("@MaDuong", OleDbType.Integer);
                thamSo.Value = maDuong;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                if (boDoc.Read())
                {
                    duong.MaDuong = boDoc.GetInt32(0);
                    duong.TenDuong = boDoc.GetString(1);
                }
            }
            catch
            {
                duong = new DuongDTO();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }

            return duong;
        }
        //End edit by Dũng----------
    }
}
