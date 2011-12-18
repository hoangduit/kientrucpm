using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Presentation.QLBSX_BUS_WebService;
/**
 * Tên Đề Tài; Phần Mền Quản Lý Biển Số Xe và Vi Phạm Giao Thông(VLNM (Vehicle license number management))
 * Ho tên sinh viên:
 * 1. Phan Nhật Tiến       0812515
 * 2. Huỳnh Công Toàn      0812527
 * 
 * GVHD. Trần Minh Triết
 **/

namespace Presentation
{
    public partial class F_TraCuuBSX : Form
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();

        public F_TraCuuBSX()
        {
            InitializeComponent();
        }
        private void F_TraCuuBSX_Load(object sender, EventArgs e)
        {
            gb_Moto.Visible = true;
            gb_Oto.Visible = false;
            gb_Romooc.Visible = false;
            cbb_PhuongTien.SelectedIndex = 0;
            NapDanhSachBienSo(cbbBienSo, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
        private void cbb_PhuongTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_PhuongTien.SelectedIndex == 0)
            {
                gb_Moto.Visible = true;
                gb_Oto.Visible = false;
                gb_Romooc.Visible = false;
                NapDanhSachBienSo(cbbBienSo, 0);
            }
            else if (cbb_PhuongTien.SelectedIndex == 1)
            {
                gb_Moto.Visible = false;
                gb_Oto.Visible = true;
                gb_Romooc.Visible = false;
                NapDanhSachBienSo(cbbBienSo, 1);
            }
            else if (cbb_PhuongTien.SelectedIndex == 2)
            {
                gb_Moto.Visible = false;
                gb_Oto.Visible = false;
                gb_Romooc.Visible = true;
                NapDanhSachBienSo(cbbBienSo, 2);
            }
        }
        private void cbbBienSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {            
            BienSoXe bs = ws.TraCuuBSXTheoBienSo(cbbBienSo.Text.Trim());            
            tb_ChuXe.Text = bs.TenChuXe.Trim();
            tb_DiaChi.Text = bs.DiaChi.Trim();
            tb_MauSon.Text = bs.MauSon.Trim();
            tb_SoKhung.Text = bs.SoKhung.Trim();
            tb_NgayDangKyLanDau.Text = bs.NgayDangKyLanDau.ToString().Trim();

            if (cbb_PhuongTien.SelectedIndex == 0)
            {
                BienSoXeMoto bsMoto = (BienSoXeMoto)ws.TraCuuBSXTheoBienSo(cbbBienSo.Text.Trim());
                tb_SoNguoi.Text = bsMoto.SoNguoiDuocPhepCho.ToString();
                tb_Moto_LoaiXe.Text = bsMoto.LoaiXe.Trim();
                tb_Moto_DungTich.Text = bsMoto.DungTich.ToString().Trim();
                tb_Moto_SoMay.Text = bsMoto.SoMay.Trim();
                tb_Moto_CongSuat.Text = bsMoto.CongSuat.ToString().Trim();

            }
            else
                if (cbb_PhuongTien.SelectedIndex == 1)
                {
                    BienSoXeOto bsOto = (BienSoXeOto)ws.TraCuuBSXTheoBienSo(cbbBienSo.Text.Trim());
                    tb_Oto_LoaiXe.Text = bsOto.LoaiXe.Trim(); ;
                    tb_Oto_DungTich.Text = bsOto.DungTich.ToString().Trim();
                    tb_Oto_TuTrong.Text = bsOto.TuTrong.Trim();
                    tb_Oto_TenDongCo.Text = bsOto.TenDongCo.Trim();
                    tb_Oto_NgayHetHan.Text = bsOto.NgayHetHan.ToString().Trim();
                    tb_Oto_Ngoi.Text = bsOto.Sc.Ngoi.ToString().Trim();
                    tb_Oto_Dung.Text = bsOto.Sc.Dung.ToString().Trim();
                    tb_Oto_Nam.Text = bsOto.Sc.Nam.ToString().Trim();
                    tb_Oto_NamSanXuat.Text = bsOto.NamSanXuat.ToString().Trim();
                    tb_Oto_TaiTrongHangHoa.Text = bsOto.TaiTrongHangHoa.ToString().Trim();
                    tb_Oto_CongSuat.Text = bsOto.CongSuat.ToString().Trim();
                    tb_Oto_SoMay.Text = bsOto.SoMay.Trim();
                    tb_Oto_Cao.Text = bsOto.Ktb.Cao.ToString().Trim();
                    tb_Oto_Dai.Text = bsOto.Ktb.Dai.ToString().Trim();
                    tb_Oto_Rong.Text = bsOto.Ktb.Rong.ToString().Trim();
                    tb_Oto_NgayHetHan.Text = bsOto.NgayHetHan.ToShortDateString();
                }
                else
                {
                    BienSoXeRomooc bsRM = (BienSoXeRomooc)ws.TraCuuBSXTheoBienSo(cbbBienSo.Text.Trim());
                    tb_Romooc_NamSanXuat.Text = bsRM.NamSanXuat.ToString().Trim();
                    tb_Romooc_TaiTrong.Text = bsRM.TaiTrong.ToString().Trim();
                    tb_Romooc_NgayHetHan.Text = bsRM.NgayHetHan.ToString().Trim();
                    tb_Romooc_Dai.Text = bsRM.Ktb.Dai.ToString().Trim();
                    tb_Romooc_Cao.Text = bsRM.Ktb.Cao.ToString().Trim();
                    tb_Romooc_Rong.Text = bsRM.Ktb.Rong.ToString().Trim();
                    tb_Romooc_NgayHetHan.Text = bsRM.NgayHetHan.ToShortDateString();
                }
        }
        private void NapDanhSachBienSo(ComboBox cbb, int loaiphuongtien)
        {
            cbb.Items.Clear();
            List<BienSoXe> dsBS = new List<BienSoXe>();
            dsBS = ws.LayDanhSachBienSoXe().ToList();
            foreach (BienSoXe bs in dsBS)
            {
                if (loaiphuongtien == 0)
                {
                    if (bs is BienSoXeMoto && bs.VoHieuHoa == false)
                        cbbBienSo.Items.Add(bs.BienSo);
                }
                else if (loaiphuongtien == 1)
                {
                    if (bs is BienSoXeOto && bs.VoHieuHoa == false)
                        cbbBienSo.Items.Add(bs.BienSo);
                }
                else
                {
                    if (bs is BienSoXeRomooc && bs.VoHieuHoa == false)
                        cbbBienSo.Items.Add(bs.BienSo);
                }
            }
        }
    }
}
