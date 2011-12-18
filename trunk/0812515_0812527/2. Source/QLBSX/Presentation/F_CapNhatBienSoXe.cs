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
    public partial class F_CapNhatBienSoXe : Form
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();
        int iMaBienSoHienTai;
        public F_CapNhatBienSoXe()
        {
            InitializeComponent();
        }
        private void F_CapNhatBienSoXe_Load(object sender, EventArgs e)
        {
            cbb_PhuongTien.SelectedIndex = 0;
            NapDanhSachBienSo(cbbBienSo, 0);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cbb_PhuongTien.SelectedIndex == 0)
            {
                if (cbbBienSo.Text != "")
                {
                    BienSoXeMoto bs = new BienSoXeMoto();
                    bs.MaBienSo = iMaBienSoHienTai;
                    bs.BienSo = cbbBienSo.Text;
                    bs.CongSuat = int.Parse(tb_Moto_CongSuat.Text);
                    bs.DiaChi = tb_DiaChi.Text;
                    bs.DungTich = int.Parse(tb_Moto_DungTich.Text);
                    bs.LoaiXe = tb_Moto_LoaiXe.Text;
                    bs.MauSon = tb_MauSon.Text;
                    bs.NgayDangKyLanDau = dtp_NgayDangKyLanDau.Value;
                    bs.NhanHieu = tb_NhanHieu.Text;
                    bs.SoKhung = tb_SoKhung.Text;
                    bs.SoMay = tb_Moto_SoMay.Text;
                    bs.SoNguoiDuocPhepCho = int.Parse(tb_SoNguoi.Text);
                    bs.TenChuXe = tb_ChuXe.Text;

                    if (ws.CapNhatBienSoXe(bs))
                        MessageBox.Show("Đã cập nhật thông tin cho xe Môtô với biển số \"" + cbbBienSo.Text + "\" thành công!", "Thông báo", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Cập nhật thông tin cho xe Môtô với biển số \"" + cbbBienSo.Text + "\" thất bại!", "Lỗi", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Bạn chưa chọn biển số xe Môtô! Xin hãy chọn!", "Lỗi", MessageBoxButtons.OK);
            }
            else if (cbb_PhuongTien.SelectedIndex == 1)
            {
                if (cbbBienSo.Text != "")
                {
                    BienSoXeOto bs = new BienSoXeOto();
                    bs.MaBienSo = iMaBienSoHienTai;
                    bs.BienSo = cbbBienSo.Text;
                    bs.CongSuat = int.Parse(tb_Oto_CongSuat.Text);
                    bs.DiaChi = tb_DiaChi.Text;
                    bs.DungTich = int.Parse(tb_Oto_DungTich.Text);
                    bs.Ktb = ws.TaoKichThuocBao(float.Parse(tb_Oto_Dai.Text), float.Parse(tb_Oto_Rong.Text), float.Parse(tb_Oto_Cao.Text));
                    bs.LoaiXe = tb_Oto_LoaiXe.Text;
                    bs.MauSon = tb_MauSon.Text;
                    bs.NamSanXuat = int.Parse(tb_Oto_NamSanXuat.Text);
                    bs.NgayDangKyLanDau = dtp_NgayDangKyLanDau.Value;
                    bs.NgayHetHan = dtp_Oto_NgayHetHan.Value;
                    bs.NhanHieu = tb_NhanHieu.Text;
                    bs.Sc = ws.TaoSoCho(int.Parse(tb_Oto_Ngoi.Text), int.Parse(tb_Oto_Dung.Text), int.Parse(tb_Oto_Nam.Text));
                    bs.SoKhung = tb_SoKhung.Text;
                    bs.SoMay = tb_Oto_SoMay.Text;
                    bs.TaiTrongHangHoa = int.Parse(tb_Oto_TaiTrongHangHoa.Text);
                    bs.TenChuXe = tb_ChuXe.Text;
                    bs.TenDongCo = tb_Oto_TenDongCo.Text;
                    bs.TuTrong = tb_Oto_TuTrong.Text;

                    if (ws.CapNhatBienSoXe(bs))
                        MessageBox.Show("Đã cập nhật thông tin cho xe Ôtô với biển số \"" + cbbBienSo.Text + "\" thành công!", "Thông báo", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Cập nhật thông tin cho xe Ôtô với biển số \"" + cbbBienSo.Text + "\" thất bại!", "Lỗi", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Bạn chưa chọn biển số xe Ôtô! Xin hãy chọn!", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                if (cbbBienSo.Text != "")
                {
                    BienSoXeRomooc bs = new BienSoXeRomooc();
                    bs.MaBienSo = iMaBienSoHienTai;
                    bs.BienSo = cbbBienSo.Text;
                    bs.DiaChi = tb_DiaChi.Text;
                    bs.Ktb = ws.TaoKichThuocBao(float.Parse(tb_Romooc_Dai.Text), float.Parse(tb_Romooc_Rong.Text), float.Parse(tb_Romooc_Cao.Text));
                    bs.MauSon = tb_MauSon.Text;
                    bs.NamSanXuat = int.Parse(tb_Romooc_NamSanXuat.Text);
                    bs.NgayDangKyLanDau = dtp_NgayDangKyLanDau.Value;
                    bs.NgayHetHan = dtp_Romooc_NgayHetHan.Value;
                    bs.NhanHieu = tb_NhanHieu.Text;
                    bs.SoKhung = tb_SoKhung.Text;
                    bs.TaiTrong = int.Parse(tb_Romooc_TaiTrong.Text);
                    bs.TenChuXe = tb_ChuXe.Text;

                    if (ws.CapNhatBienSoXe(bs))
                        MessageBox.Show("Đã cập nhật thông tin cho xe Rơmooc với biển số \"" + cbbBienSo.Text + "\" thành công!", "Thông báo", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Cập nhật thông tin cho xe Rơmooc với biển số \"" + cbbBienSo.Text + "\" thất bại!", "Lỗi", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Bạn chưa chọn biển số xe Rơmooc! Xin hãy chọn!", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
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
            else
            {
                gb_Moto.Visible = false;
                gb_Oto.Visible = false;
                gb_Romooc.Visible = true;
                NapDanhSachBienSo(cbbBienSo, 2);
            }
        }
        private void cbbBienSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BienSoXe bs = ws.TraCuuBSXTheoBienSo(cbbBienSo.Text.Trim());
            iMaBienSoHienTai = bs.MaBienSo;
            tb_ChuXe.Text = bs.TenChuXe.Trim();
            tb_DiaChi.Text = bs.DiaChi.Trim();
            tb_MauSon.Text = bs.MauSon.Trim();
            tb_SoKhung.Text = bs.SoKhung.Trim();
            dtp_NgayDangKyLanDau.Text = bs.NgayDangKyLanDau.ToString().Trim();

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
                    dtp_Oto_NgayHetHan.Text = bsOto.NgayHetHan.ToString().Trim();
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
                    dtp_Oto_NgayHetHan.Text = bsOto.NgayHetHan.ToShortDateString();
                }
                else
                {
                    BienSoXeRomooc bsRM = (BienSoXeRomooc)ws.TraCuuBSXTheoBienSo(cbbBienSo.Text.Trim());
                    tb_Romooc_NamSanXuat.Text = bsRM.NamSanXuat.ToString().Trim();
                    tb_Romooc_TaiTrong.Text = bsRM.TaiTrong.ToString().Trim();
                    dtp_Romooc_NgayHetHan.Text = bsRM.NgayHetHan.ToString().Trim();
                    tb_Romooc_Dai.Text = bsRM.Ktb.Dai.ToString().Trim();
                    tb_Romooc_Cao.Text = bsRM.Ktb.Cao.ToString().Trim();
                    tb_Romooc_Rong.Text = bsRM.Ktb.Rong.ToString().Trim();
                    dtp_Romooc_NgayHetHan.Text = bsRM.NgayHetHan.ToShortDateString();
                }
        }
        private void tb_ChuXe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_ChuXe, "Điền thông tin tên chủ xe để cập nhật");
        }
        private void tb_NhanHieu_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_NhanHieu, "Điền thông tin của nhãn nhiệu xe để cập nhật.");
        }
        private void tb_SoKhung_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_SoKhung, "Điền thông tin của số khung đề cập nhật.");
        }
        private void tb_MauSon_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_MauSon, "Điền thông tin của màu sơn.");
        }
        private void cbbBienSo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbbBienSo, "Chọn biến số để cập nhật.");
        }
        private void tb_DiaChi_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_DiaChi, "Điền thông tin của địa chỉ.");
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
                    if(bs is BienSoXeMoto && bs.VoHieuHoa == false)
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
