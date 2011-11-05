using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.OleDb;

namespace DAO
{
    public class DiaDiemDAO : AbstractDAO
    {
        //Begin edit by Dũng----------
        public static List<DiaDiemDTO> TimKiemDiaDiem(int maDichVu, int maTenDiaDiem, string soNha, int maDuong, int maPhuong, int maQuanHuyen, int maTinhThanh)
        {
            OleDbConnection ketNoi = null;
            List<DiaDiemDTO> dsDiaDiem = new List<DiaDiemDTO>();

            try
            {
                dsDiaDiem = new List<DiaDiemDTO>();

                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT DL.MaDuLieu,DV.TenDichVu,TDD.TenDiaDiem,DL.SoNha,D.TenDuong,P.TenPhuong,QH.TenQuanHuyen,TT.TenTinhThanh,DL.KinhDo,DL.ViDo,DL.ChuThich " +
                                   "FROM DULIEU DL, TENDIADIEM TDD, DUONG D, PHUONG P, TINHTHANH TT, QUANHUYEN QH, DICHVU DV " +
                                   "WHERE DL.MaDichVu=DV.MaDichVu And DL.MaTenDiaDiem=TDD.MaTenDiaDiem And DL.MaDuong=D.MaDuong And DL.MaPhuong=P.MaPhuong And DL.MaQuanHuyen=QH.MaQuanHuyen And DL.MaTinhThanh=TT.MaTinhThanh";

                if (maDichVu != 0)
                    chuoiLenh += " And DL.MaDichVu=@MaDichVu";

                if (maTenDiaDiem != 0)
                    chuoiLenh += " And DL.MaTenDiaDiem=@MaTenDiaDiem";

                if (soNha != "")
                    chuoiLenh += " And DL.SoNha Like @SoNha";

                if (maDuong != 0)
                    chuoiLenh += " And DL.MaDuong=@MaDuong";

                if (maPhuong != 0)
                    chuoiLenh += " And DL.MaPhuong=@MaPhuong";

                if (maQuanHuyen != 0)
                    chuoiLenh += " And DL.MaQuanHuyen=@MaQuanHuyen";

                if (maTinhThanh != 0)
                    chuoiLenh += " And DL.MaTinhThanh=@MaTinhThanh";

                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;

                if (maDichVu != 0)
                {
                    thamSo = new OleDbParameter("@MaDichVu", OleDbType.Integer);
                    thamSo.Value = maDichVu;
                    lenh.Parameters.Add(thamSo);
                }

                if (maTenDiaDiem != 0)
                {
                    thamSo = new OleDbParameter("@MaTenDiaDiem", OleDbType.Integer);
                    thamSo.Value = maTenDiaDiem;
                    lenh.Parameters.Add(thamSo);
                }

                if (soNha != "")
                {
                    thamSo = new OleDbParameter("@SoNha", OleDbType.VarChar);
                    thamSo.Value = soNha;
                    lenh.Parameters.Add(thamSo);
                }

                if (maDuong != 0)
                {
                    thamSo = new OleDbParameter("@MaDuong", OleDbType.Integer);
                    thamSo.Value = maDuong;
                    lenh.Parameters.Add(thamSo);
                }

                if (maPhuong != 0)
                {
                    thamSo = new OleDbParameter("@MaPhuong", OleDbType.Integer);
                    thamSo.Value = maPhuong;
                    lenh.Parameters.Add(thamSo);
                }

                if (maQuanHuyen != 0)
                {
                    thamSo = new OleDbParameter("@MaQuanHuyen", OleDbType.Integer);
                    thamSo.Value = maQuanHuyen;
                    lenh.Parameters.Add(thamSo);
                }

                if (maTinhThanh != 0)
                {
                    thamSo = new OleDbParameter("@MaTinhThanh", OleDbType.Integer);
                    thamSo.Value = maTinhThanh;
                    lenh.Parameters.Add(thamSo);
                }

                OleDbDataReader boDoc = lenh.ExecuteReader();

                string s = chuoiLenh.ToString();

                while (boDoc.Read())
                {
                    DiaDiemDTO diaDiem = new DiaDiemDTO();

                    diaDiem.MaDuLieu = boDoc.GetInt32(0);
                    diaDiem.TenDichVu = boDoc.GetString(1);
                    diaDiem.TenDiaDiem = boDoc.GetString(2);

                    try {
                        diaDiem.SoNha = boDoc.GetString(3);
                    }
                    catch {
                        diaDiem.SoNha = "";
                    }

                    diaDiem.TenDuong = boDoc.GetString(4);
                    diaDiem.TenPhuong = boDoc.GetString(5);
                    diaDiem.TenQuanHuyen = boDoc.GetString(6);
                    diaDiem.TenTinhThanh = boDoc.GetString(7);
                    diaDiem.KinhDo = boDoc.GetDouble(8);
                    diaDiem.ViDo = boDoc.GetDouble(9);

                    try {
                        diaDiem.GhiChu = boDoc.GetValue(10).ToString();
                    }
                    catch {
                        diaDiem.GhiChu = "";
                    }

                    dsDiaDiem.Add(diaDiem);
                }
            }
            catch
            {
                //dsDiaDiem = null;
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }

            return dsDiaDiem;
        }
        //End edit by Dũng----------
    }
}
