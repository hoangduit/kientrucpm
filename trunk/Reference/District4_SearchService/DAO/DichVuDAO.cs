using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;

namespace DAO
{
    public class DichVuDAO : AbstractDAO
    {
        //Begin edit by Dũng----------
        public static List<DichVuDTO> layDSDichVu()
        {
            OleDbConnection ketNoi = null;
            List<DichVuDTO> dsDichVu;

            try
            {
                dsDichVu = new List<DichVuDTO>();

                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaDichVu,TenDichVu FROM DICHVU";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    DichVuDTO dichVu = new DichVuDTO();

                    dichVu.MaDichVu = boDoc.GetInt32(0);
                    dichVu.TenDichVu = boDoc.GetString(1);

                    dsDichVu.Add(dichVu);
                }
            }
            catch
            {
                dsDichVu = new List<DichVuDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }

            return dsDichVu;
        }
        //End edit by Dũng------------
    }
}
