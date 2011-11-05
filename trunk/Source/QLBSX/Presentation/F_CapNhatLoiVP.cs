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
    public partial class F_CapNhatLoiVP : Form
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();

        public F_CapNhatLoiVP()
        {
            InitializeComponent();
        }
        private void F_CapNhatHanhVi_Load(object sender, EventArgs e)
        {
            NapDanhSachLoi(cbbCu);
        }
        private void bntCapNhat_Click(object sender, EventArgs e)
        {
            if (cbbCu.Text != "" && txtMoi.Text != "")
            {
                HanhViViPhamDTO hv = new HanhViViPhamDTO();
                hv = ws.TraCuuHanhViTheoTenHanhVi(cbbCu.Text);
                hv.TenHanhVi = txtMoi.Text;
                if (ws.CapNhatHanhVi(hv))
                {
                    MessageBox.Show("Đã cập nhật lỗi \"" + cbbCu.Text + "\" thành lỗi \"" + txtMoi.Text + "\" thành công.", "Thông báo", MessageBoxButtons.OK);
                    NapDanhSachLoi(cbbCu);
                }
                else
                    MessageBox.Show("Đã cập nhật lỗi \"" + cbbCu.Text + "\" thành lỗi \"" + txtMoi.Text + "\" thất bại.", "Thông báo", MessageBoxButtons.OK);
            }
            else
                if (cbbCu.Text != "" && txtMoi.Text == "")
                {
                    MessageBox.Show("Bạn chưa điền thông tin lỗi vi phạm để cập nhật", "Lỗi", MessageBoxButtons.OK);
                }
                else
                    if ((cbbCu.Text == "" && txtMoi.Text != "") || (cbbCu.Text == "" && txtMoi.Text == ""))
                    {
                        MessageBox.Show("Bạn chưa chọn lỗi vi phạm để cập nhật", "Lỗi", MessageBoxButtons.OK);
                    }
        }
        private void cbbCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMoi.Text = cbbCu.Text;
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbbCu_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbbCu, "Chọn lỗi củ để cập nhật.");
        }
        private void txtMoi_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtMoi, "Điền thông tin của lỗi mới vào.");
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
