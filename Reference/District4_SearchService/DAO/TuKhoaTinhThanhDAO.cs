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
    public class TuKhoaTinhThanhDAO: AbstractDAO
    {

        /// <summary>
        /// Tim tinh thanh dua vao cum tu
        /// </summary>
        /// <param name="dsCumTu"></param>
        /// <returns> ma Tu khoa tinh thanh</returns>
        public static int TimTinhThanh(List<string> dsCumTu)
        {
            OleDbConnection ketNoi = null;
            int maTinhThanh = -1;

            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaTuKhoaTinhThanh FROM TUKHOATINHTHANH WHERE TuKhoaTinhThanh Like @CumTu";

                foreach (string cumTu in dsCumTu)
                {
                    OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                    OleDbParameter thamSo = new OleDbParameter("@CumTu", OleDbType.VarChar);
                    thamSo.Value = cumTu;
                    lenh.Parameters.Add(thamSo);

                    OleDbDataReader boDoc = lenh.ExecuteReader();
                    if (boDoc.Read())
                    {
                        maTinhThanh = boDoc.GetInt32(0);
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                maTinhThanh = -1;
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }

            return maTinhThanh;
        }
        
        
    }

    /// <summary>
    /// Thanh Phuc
    /// </summary>
}
