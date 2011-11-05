using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;

namespace DAO
{
    /// <summary>
    /// Thanh Phuc
    /// </summary>
    public class TuKhoaPhuongDAO : AbstractDAO
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dsCumTu"></param>
        /// <returns> </returns>
        public static int TimPhuong(List<string> dsCumTu)
        {
            OleDbConnection ketNoi = null;
            int maPhuong = -1;

            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaTuKhoaPhuong FROM TUKHOAPHUONG WHERE TuKhoaPhuong Like @CumTu";

                foreach (string cumTu in dsCumTu)
                {
                    OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                    OleDbParameter thamSo = new OleDbParameter("@CumTu", OleDbType.VarChar);
                    thamSo.Value = cumTu;
                    lenh.Parameters.Add(thamSo);

                    OleDbDataReader boDoc = lenh.ExecuteReader();
                    if (boDoc.Read())
                    {
                        maPhuong = boDoc.GetInt32(0);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                maPhuong = -1;
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }

            return maPhuong;
        }


    }

    /// <summary>
    /// Thanh Phuc
    /// </summary>
}
