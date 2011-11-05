using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DAO;
using System.Linq;
using DTO;
using System.Text;
using System.Windows.Forms;

namespace District4_SearchService
{
    public partial class frmDanhSach : Form
    {
        public frmDanhSach()
        {
            InitializeComponent();
            SetLocation();
            PictureBox pb = new PictureBox();

            pb.BackgroundImage = Image.FromFile("anh/0.png");
            pb.Width = 100;
            pb.Height = 100;
            DichVuDTO dichVu = new DichVuDTO();
            dichVu.MaDichVu = 0;
            dichVu.TenDichVu = "Tất cả";
            pb.Tag = dichVu;
            pb.MouseEnter += PB_MouseEnter;
            pb.MouseLeave += PB_MouseLeave;
            pb.Click += PB_Click;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.Margin = new Padding(15);
            PnDSDichVu.Controls.Add(pb);
            List<DichVuDTO> dichVus = DichVuDAO.layDSDichVu();
            
            for (int index = 0;index < dichVus.Count; ++index)
            {
                dichVu = dichVus[index];
                 pb = new PictureBox();

                pb.BackgroundImage = Image.FromFile("anh/"+(dichVu.MaDichVu).ToString()+".png");
                pb.Width = 100;
                pb.Height = 100;
                pb.Tag = dichVu;
                pb.MouseEnter += PB_MouseEnter;
                pb.MouseLeave += PB_MouseLeave;
                pb.Click += PB_Click;
                pb.SizeMode = PictureBoxSizeMode.AutoSize;
                pb.Margin = new Padding(15);
                PnDSDichVu.Controls.Add(pb);
            }
            
            
        }

        private void LB_CapNhatDuLieu_MouseEnter(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu_MouseEnter(sender, e);
        }

        private void LB_CapNhatDuLieu_MouseLeave(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu_MouseLeave(sender, e);
        }

        private void Panel_CapNhatDuLieu_MouseEnter(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu.BackgroundImage = District4_SearchService.Properties.Resources.background2;
        }

        private void Panel_CapNhatDuLieu_MouseLeave(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu.BackgroundImage = District4_SearchService.Properties.Resources.staticbutton2;
        }

        private void PB_CapNhatDuLieu_MouseEnter(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu_MouseEnter(sender, e);
        }

        private void PB_CapNhatDuLieu_MouseLeave(object sender, EventArgs e)
        {
            Panel_CapNhatDuLieu_MouseLeave(sender, e);
        }
        private void PB_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            lbThongBao.Text = ((DichVuDTO)pb.Tag).TenDichVu;

            
            
        }

        private void PB_MouseLeave(object sender, EventArgs e)
        {
            lbThongBao.Text = "Chọn một dịch vụ để tìm kiếm.";
            //PictureBox pb = (PictureBox)sender;

            //PB_Description.BackgroundImage = District4_SearchService.Properties.Resources.descript_none;

            //switch (pb.Name)
            //{
            //    case "PB_TatCa":
            //        PB_TatCa.BackgroundImage = District4_SearchService.Properties.Resources.icon_tatca_hover;
            //        break;
            //    case "PB_ATM":
            //        PB_ATM.BackgroundImage = District4_SearchService.Properties.Resources.icon_atm_hover;
            //        break;
            //    case "PB_CayXang":
            //        PB_CayXang.BackgroundImage = District4_SearchService.Properties.Resources.icon_cayxang_hover;
            //        break;
            //    case "PB_BenhVien":
            //        PB_BenhVien.BackgroundImage = District4_SearchService.Properties.Resources.icon_benhvien_hover;
            //        break;
            //    case "PB_NhaHang":
            //        PB_NhaHang.BackgroundImage = District4_SearchService.Properties.Resources.icon_nhahang_hover;
            //        break;
            //    case "PB_SieuThi":
            //        PB_SieuThi.BackgroundImage = District4_SearchService.Properties.Resources.icon_sieuthi_hover;
            //        break;
            //    case "PB_NganHang":
            //        PB_NganHang.BackgroundImage = District4_SearchService.Properties.Resources.icon_nganhang_hover;
            //        break;
            //    case "PB_BuuDien":
            //        PB_BuuDien.BackgroundImage = District4_SearchService.Properties.Resources.icon_buudien_hover;
            //        break;
            //    case "PB_RapChieuPhim":
            //        PB_RapChieuPhim.BackgroundImage = District4_SearchService.Properties.Resources.icon_rapchieuphim_hover;
            //        break;
            //    default:
            //        pb.BackgroundImage = null;
            //        break;
            //}
        }
        private int getMaDichVuDuocChon(object sender, EventArgs e)
        {
            int maDichVuDuocChon = 0;
            PictureBox pb = (PictureBox)sender;
            DichVuDTO dichVu = (DichVuDTO)pb.Tag;
            maDichVuDuocChon = dichVu.MaDichVu;

            return maDichVuDuocChon;
        }
        
        private void PB_Click(object sender, EventArgs e)
        {
            int maDichVuDuocChon = getMaDichVuDuocChon(sender, e);
            Point location = this.Location;
            frmTimKiem form = new frmTimKiem();
            form.MaDichVuMacDinh = maDichVuDuocChon;
            form.Location = location;
            form.parent = this;

            while (this.Opacity > 0)
            {
                this.Opacity -= 0.3;
                System.Threading.Thread.Sleep(1);
                this.Refresh();
            }

            this.Visible = false;
            this.Opacity = 1.0;
            form.Opacity = 0;
            form.Show();

            while (form.Opacity < 1.0)
            {
                form.Opacity += 0.3;
                System.Threading.Thread.Sleep(1);
                form.Refresh();
            }
        }

        private void Form_DanhSach_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmDanhSach_SizeChanged(object sender, EventArgs e)
        {
            SetLocation();

        }

        private void SetLocation()
        {
            int x = (int)(this.Width * (.25 + .03));
            int j = (this.Height - 40) / 7;
            int y2 = j * 3;
            Point topLeftTinhTrang = new Point();
            topLeftTinhTrang.X = x;
            topLeftTinhTrang.Y = 40;
            pnTinhTrangDuLieu.Location = topLeftTinhTrang;
            pnTinhTrangDuLieu.Height = j - 5;

            Point topLeftThongBao = new Point();
            topLeftThongBao.X = x;
            topLeftThongBao.Y = j * 6 + 9;
            pnThongBao.Location = topLeftThongBao;
            pnThongBao.Height = j - 10;

            Point topLeftDSDichVu = new Point();
            topLeftDSDichVu.X = x;
            topLeftDSDichVu.Y = j + 55;
            PnDSDichVu.Location = topLeftDSDichVu;
            PnDSDichVu.Height = j * 4;

            PnDSDichVu.Width = (int)(x * (3 - .5));
            pnThongBao.Width = PnDSDichVu.Width;
            pnTinhTrangDuLieu.Width = pnThongBao.Width;
        }
    }
}
