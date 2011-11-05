using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class TuKhoaDuongDAO : AbstractDAO
    {
        //Tim duong
        //return maDuong
        public static int TimDuong(List<string> dsCumTu)
        {
            OleDbConnection ketNoi = null;
            int maDuong = 0;

            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaDuong FROM TUKHOADUONG WHERE TuKhoaDuong Like @CumTu";

                foreach (string cumTu in dsCumTu)
                {
                    OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                    OleDbParameter thamSo = new OleDbParameter("@CumTu", OleDbType.VarChar);
                    thamSo.Value = cumTu;
                    lenh.Parameters.Add(thamSo);

                    OleDbDataReader boDoc = lenh.ExecuteReader();
                    if (boDoc.Read())
                    {
                        maDuong = boDoc.GetInt32(0);
                        break;
                    }
                }
            }
            catch
            {
                maDuong = 0;
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }

            return maDuong;
        }
    }
}
