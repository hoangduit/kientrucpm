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
    public partial class F_XoaBienSo : Form
    {        
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();
        
        public F_XoaBienSo()
        {
            InitializeComponent();
        }
        private void F_XoaBienSo_Load(object sender, EventArgs e)
        {
            List<BienSoXeDTO> dsBS = new List<BienSoXeDTO>();
            dsBS = ws.LayDanhSachBSXTongQuat();
            foreach (BienSoXeDTO bs in dsBS)
                if(bs.VoHieuHoa == false)
                    cbb_BienSo.Items.Add(bs.BienSo);
        }
        private void bnt_Xoa_Click(object sender, EventArgs e)
        {
            if (cbb_BienSo.Text != "")
            {
                BienSoXeDTO bs = new BienSoXeDTO();                
                bs = ws.TraCuuBSXTheoBienSo(cbb_BienSo.Text);

                if (MessageBox.Show("Bạn có thật sự muốn xóa biển số \"" + cbb_BienSo.Text + "\"?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ws.VoHieuHoaBienSoXe(bs))
                    {
                        MessageBox.Show("Đã xóa biển số \"" + cbb_BienSo.Text + "\" thành công.", "Thông báo", MessageBoxButtons.OK);
                        //cbb_BienSo.Refresh();
                        cbb_BienSo.Items.Remove(cbb_BienSo.Text);
                    }
                    else
                        MessageBox.Show("Biến số \"" + cbb_BienSo.Text + "\" không tồn tại!", "Lỗi Dữ Liệu", MessageBoxButtons.OKCancel);
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn biển số xe!", "Lỗi", MessageBoxButtons.OK);
        }
        private void bnt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
