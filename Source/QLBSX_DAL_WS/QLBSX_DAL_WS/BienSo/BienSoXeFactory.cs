using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Data.OleDb;

namespace QLBSX_DAL_WS
{
    public class BienSoXeFactory
    {
        //private List<BienSoXe> _plates = new List<BienSoXe>();

        public static List<BienSoXe> GetAllPlates()
        {
            DataProvider.Connect();
            List<BienSoXe> ds = new List<BienSoXe>();
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM BienSoXe";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    string info = boDoc.GetString(9);
                    XmlDocument reader = new XmlDocument();
                    reader.LoadXml(info);
                    XmlElement e = reader.DocumentElement;
                    //Đọc các thông tin riêng nếu là môtô
                    if (e.Attributes[0].Value == "Moto")
                    {
                        BienSoXeMoto Moto = BienSoXeMoto.FromDataReader(boDoc);
                        Moto.LoaiXe = e.Attributes[1].Value;
                        Moto.SoMay = e.Attributes[2].Value;
                        Moto.DungTich = int.Parse(e.Attributes[3].Value);
                        Moto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Moto.SoNguoiDuocPhepCho = int.Parse(e.Attributes[5].Value);

                        ds.Add(Moto);
                    }
                    //Đọc các thông tin riêng nếu là Ôtô
                    else if (e.Attributes[0].Value == "Oto")
                    {
                        BienSoXeOto Oto = BienSoXeOto.FromDataReader(boDoc);
                        Oto.LoaiXe = e.Attributes[1].Value;
                        Oto.SoMay = e.Attributes[2].Value;
                        Oto.DungTich = int.Parse(e.Attributes[3].Value);
                        Oto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Oto.TenDongCo = e.Attributes[5].Value;
                        Oto.NamSanXuat = int.Parse(e.Attributes[6].Value);
                        Oto.TuTrong = e.Attributes[7].Value;
                        Oto.Ktb = new KichThuocBao();
                        Oto.Ktb.Dai = float.Parse(e.ChildNodes[0].Attributes[0].Value);
                        Oto.Ktb.Rong = float.Parse(e.ChildNodes[0].Attributes[1].Value);
                        Oto.Ktb.Cao = float.Parse(e.ChildNodes[0].Attributes[2].Value);
                        Oto.Sc = new SoCho();
                        Oto.Sc.Ngoi = int.Parse(e.ChildNodes[1].Attributes[0].Value);
                        Oto.Sc.Dung = int.Parse(e.ChildNodes[1].Attributes[1].Value);
                        Oto.Sc.Nam = int.Parse(e.ChildNodes[1].Attributes[2].Value);
                        Oto.TaiTrongHangHoa = int.Parse(e.Attributes[8].Value);
                        string[] temp = e.Attributes[9].Value.Split('/');
                        Oto.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        ds.Add(Oto);
                    }
                    //Đọc các thông tin riêng nếu là Rơmoóc
                    else
                    {
                        BienSoXeRomooc Romooc = BienSoXeRomooc.FromDataReader(boDoc);
                        Romooc.NamSanXuat = int.Parse(e.Attributes[1].Value);
                        Romooc.Ktb = new KichThuocBao();
                        Romooc.Ktb.Dai = float.Parse(e.FirstChild.Attributes[0].Value);
                        Romooc.Ktb.Rong = float.Parse(e.FirstChild.Attributes[1].Value);
                        Romooc.Ktb.Cao = float.Parse(e.FirstChild.Attributes[2].Value);
                        Romooc.TaiTrong = int.Parse(e.Attributes[2].Value);
                        string[] temp = e.Attributes[3].Value.Split('/');
                        Romooc.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        ds.Add(Romooc);
                    }
                }
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                ds = new List<BienSoXe>();
            }

            return ds;
        }
        public static List<BienSoXe> GetAllGeneralPlates()
        {
            List<BienSoXe> ds = new List<BienSoXe>();
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM BienSoXe";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    //Đọc các thông tin chung vào đối tượng bs
                    BienSoXe bs = new BienSoXeMoto();
                    bs.MaBienSo = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        bs.TenChuXe = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        bs.DiaChi = boDoc.GetString(2);
                    if (!boDoc.IsDBNull(3))
                        bs.NhanHieu = boDoc.GetString(3);
                    if (!boDoc.IsDBNull(4))
                        bs.MauSon = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        bs.SoKhung = boDoc.GetString(5);
                    if (!boDoc.IsDBNull(6))
                        bs.BienSo = boDoc.GetString(6);
                    if (!boDoc.IsDBNull(7))
                        bs.NgayDangKyLanDau = boDoc.GetDateTime(7);
                    if (!boDoc.IsDBNull(8))
                        bs.VoHieuHoa = boDoc.GetBoolean(8);

                    ds.Add(bs);
                }
            }
            catch (Exception)
            {
                ds = new List<BienSoXe>();
            }

            return ds;
        }
        public static bool AddPlate(object plate)
        {
            bool result = true;
            if (plate is BienSoXeMoto)
            {
                result = ((BienSoXeMoto)plate).Add();
            }
            else if (plate is BienSoXeOto)
            {
                result = ((BienSoXeOto)plate).Add();
            }
            else if (plate is BienSoXeRomooc)
            {
                result = ((BienSoXeRomooc)plate).Add();
            }

            return result;
        }
        public static bool UpdatePlate(object plate)
        {
            bool result = true;
            if (plate is BienSoXeMoto)
            {
                result = ((BienSoXeMoto)plate).Update();
            }
            else if (plate is BienSoXeOto)
            {
                result = ((BienSoXeOto)plate).Update();
            }
            else if (plate is BienSoXeRomooc)
            {
                result = ((BienSoXeRomooc)plate).Update();
            }

            return result;
        }
        public static bool RemovePlate(object plate)
        {
            bool result = true;
            if (plate is BienSoXeMoto)
            {
                result = ((BienSoXeMoto)plate).Remove();
            }
            else if (plate is BienSoXeOto)
            {
                result = ((BienSoXeOto)plate).Remove();
            }
            else if (plate is BienSoXeRomooc)
            {
                result = ((BienSoXeRomooc)plate).Remove();
            }

            return result;
        }
        public static BienSoXe TraCuuTheoBienSo(string bienso)
        {
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM BienSoXe WHERE BienSo = @bs";

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@bs", OleDbType.VarChar);
                thamSo.Value = bienso;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    string info = boDoc.GetString(9);
                    XmlDocument reader = new XmlDocument();
                    reader.LoadXml(info);
                    XmlElement e = reader.DocumentElement;
                    if (e.Attributes[0].Value == "Moto")
                    {
                        BienSoXeMoto Moto = BienSoXeMoto.FromDataReader(boDoc);

                        Moto.LoaiXe = e.Attributes[1].Value;
                        Moto.SoMay = e.Attributes[2].Value;
                        Moto.DungTich = int.Parse(e.Attributes[3].Value);
                        Moto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Moto.SoNguoiDuocPhepCho = int.Parse(e.Attributes[5].Value);

                        return Moto;
                    }
                    else if (e.Attributes[0].Value == "Oto")
                    {
                        BienSoXeOto Oto = BienSoXeOto.FromDataReader(boDoc);
                        Oto.LoaiXe = e.Attributes[1].Value;
                        Oto.SoMay = e.Attributes[2].Value;
                        Oto.DungTich = int.Parse(e.Attributes[3].Value);
                        Oto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Oto.TenDongCo = e.Attributes[5].Value;
                        Oto.NamSanXuat = int.Parse(e.Attributes[6].Value);
                        Oto.TuTrong = e.Attributes[7].Value;
                        Oto.Ktb = new KichThuocBao();
                        Oto.Ktb.Dai = float.Parse(e.ChildNodes[0].Attributes[0].Value);
                        Oto.Ktb.Rong = float.Parse(e.ChildNodes[0].Attributes[1].Value);
                        Oto.Ktb.Cao = float.Parse(e.ChildNodes[0].Attributes[2].Value);
                        Oto.Sc = new SoCho();
                        Oto.Sc.Ngoi = int.Parse(e.ChildNodes[1].Attributes[0].Value);
                        Oto.Sc.Dung = int.Parse(e.ChildNodes[1].Attributes[1].Value);
                        Oto.Sc.Nam = int.Parse(e.ChildNodes[1].Attributes[2].Value);
                        Oto.TaiTrongHangHoa = int.Parse(e.Attributes[8].Value);
                        string[] temp = e.Attributes[9].Value.Split('/');
                        Oto.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        return Oto;
                    }
                    else
                    {
                        BienSoXeRomooc Romooc = BienSoXeRomooc.FromDataReader(boDoc);
                        Romooc.NamSanXuat = int.Parse(e.Attributes[1].Value);
                        Romooc.Ktb = new KichThuocBao();
                        Romooc.Ktb.Dai = float.Parse(e.FirstChild.Attributes[0].Value);
                        Romooc.Ktb.Rong = float.Parse(e.FirstChild.Attributes[1].Value);
                        Romooc.Ktb.Cao = float.Parse(e.FirstChild.Attributes[2].Value);
                        Romooc.TaiTrong = int.Parse(e.Attributes[2].Value);
                        string[] temp = e.Attributes[3].Value.Split('/');
                        Romooc.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        return Romooc;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            return null;
        }
        public static BienSoXe TraCuuTheoMaBienSo(int mabienso)
        {
            try
            {
                DataProvider.Connect();
                string chuoiLenh = "SELECT * FROM BienSoXe WHERE MaBienSo = @mbs";

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, DataProvider.Connection);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@mbs", OleDbType.Integer);
                thamSo.Value = mabienso;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {                   
                    string info = boDoc.GetString(9);
                    XmlDocument reader = new XmlDocument();
                    reader.LoadXml(info);
                    XmlElement e = reader.DocumentElement;
                    if (e.Attributes[0].Value == "Moto")
                    {
                        BienSoXeMoto Moto = BienSoXeMoto.FromDataReader(boDoc);
                        Moto.LoaiXe = e.Attributes[1].Value;
                        Moto.SoMay = e.Attributes[2].Value;
                        Moto.DungTich = int.Parse(e.Attributes[3].Value);
                        Moto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Moto.SoNguoiDuocPhepCho = int.Parse(e.Attributes[5].Value);

                        return Moto;
                    }
                    else if (e.Attributes[0].Value == "Oto")
                    {
                        BienSoXeOto Oto = BienSoXeOto.FromDataReader(boDoc);
                        Oto.LoaiXe = e.Attributes[1].Value;
                        Oto.SoMay = e.Attributes[2].Value;
                        Oto.DungTich = int.Parse(e.Attributes[3].Value);
                        Oto.CongSuat = int.Parse(e.Attributes[4].Value);
                        Oto.TenDongCo = e.Attributes[5].Value;
                        Oto.NamSanXuat = int.Parse(e.Attributes[6].Value);
                        Oto.TuTrong = e.Attributes[7].Value;
                        Oto.Ktb = new KichThuocBao();
                        Oto.Ktb.Dai = float.Parse(e.ChildNodes[0].Attributes[0].Value);
                        Oto.Ktb.Rong = float.Parse(e.ChildNodes[0].Attributes[1].Value);
                        Oto.Ktb.Cao = float.Parse(e.ChildNodes[0].Attributes[2].Value);
                        Oto.Sc = new SoCho();
                        Oto.Sc.Ngoi = int.Parse(e.ChildNodes[1].Attributes[0].Value);
                        Oto.Sc.Dung = int.Parse(e.ChildNodes[1].Attributes[1].Value);
                        Oto.Sc.Nam = int.Parse(e.ChildNodes[1].Attributes[2].Value);
                        Oto.TaiTrongHangHoa = int.Parse(e.Attributes[8].Value);
                        string[] temp = e.Attributes[9].Value.Split('/');
                        Oto.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        return Oto;
                    }
                    else
                    {
                        BienSoXeRomooc Romooc = BienSoXeRomooc.FromDataReader(boDoc);
                        Romooc.NamSanXuat = int.Parse(e.Attributes[1].Value);
                        Romooc.Ktb = new KichThuocBao();
                        Romooc.Ktb.Dai = float.Parse(e.FirstChild.Attributes[0].Value);
                        Romooc.Ktb.Rong = float.Parse(e.FirstChild.Attributes[1].Value);
                        Romooc.Ktb.Cao = float.Parse(e.FirstChild.Attributes[2].Value);
                        Romooc.TaiTrong = int.Parse(e.Attributes[2].Value);
                        string[] temp = e.Attributes[3].Value.Split('/');
                        Romooc.NgayHetHan = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));

                        return Romooc;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }
    }
}