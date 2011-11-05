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
    public partial class F_ThemBienSo : Form
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();
        private string strCheck1 = "";
        private string strCheck2 = "";
        private string strCheck3 = "";

        public F_ThemBienSo()
        {
            InitializeComponent();
        }
        private void F_ThemBienSo_Load(object sender, EventArgs e)
        {
            cbb_PhuongTien.SelectedIndex = 1;

            List<BienSoXeDTO> dsBS = new List<BienSoXeDTO>();
            dsBS = ws.LayDanhSachBSXTongQuat();
            foreach (BienSoXeDTO bs in dsBS)
                cbbBienSo.Items.Add(bs.BienSo);
        }
        private void cbb_PhuongTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_PhuongTien.SelectedIndex == 0)
            {
                gb_Moto.Visible = true;
                gb_Oto.Visible = false;
                gb_Romooc.Visible = false;
            }
            else if (cbb_PhuongTien.SelectedIndex == 1)
            {
                gb_Moto.Visible = false;
                gb_Oto.Visible = true;
                gb_Romooc.Visible = false;
            }
            else
            {
                gb_Moto.Visible = false;
                gb_Oto.Visible = false;
                gb_Romooc.Visible = true;
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cbb_PhuongTien.SelectedIndex == 0)
            {
                if (cbbBienSo.Text != "")
                {
                    //Kiểm tra coi Biển số xe coi có tồn tại không.
                    List<BienSoXeDTO> dsBS = new List<BienSoXeDTO>();
                    dsBS = ws.LayDanhSachBSXTongQuat();
                    foreach (BienSoXeDTO bss in dsBS)
                    {
                        if (cbbBienSo.Text.Trim() == bss.BienSo.Trim())
                        {
                            strCheck1 = cbbBienSo.Text.Trim();
                            break;
                        }
                    }
                    if (strCheck1 != cbbBienSo.Text.Trim())
                    {
                        BienSoXeMotoDTO bs = new BienSoXeMotoDTO();
                        bs.BienSo = cbbBienSo.Text;
                        bs.CongSuat = int.Parse(tb_Moto_CongSuat.Text);
                        bs.DiaChi = tb_DiaChi.Text;
                        bs.DungTich = int.Parse(tb_Moto_DungTich.Text);
                        bs.LoaiXe = tb_Moto_LoaiXe.Text;
                        bs.MauSon = tb_MauSon.Text;
                        bs.NgayDangKyLanDau = dtp_NgayDangKyLanDau.Value;
                        bs.NhanHieu = tb_NhanHieu.Text;
                        bs.SoKhung = tb_SoKhung.Text;
                        bs.SoMay = tb_Oto_SoMay.Text;
                        bs.SoNguoiDuocPhepCho = int.Parse(tb_SoNguoi.Text);
                        bs.TenChuXe = tb_ChuXe.Text;

                        if (ws.ThemBienSoXe(bs))
                            MessageBox.Show("Thêm biển số \"" + cbbBienSo.Text + "\" cho xe Môtô thành công!", "Thông báo", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Thêm biển số \"" + cbbBienSo.Text + "\" cho xe Môtô thất bại!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Biển số xe Môtô \"" + cbbBienSo.Text + "\" này đã tồn tại.Bạn hãy điền biến số xe khác.", "Lỗi", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Bạn chưa điền biển số xe Môtô vào! Xin hãy điền vào!", "Lỗi", MessageBoxButtons.OK);
            }
            else if (cbb_PhuongTien.SelectedIndex == 1)
            {
                if (cbbBienSo.Text != "")
                {
                    //Kiểm tra coi Biển số xe coi có tồn tại không.
                    List<BienSoXeDTO> dsBS = new List<BienSoXeDTO>();
                    dsBS = ws.LayDanhSachBSXTongQuat();
                    foreach (BienSoXeDTO bss in dsBS)
                    {
                        if (cbbBienSo.Text.Trim() == bss.BienSo.Trim())
                        {
                            strCheck2 = cbbBienSo.Text.Trim();
                            break;
                        }
                    }
                    if (strCheck2 != cbbBienSo.Text.Trim())
                    {
                        BienSoXeOtoDTO bs = new BienSoXeOtoDTO();
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

                        if (ws.ThemBienSoXe(bs))
                            MessageBox.Show("Thêm biển số \"" + cbbBienSo.Text + "\" cho xe Ôtô thành công!", "Thông báo", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Thêm biển số \"" + cbbBienSo.Text + "\" cho xe Ôtô thất bại!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Biển số xe Ôtô \"" + cbbBienSo.Text + "\" này đã tồn tại.Bạn hãy điền biến số xe khác.", "Lỗi", MessageBoxButtons.OK);
                }

                else
                    MessageBox.Show("Bạn chưa điền biển số xe Ôtô vào! Xin hãy điền vào!", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
                if (cbbBienSo.Text != "")
                {
                    //Kiểm tra coi Biển số xe coi có tồn tại không.
                    List<BienSoXeDTO> dsBS = new List<BienSoXeDTO>();
                    dsBS = ws.LayDanhSachBSXTongQuat();
                    foreach (BienSoXeDTO bss in dsBS)
                    {
                        if (cbbBienSo.Text.Trim() == bss.BienSo.Trim())
                        {
                            strCheck3 = cbbBienSo.Text.Trim();
                            break;
                        }
                    }
                    if (strCheck3 != cbbBienSo.Text.Trim())
                    {
                        BienSoXeRomoocDTO bs = new BienSoXeRomoocDTO();
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

                        if (ws.ThemBienSoXe(bs))
                            MessageBox.Show("Thêm biển số \"" + cbbBienSo.Text + "\" cho xe Rơmooc thành công!", "Thông báo", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Thêm biển số \"" + cbbBienSo.Text + "\" cho xe Rơmooc thất bại!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Biển số xe  Rơmooc \"" + cbbBienSo.Text + "\" này đã tồn tại.Bạn hãy điền biến số xe khác.", "Lỗi", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Bạn chưa điền biển số xe Rơmooc vào! Xin hãy điền vào!", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void cbb_PhuongTien_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbb_PhuongTien, "Chọn loại phương tiện để thêm vào.");
        }
        private void dtp_NgayDangKyLanDau_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.dtp_NgayDangKyLanDau, "Điền ngày đăng kí lần đầu vào để thêm.");
        }
        private void tb_ChuXe_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_ChuXe, "Điền thông tin chủ sở hữu.");
        }
        private void tb_NhanHieu_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_NhanHieu, "Điền thông tin nhãn hiệu.");
        }
        private void tb_SoKhung_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_SoKhung, "Điền thông tin số khung cho xe.");
        }
        private void tb_MauSon_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_MauSon, "Điền thông tin màu sơn.");
        }
        private void cbbBienSo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbbBienSo, "Điền thông tin biển số xe cần thêm.");
        }
        private void tb_DiaChi_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_DiaChi, "Điền địa chỉ của chủ sở hữu.");
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbbBienSo_TextChanged(object sender, EventArgs e)
        {
            if (cbbBienSo.Text.Trim() == "")
            {
                cbbBienSo.BackColor = Color.Red;
                btn_Them.Enabled = false;
            }
            else
            {
                cbbBienSo.BackColor = Color.FromArgb(192, 192, 255);
                btn_Them.Enabled = true;
            }
        }
        private bool LaSo(string text)
        {
            try
            {
                double x = double.Parse(text);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
 
        }
        private void VoHieuHoa(TextBox t, Button b)
        {
            if (LaSo(t.Text) == true)
            {
                b.Enabled = true;
                t.BackColor = Color.White;
            }
            else
            {
                t.BackColor = Color.Red;
                b.Enabled = false;
            }
        }
    }
}
