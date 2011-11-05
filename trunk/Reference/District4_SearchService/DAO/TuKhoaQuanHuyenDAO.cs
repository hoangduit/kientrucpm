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
    public class TuKhoaQuanHuyenDAO : AbstractDAO
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dsCumTu"></param>
        /// <returns> ma Tu khoa tinh thanh</returns>
        public static int TimQuanHuyen(List<string> dsCumTu)
        {
            OleDbConnection ketNoi = null;
            int maQuanHuyen = -1;

            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaTuKhoaQuanHuyen FROM TUKHOAQUANHUYEN WHERE TuKhoaQuanHuyen Like @CumTu";

                foreach (string cumTu in dsCumTu)
                {
                    OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                    OleDbParameter thamSo = new OleDbParameter("@CumTu", OleDbType.VarChar);
                    thamSo.Value = cumTu;
                    lenh.Parameters.Add(thamSo);

                    OleDbDataReader boDoc = lenh.ExecuteReader();
                    if (boDoc.Read())
                    {
                        maQuanHuyen = boDoc.GetInt32(0);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                maQuanHuyen = -1;
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }

            return maQuanHuyen;
        }


    }

    /// <summary>
    /// Thanh Phuc
    /// </summary>
}
