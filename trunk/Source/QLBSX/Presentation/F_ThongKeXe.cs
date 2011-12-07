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
    public partial class F_ThongKeXe : Form
    {
        private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();

        public F_ThongKeXe()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
            int MotoCount, OtoCount, RomoocCount;

            List<BienSoXe> ds = new List<BienSoXe>();
            ds = ws.LayDanhSachBienSoXe().ToList();
            List<int> list = new List<int>() { 1, 2, 3 };

            var query = from n in ds
                        where n is BienSoXeMoto && n.VoHieuHoa == false && n.NgayDangKyLanDau.Year == year && n.NgayDangKyLanDau.Month == month
                        select n;
            MotoCount = query.Count();
            query = from n in ds
                    where n is BienSoXeOto && n.VoHieuHoa == false && n.NgayDangKyLanDau.Year == year && n.NgayDangKyLanDau.Month == month
                    select n;
            OtoCount = query.Count();
            query = from n in ds
                    where n is BienSoXeRomooc && n.VoHieuHoa == false && n.NgayDangKyLanDau.Year == year && n.NgayDangKyLanDau.Month == month
                    select n;
            RomoocCount = query.Count();

            int sum = MotoCount + OtoCount + RomoocCount;
            dgv_ThongKeBienSo.Rows.Clear();
            dgv_ThongKeBienSo.Rows.Add(1, "Môtô", MotoCount, ((double)MotoCount / sum).ToString("0.0%"));
            dgv_ThongKeBienSo.Rows.Add(2, "Ôtô", OtoCount, ((double)OtoCount / sum).ToString("0.0%"));
            dgv_ThongKeBienSo.Rows.Add(3, "Rơmoóc", RomoocCount, ((double)RomoocCount / sum).ToString("0.0%"));
            lbelConut.Text = sum.ToString();
        }
        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ThongKeNam_Click(object sender, EventArgs e)
        {
            if (tb_Nam.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập năm", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            int month = int.Parse(tb_Thang.Text);
            int year = int.Parse(tb_Nam.Text);
            int MotoCount, OtoCount, RomoocCount;

            List<BienSoXe> ds = new List<BienSoXe>();
            ds = ws.LayDanhSachBienSoXe().ToList();
            List<int> list = new List<int>() { 1, 2, 3 };

            var query = from n in ds
                        where n is BienSoXeMoto && n.VoHieuHoa == false && n.NgayDangKyLanDau.Year == year
                        select n;
            MotoCount = query.Count();
            query = from n in ds
                    where n is BienSoXeOto && n.VoHieuHoa == false && n.NgayDangKyLanDau.Year == year
                    select n;
            OtoCount = query.Count();
            query = from n in ds
                    where n is BienSoXeRomooc && n.VoHieuHoa == false && n.NgayDangKyLanDau.Year == year
                    select n;
            RomoocCount = query.Count();

            int sum = MotoCount + OtoCount + RomoocCount;
            dgv_ThongKeBienSo.Rows.Clear();
            dgv_ThongKeBienSo.Rows.Add(1, "Môtô", MotoCount, ((double)MotoCount / sum).ToString("0.0%"));
            dgv_ThongKeBienSo.Rows.Add(2, "Ôtô", OtoCount, ((double)OtoCount / sum).ToString("0.0%"));
            dgv_ThongKeBienSo.Rows.Add(3, "Rơmoóc", RomoocCount, ((double)RomoocCount / sum).ToString("0.0%"));
            lbelConut.Text = sum.ToString();
        }
    }
}
