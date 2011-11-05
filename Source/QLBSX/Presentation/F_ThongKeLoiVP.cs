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
    public partial class F_ThongKeLoiVP : Form
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();
        List<ChiTietHVVPDTO> ds = new List<ChiTietHVVPDTO>();
        public F_ThongKeLoiVP()
        {
            InitializeComponent();
        }
        private void F_ThongKeLoiVP_Load(object sender, EventArgs e)
        {            
                        
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            dgv_ThongKeLoi.Rows.Clear();
            if (tb_Thang.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tháng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (tb_Nam.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập năm", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            int month = int.Parse(tb_Thang.Text);
            int year = int.Parse(tb_Nam.Text);

            List<ChiTietHVVPDTO> ct = new List<ChiTietHVVPDTO>();
            ct = ws.LayDanhSachChiTietHanhVi();
            var query = from n in ct
                        where n.ThoiGian.Year == year && n.ThoiGian.Month == month
                        group n by n.HanhVi.MaHanhVi into gr
                        select new
                        {
                            Key = gr.Key,
                            sl = gr.Count()
                        };

            int i = 1;
            int sum = 0;
            foreach (var n in query)
                sum += n.sl;
            foreach (var n in query)
            {
                dgv_ThongKeLoi.Rows.Add(i, ws.TraCuuHanhViTheoMaHanhVi(n.Key).TenHanhVi, n.sl, ((double)n.sl/sum).ToString("0.0%"));
                i++;
            }
            lbelCount.Text = sum.ToString();
        }
        private void btn_ThongKeTheoNam_Click(object sender, EventArgs e)
        {
            dgv_ThongKeLoi.Rows.Clear();
            if (tb_Nam.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập năm", "Thông báo", MessageBoxButtons.OK);
                return;
            }            
            int year = int.Parse(tb_Nam.Text);

            List<ChiTietHVVPDTO> ct = new List<ChiTietHVVPDTO>();
            ct = ws.LayDanhSachChiTietHanhVi();
            var query = from n in ct
                        where n.ThoiGian.Year == year
                        group n by n.HanhVi.MaHanhVi into gr
                        select new
                        {
                            Key = gr.Key,
                            sl = gr.Count()
                        };

            int i = 1;
            int sum = 0;
            foreach (var n in query)
                sum += n.sl;
            foreach (var n in query)
            {
                dgv_ThongKeLoi.Rows.Add(i, ws.TraCuuHanhViTheoMaHanhVi(n.Key).TenHanhVi, n.sl, ((double)n.sl / sum).ToString("0.0%"));
                i++;
            }
            lbelCount.Text = sum.ToString();
        }        
    }
}
