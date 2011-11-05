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
    public partial class F_ThemLoiVP : Form
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();
        
        public F_ThemLoiVP()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHanhVi.Text != "")
            {
                HanhViViPhamDTO hv = new HanhViViPhamDTO();
                hv.TenHanhVi = txtHanhVi.Text;
                ChiTietHVVPDTO chiTiet = new ChiTietHVVPDTO();
                ws.ThemChiTietHanhVi(chiTiet);
                if (ws.ThemHanhVi(hv))
                    MessageBox.Show("Đã thêm lỗi \"" + txtHanhVi.Text + "\" thành công.", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Thêm lỗi thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Bạn chưa điền \"Tên Lỗi Vi Phạm\" vào.", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtHanhVi_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.txtHanhVi, "Điền lỗi vi phạm cần thêm vào.");
        }
    }
}
