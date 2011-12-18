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
    public partial class F_CapNhatXuPhat : Form
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();
        List<ChiTietHVVPDTO> ds = new List<ChiTietHVVPDTO>();
        int MaChiTietHienTai;

        public F_CapNhatXuPhat()
        {
            InitializeComponent();
        }
        private void F_CapNhatChiTietHanhVi_Load(object sender, EventArgs e)
        {
            NapDanhSachLoi(cbb_TenHanhVi);

            List<BienSoXe> dsBS = new List<BienSoXe>();
            dsBS = ws.LayDanhSachBSXTongQuat().ToList();
            foreach (BienSoXe bs in dsBS)
                if(bs.VoHieuHoa == false)
                    cbb_BienSo.Items.Add(bs.BienSo);

            List<ChiTietHVVPDTO> dsCT = new List<ChiTietHVVPDTO>();
            dsCT = ws.LayDanhSachChiTietHanhVi().ToList();
            foreach (ChiTietHVVPDTO ct in dsCT)
            {
                cbbNguoiLap.Items.Add(ct.NguoiLapBienBan);
                cbbTienPhat.Items.Add(ct.TienPhat);
            }
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (cbb_TenHanhVi.Text != "" && cbb_BienSo.Text != "" && cbbNguoiLap.Text != "" && cbbTienPhat.Text != "")
            {
                ChiTietHVVPDTO ct = new ChiTietHVVPDTO();
                ct.MaChiTiet = MaChiTietHienTai;
                ct.BienSo = ws.TraCuuBSXTheoBienSo(cbb_BienSo.SelectedItem.ToString());
                ct.HanhVi = ws.TraCuuHanhViTheoTenHanhVi(cbb_TenHanhVi.SelectedItem.ToString());

                ct.NguoiLapBienBan = cbbNguoiLap.Text;
                ct.ThoiGian = dtp_ThoiGian.Value;
                ct.TienPhat = double.Parse(cbbTienPhat.Text);
                if (ws.CapNhatChiTietHanhVi(ct))
                    MessageBox.Show("Cập nhật \"" + cbb_BienSo.Text + "\" cho lỗi \"" + cbb_TenHanhVi.Text + "\" thành công.", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Cập nhật \"" + cbb_BienSo.Text + "\" cho lỗi \"" + cbb_TenHanhVi.Text + "\" thất bại.", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Bạn đã thiếu thông tin! Xin kiểm tra lại", "Lỗi", MessageBoxButtons.OK);
        }
        private void dgv_DanhSachChiTiet_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChiTietHVVPDTO ct = ds[e.RowIndex];
            MaChiTietHienTai = ct.MaChiTiet;
            cbb_TenHanhVi.Text = dgv_DanhSachChiTiet.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbb_BienSo.Text = dgv_DanhSachChiTiet.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtp_ThoiGian.Value = ct.ThoiGian;
            cbbNguoiLap.Text = ct.NguoiLapBienBan;
            cbbTienPhat.Text = ct.TienPhat.ToString();
        }
        private void btn_HanhVi_Click(object sender, EventArgs e)
        {
            if (cbb_TenHanhVi.Text != "")
            {
                ds = ws.TraCuuCTHVTheoTenHanhVi(cbb_TenHanhVi.SelectedItem.ToString()).ToList();
                dgv_DanhSachChiTiet.Rows.Clear();
                foreach (ChiTietHVVPDTO ct in ds)
                {
                    BienSoXe temp = (BienSoXe)ct.BienSo;
                    dgv_DanhSachChiTiet.Rows.Add(ct.HanhVi.TenHanhVi, temp.BienSo, ct.ThoiGian.ToString("dd/MM/yyyy hh:mm:ss"), ct.NguoiLapBienBan, ct.TienPhat.ToString("0,0"));
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn lỗi để tra cứu!", "Lỗi", MessageBoxButtons.OK);
        }
        private void btn_BienSo_Click(object sender, EventArgs e)
        {
            if (cbb_BienSo.Text != "")
            {
                ds = ws.TraCuuCTHVTheoBienSo(cbb_BienSo.SelectedItem.ToString()).ToList();
                dgv_DanhSachChiTiet.Rows.Clear();
                foreach (ChiTietHVVPDTO ct in ds)
                {
                    BienSoXe temp = (BienSoXe)ct.BienSo;
                    dgv_DanhSachChiTiet.Rows.Add(ct.HanhVi.TenHanhVi, temp.BienSo, ct.ThoiGian.ToString("dd/MM/yyyy hh:mm:ss"), ct.NguoiLapBienBan, ct.TienPhat.ToString("0,0"));
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn biển số xe để tra cứu!", "Lỗi", MessageBoxButtons.OK);
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbb_TenHanhVi_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbb_TenHanhVi, "Chọn lỗi để cập nhật.");
        }
        private void cbb_BienSo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbb_BienSo, "Chọn biển số để cập nhật.");
        }
        private void dtp_ThoiGian_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.dtp_ThoiGian, "Chọn thời gian để cập nhật.");
        }
        private void cbbNguoiLap_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbbNguoiLap, "Điền thông tin người lập để cập nhật.");
        }
        private void cbbTienPhat_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbbTienPhat, "Điền số tiền phạt để cập nhật.");
        }
        private void NapDanhSachLoi(ComboBox cbb)
        {
            cbb.Items.Clear();
            List<HanhViViPhamDTO> chiTiet = new List<HanhViViPhamDTO>();
            chiTiet = ws.LayDanhSachHanhVi().ToList();
            var query = from n in chiTiet
                        where n.VoHieuHoa == false
                        orderby n.TenHanhVi
                        select n;

            foreach (var ct in query)
                cbb.Items.Add(ct.TenHanhVi);
        }
    }
}
