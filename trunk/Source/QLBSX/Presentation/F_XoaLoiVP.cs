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
    public partial class F_XoaLoiVP : Form
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();

        public F_XoaLoiVP()
        {
            InitializeComponent();
        }
        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (cbbChiTiet.Text != "")
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa lỗi \"" + cbbChiTiet.Text + "\"?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HanhViViPhamDTO hv = new HanhViViPhamDTO();
                    hv = ws.TraCuuHanhViTheoTenHanhVi(cbbChiTiet.Text);
                    if (ws.VoHieuHoaHanhVi(hv))
                    {
                        MessageBox.Show("Xóa lỗi \"" + cbbChiTiet.Text + "\" thành công.", "Thông báo", MessageBoxButtons.OK);
                        cbbChiTiet.Refresh();
                        cbbChiTiet.Items.Remove(cbbChiTiet.Text);
                    }
                    else
                        MessageBox.Show("Xóa lỗi \"" + cbbChiTiet.Text + "\" thất bại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn \"Lỗi\" cần xóa.","Lỗi",MessageBoxButtons.OK);
            }
        }
        private void F_XoaHanhVi_Load(object sender, EventArgs e)
        {
            NapDanhSachLoi(cbbChiTiet);
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
