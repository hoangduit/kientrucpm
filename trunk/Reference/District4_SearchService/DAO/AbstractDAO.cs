using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.OleDb;

namespace DAO
{
    public class AbstractDAO
    {
        private static string chuoiKetNoi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TimKiemDichVu_DB.accdb";

        protected static OleDbConnection MoKetNoi()
        {
            OleDbConnection ketNoi = new OleDbConnection(chuoiKetNoi);
            ketNoi.Open();
            return ketNoi;
        }
    }
}
