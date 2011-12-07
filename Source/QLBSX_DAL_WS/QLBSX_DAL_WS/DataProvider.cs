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
    public class DataProvider
    {
        private static string chuoiKetNoi = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source=|DataDirectory|\QLBSX_DB.mdb";
        private static OleDbConnection _connection;

        public static OleDbConnection Connection
        {
            get { return DataProvider._connection; }
            //set { DataProvider._connection = value; }
        }
        public static void Connect()
        {
            if (_connection != null) //Đã tạo
                if (_connection.State == System.Data.ConnectionState.Open)    //Đang mở kết nối thì không mở nữa
                    return;

            _connection = new OleDbConnection(chuoiKetNoi);
            _connection.Open();
            
        }
        public static void Disconnect()
        {
            if (_connection != null)
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }        
    }
}
