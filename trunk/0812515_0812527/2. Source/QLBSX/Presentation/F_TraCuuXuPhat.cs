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
    public partial class F_TraCuuXuPhat : Form
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();
        List<ChiTietHVVPDTO> ds = new List<ChiTietHVVPDTO>();
        
        public F_TraCuuXuPhat()
        {
            InitializeComponent();
        }

        private void F_TraCuuLoi_Load(object sender, EventArgs e)
        {
            NapDanhSachLoi(cbb_TenHanhVi);
            ws.LayDanhSachBienSoXeCompleted += ws_LayDanhSachBienSoXeCompleted;
            ws.LayDanhSachBienSoXeAsync();            
        }

        void ws_LayDanhSachBienSoXeCompleted(object sender, LayDanhSachBienSoXeCompletedEventArgs e)
        {
            if (e.Error != null)
                return;
            
            List<BienSoXe> dsBS = new List<BienSoXe>();            
            dsBS = e.Result.ToList();
            foreach (BienSoXe bs in dsBS)
                if (bs.VoHieuHoa == false)
                    cbb_BienSo.Items.Add(bs.BienSo);
        }

        private void btn_TraCuu_Click(object sender, EventArgs e)
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
                MessageBox.Show("Bạn chưa chọn hoặc điền thông tin \"Lỗi vi phạm\" để tra cứu!", "Lỗi", MessageBoxButtons.OK);
        }
        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Bạn chưa chọn hoặc điền thông tin \"Biển số vi phạm\" để tra cứu!", "Lỗi", MessageBoxButtons.OK);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (cbb_TenHanhVi.Text != "")
            {
                HanhViViPhamDTO hv = new HanhViViPhamDTO();
                hv = ws.TraCuuHanhViTheoTenHanhVi(cbb_TenHanhVi.Text);
                if (MessageBox.Show("Bạn có thật sự muốn xóa lỗi \"" + cbb_TenHanhVi.Text + "\"?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ws.VoHieuHoaHanhVi(hv))
                    {
                        MessageBox.Show("Xóa lỗi \"" + cbb_TenHanhVi.Text + "\" thành công.", "Thông báo", MessageBoxButtons.OK);
                        cbb_TenHanhVi.Refresh();
                        cbb_TenHanhVi.Items.Remove(cbb_TenHanhVi.Text);
                    }
                    else
                        MessageBox.Show("Xóa lỗi \"" + cbb_TenHanhVi.Text + "\" thất bại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn \"Lỗi\" cần xóa.", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
