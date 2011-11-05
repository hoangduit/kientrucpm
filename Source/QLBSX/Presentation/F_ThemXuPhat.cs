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
    public partial class F_ThemXuPhat : Form
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();

        public F_ThemXuPhat()
        {
            InitializeComponent();
        }
        private void F_ThemChiTietHanhVi_Load(object sender, EventArgs e)
        {
            NapDanhSachLoi(cbb_TenHanhVi);

            List<BienSoXeDTO> dsBS = new List<BienSoXeDTO>();
            dsBS = ws.LayDanhSachBSXTongQuat();
            foreach (BienSoXeDTO bs in dsBS)
                if(bs.VoHieuHoa == false)
                    cbb_BienSo.Items.Add(bs.BienSo);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbb_TenHanhVi.Text != "" && cbb_BienSo.Text != "" && tb_NguoiLap.Text != "" && tb_TienPhat.Text != "")
            {
                ChiTietHVVPDTO ct = new ChiTietHVVPDTO();
                ct.BienSo = ws.TraCuuBSXTheoBienSo(cbb_BienSo.SelectedItem.ToString());
                ct.HanhVi = ws.TraCuuHanhViTheoTenHanhVi(cbb_TenHanhVi.SelectedItem.ToString());
                ct.NguoiLapBienBan = tb_NguoiLap.Text;
                ct.ThoiGian = dtp_ThoiGian.Value;
                ct.TienPhat = double.Parse(tb_TienPhat.Text);
                    if (ws.ThemChiTietHanhVi(ct))
                        MessageBox.Show("Xử phạt biển số \"" + cbb_BienSo.Text + "\" vi phạm lỗi \"" + cbb_TenHanhVi.Text + "\" thành công.", "Thông báo", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Xử phạt biển số \"" + cbb_BienSo.Text + "\" vi phạm lỗi \"" + cbb_TenHanhVi.Text + "\" thất bại.", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Bạn điền còn thiếu, hoặc tiền phạt bạn nhập không đúng! Xin kiểm tra lại.", "Lỗi", MessageBoxButtons.OK);

        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbb_TenHanhVi_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbb_TenHanhVi, "Chọn lỗi vi phạm giao thông.");
        }
        private void cbb_BienSo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbb_BienSo, "Chọn biển số vi phạm giao thông.");
        }
        private void dtp_ThoiGian_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.dtp_ThoiGian, "Điền thời gian vi phạm giao thông.");
        }
        private void tb_NguoiLap_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_NguoiLap, "Điền thông tin người lập biên bản.");
        }
        private void tb_TienPhat_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_TienPhat, "Điền số tiền phạt: là là số.");
        }
        private void bntTL_Click(object sender, EventArgs e)
        {
            F_ThemLoiVP frm = new F_ThemLoiVP();
            frm.Show();
        }
        private void NapDanhSachLoi(ComboBox cbb)
        {
            cbb.Items.Clear();
            List<HanhViViPhamDTO> chiTiet = new List<HanhViViPhamDTO>();
            chiTiet = ws.LayDanhSachHanhVi();
            var query = from n in chiTiet
                        where n.VoHieuHoa == false
                        orderby n.TenHanhVi
                        select n;

            foreach (var ct in query)
                cbb.Items.Add(ct.TenHanhVi);
        }
    }
}
