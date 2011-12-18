using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Presentation.QLBSX_BUS_WebService;
using System.Xml;
using Presentation.Delegate;
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
    public partial class F_AMain_QLBSX : Form
    {
        //private QLBSX_BUS_WebServiceSoapClient ws = new QLBSX_BUS_WebServiceSoapClient();
        private HanhViViPham hanhVi = new HanhViViPham();
        public F_AMain_QLBSX()
        {
            InitializeComponent();
        }
        private void thêmBiểnSốXeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_ThemBienSo frm = new F_ThemBienSo();
            frm.Show();
        }      
        private void traCứuBiểnSốXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TraCuuBSX frm = new F_TraCuuBSX();
            frm.Show();
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ThemXuPhat frm = new F_ThemXuPhat();
            frm.Show();
        }
        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CapNhatXuPhat frm = new F_CapNhatXuPhat();
            frm.Show();
        }
        private void ThoatHeThong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void xóaBiểnSốXeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            F_XoaBienSo frm = new F_XoaBienSo();
            frm.Show();
        }
        private void cậpNhậtBiểnSốXeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_CapNhatBienSoXe frm = new F_CapNhatBienSoXe();
            frm.Show();
        }
        private void thêmHànhViViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ThemXuPhat frm = new F_ThemXuPhat();
            frm.Show();
        }
        private void sửaHànhViViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CapNhatXuPhat frm = new F_CapNhatXuPhat();
            frm.Show();
        }
        private void traCứuHànhViViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TraCuuXuPhat frm = new F_TraCuuXuPhat();
            frm.Show();
        }
        private void thốngKêLoạiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ThongKeXe frm = new F_ThongKeXe();
            frm.Show();
        }
        private void thốngKêHànhViViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ThongKeLoiVP frm = new F_ThongKeLoiVP();
            frm.Show();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //F_Help frm = new F_Help();
            //frm.Show();
            Help.ShowHelp(this, Application.StartupPath + "\\Help.chm");
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_About frm = new F_About();
            frm.Show();
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {            
            NapDanhSachBienSo();
            NapDanhSachXuPhat();
            NapDanhSachLoi(cbbTenVPCu);
        }
        private void bntThemVP_Click(object sender, EventArgs e)
        {
            if (cbbTenVPCu.Text != "")
            {
                HanhViViPhamDTO hv = new HanhViViPhamDTO();
               hv = hanhVi.TraCuuHanhViTheoTenHanhVi(cbbTenVPCu.Text);
                if (hv.TenHanhVi != cbbTenVPCu.Text)
                {

                    hv.TenHanhVi = cbbTenVPCu.Text;
                    ChiTietHVVPDTO chiTiet = new ChiTietHVVPDTO();
                    hanhVi.ThemChiTietHanhVi(chiTiet);
                    if (hanhVi.ThemHanhVi(hv))
                    {
                        MessageBox.Show("Thêm lỗi \"" + cbbTenVPCu.Text + "\" thành công.", "Thông báo", MessageBoxButtons.OK);
                        NapDanhSachLoi(cbbTenVPCu);
                    }
                    else
                        MessageBox.Show("Thêm lỗi \"" + cbbTenVPCu.Text + "\" thất bại.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Lỗi vi phạm \""+cbbTenVPCu.Text+"\" đã tồn tại! Bạn chắc là điền đúng không?", "Lỗi", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Bạn chưa điền lỗi vi phạm!", "Lỗi", MessageBoxButtons.OK);
        }
        private void bntXoaVP_Click(object sender, EventArgs e)
        {
            if (cbbTenVPCu.Text != "")
            {

                HanhViViPhamDTO hv = new HanhViViPhamDTO();
                hv = hanhVi.TraCuuHanhViTheoTenHanhVi(cbbTenVPCu.Text);
                if (hv.TenHanhVi == cbbTenVPCu.Text)
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa lỗi \"" + cbbTenVPCu.Text + "\"?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (hanhVi.VoHieuHoaHanhVi(hv))
                        {
                            MessageBox.Show("Xóa lỗi \"" + cbbTenVPCu.Text + "\" thành công.", "Thông báo", MessageBoxButtons.OK);
                            cbbTenVPCu.Items.Remove(cbbTenVPCu.Text);
                        }
                        else
                            MessageBox.Show("Xóa lỗi \"" + cbbTenVPCu.Text + "\" thất bại.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                    MessageBox.Show("Lỗi \"" + cbbTenVPCu.Text + "\" không tồn tại.", "Lỗi", MessageBoxButtons.OK);
            }
            else
            MessageBox.Show("Bạn chưa chọn lỗi để xóa!", "Lỗi", MessageBoxButtons.OK);
        }
        private void bntCapNhatVP_Click(object sender, EventArgs e)
        {
            if (cbbTenVPCu.Text != "" && tb_TenHanhViMoi.Text != "")
            {
                HanhViViPhamDTO hv = new HanhViViPhamDTO();
                hv = hanhVi.TraCuuHanhViTheoTenHanhVi(cbbTenVPCu.Text);
                if (hv.TenHanhVi == cbbTenVPCu.Text)
                {
                    hv.TenHanhVi = tb_TenHanhViMoi.Text;
                    if (hanhVi.CapNhatHanhVi(hv))
                    {
                        MessageBox.Show("Đã cập nhật lỗi \"" + cbbTenVPCu.Text + "\" thành lỗi \"" + tb_TenHanhViMoi.Text + "\" thành công.", "Thông báo", MessageBoxButtons.OK);
                        NapDanhSachLoi(cbbTenVPCu);
                    }
                    else
                        MessageBox.Show("Đã cập nhật lỗi \"" + cbbTenVPCu.Text + "\" thành lỗi \"" + tb_TenHanhViMoi.Text + "\" thất bại.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Lỗi \"" + cbbTenVPCu.Text + "\" không tồn tại. Nên không thể cập nhật được.", "Lỗi", MessageBoxButtons.OK);
            }
            if (cbbTenVPCu.Text != "" && tb_TenHanhViMoi.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin lỗi vi phạm để cập nhật", "Lỗi", MessageBoxButtons.OK);
            }
            if ((cbbTenVPCu.Text == "" && tb_TenHanhViMoi.Text != "") || (cbbTenVPCu.Text == "" && tb_TenHanhViMoi.Text == ""))
            {
                MessageBox.Show("Bạn chưa chọn lỗi vi phạm để cập nhật", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void thêmHànhViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ThemLoiVP frm = new F_ThemLoiVP();
            frm.Show();
        }
        private void xóaHànhViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_XoaLoiVP frm = new F_XoaLoiVP();
            frm.Show();
        }
        private void cậpNhậtHànhViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CapNhatLoiVP frm = new F_CapNhatLoiVP();
            frm.Show();
        }
        private void cbbTenVPCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_TenHanhViMoi.Text = cbbTenVPCu.Text;
        }
        //private void bntThemBS_Click(object sender, EventArgs e)
        //{
        //    F_ThemBienSo frm = new F_ThemBienSo();
        //    frm.Show();
        //}
        //private void bntXoaBS_Click(object sender, EventArgs e)
        //{
        //    F_XoaBienSo frm = new F_XoaBienSo();
        //    frm.Show();
        //}
        //private void bntCapNhatBS_Click(object sender, EventArgs e)
        //{
        //    F_CapNhatBienSoXe frm = new F_CapNhatBienSoXe();
        //    frm.Show();
        //}
        //private void bntThoat_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbbTenVPCu_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cbbTenVPCu, "Bạn nhập vào thông tin của lỗi vi phạm.");
        }
        private void tb_TenHanhViMoi_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.tb_TenHanhViMoi,"Bạn nhập vào thông tin của lỗi vi phạm để cập nhật.");
        }
        private void F_AMain_QLBSX_Load(object sender, EventArgs e)
        {
            NapDanhSachBienSo();
            drawButton("configButton.xml", "Button");
        }
        private void NapDanhSachBienSo()
        {
            List<BienSoXe> dsbs = new List<BienSoXe>();
            dsbs = hanhVi.LayDanhSachBienSoXe().ToList();
            int iBien = 1;
            dgv_DSBSX.Rows.Clear();
            //dgv_DSBSX.Refresh();
            foreach (BienSoXe bs in dsbs)
            {
                if (bs.VoHieuHoa == false)
                {
                    if (bs is BienSoXeMoto)
                    {
                        BienSoXeMoto temp = new BienSoXeMoto();
                        temp = (BienSoXeMoto)bs;
                        dgv_DSBSX.Rows.Add(iBien.ToString(), temp.TenChuXe, temp.BienSo, "Môtô", temp.NgayDangKyLanDau.ToShortDateString(), temp.DiaChi);
                    }
                    else if (bs is BienSoXeOto)
                    {
                        BienSoXeOto temp = new BienSoXeOto();
                        temp = (BienSoXeOto)bs;
                        dgv_DSBSX.Rows.Add(iBien.ToString(), temp.TenChuXe, temp.BienSo, "Ôtô", temp.NgayDangKyLanDau.ToShortDateString(), temp.DiaChi);
                    }
                    else if (bs is BienSoXeRomooc)
                    {
                        BienSoXeRomooc temp = new BienSoXeRomooc();
                        temp = (BienSoXeRomooc)bs;
                        dgv_DSBSX.Rows.Add(iBien.ToString(), temp.TenChuXe, temp.BienSo, "Rơmoóc", temp.NgayDangKyLanDau.ToShortDateString(), temp.DiaChi);
                    }
                    iBien++;
                }
            }
        }
        private void NapDanhSachXuPhat()
        {
            dgv_ChiTietHanhVi.Rows.Clear();
            //dgv_ChiTietHanhVi.Refresh();
            List<ChiTietHVVPDTO> ds = new List<ChiTietHVVPDTO>();
            ds = hanhVi.LayDanhSachChiTietHanhVi().ToList();
            int i = 1;
            foreach (ChiTietHVVPDTO ct in ds)
            {
                BienSoXe temp = new BienSoXeMoto();
                temp = (BienSoXe)ct.BienSo;
                dgv_ChiTietHanhVi.Rows.Add(i.ToString(), ct.HanhVi.TenHanhVi, temp.BienSo, ct.ThoiGian.ToString("dd/MM/yyyy hh:mm:ss"), ct.NguoiLapBienBan, ct.TienPhat.ToString("0,0"));
                i++;
            }
        }
        private void NapDanhSachLoi(ComboBox cbb)
        {
            cbb.Items.Clear();
            List<HanhViViPhamDTO> chiTiet = new List<HanhViViPhamDTO>();            
            chiTiet = hanhVi.LayDanhSachHanhVi().ToList();
            var query = from n in chiTiet
                        where n.VoHieuHoa == false
                        orderby n.TenHanhVi
                        select n;

            foreach (var ct in query)                
                cbb.Items.Add(ct.TenHanhVi);
        }

        private void F_AMain_QLBSX_FormClosed(object sender, FormClosedEventArgs e)
        {
            hanhVi.Disconnect();
        }
        public XmlNodeList docXML(String fileName, String nameTag)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            XmlElement t = doc.DocumentElement;
            XmlNodeList list;
            list = t.SelectNodes(nameTag);
            return list;
        }
         public void drawButton(String fileName, String nameTag)
        {
            XmlNodeList list = docXML(fileName, nameTag);
            Button btnMyButton = null;
            for (int i = 0; i < list.Count; i++)
            {
                btnMyButton = new Button();
                int x = Convert.ToInt32(list[i].SelectNodes("Left")[0].InnerText);
                int y = Convert.ToInt32(list[i].SelectNodes("Top")[0].InnerText);
                btnMyButton.Location = new System.Drawing.Point(x, y);
                btnMyButton.Name = "btn" + i.ToString();
                int width = Convert.ToInt32(list[i].SelectNodes("Width")[0].InnerText);
                int height = Convert.ToInt32(list[i].SelectNodes("Height")[0].InnerText);
                btnMyButton.Size = new Size(width, height);
                btnMyButton.TabIndex = 65000 + i;
                btnMyButton.Text = list[i].SelectNodes("Caption")[0].InnerText;
                btnMyButton.UseVisualStyleBackColor = true;
                if (i == 0)
                {
                    btnMyButton.Click += new EventHandler(btnMyButton_Click_Them);
                }
                if (i == 1)
                {
                    btnMyButton.Click +=new EventHandler(btnMyButton_Click_Xoa);
                }
                if (i == 2)
                {
                    btnMyButton.Click += new EventHandler(btnMyButton_Click_CapNhat);
                }
                if (i == 3)
                {
                    btnMyButton.Click += new EventHandler(btnMyButton_Click_Thoat);
                }
                this.Controls.Add(btnMyButton);
            }
        }

         void btnMyButton_Click_Thoat(object sender, EventArgs e)
         {
             FileLogger fl = new FileLogger("process.log");
             DelegateLog myClass = new DelegateLog();
             
             myClass.Log += new DelegateLog.LogHandler(Logger);
             myClass.Log += new DelegateLog.LogHandler(fl.Logger);
             
             myClass.Process();

             fl.Close();
             this.Close();
         }

         void btnMyButton_Click_CapNhat(object sender, EventArgs e)
         {
             F_CapNhatBienSoXe frm = new F_CapNhatBienSoXe();
             frm.Show();
         }

         void btnMyButton_Click_Them(object sender, EventArgs e)
         {
             F_ThemBienSo frm = new F_ThemBienSo();
             frm.Show();
         }
         void btnMyButton_Click_Xoa(object sender, EventArgs e)
         {
             F_XoaBienSo frm = new F_XoaBienSo();
             frm.Show();
         }
         static void Logger(string s)
         {
             MessageBox.Show(s);
         }
    }
}
