﻿using System;
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
        private static OleDbConnection ketNoi;
        public static OleDbConnection KetNoi()
        {
            if (ketNoi != null) //Đã tạo
                if(ketNoi.State == System.Data.ConnectionState.Open)    //Đang mở kết nối thì không mở nữa
                    return null;

            ketNoi = new OleDbConnection(chuoiKetNoi);
            ketNoi.Open();
            return ketNoi;
        }
    }
}
